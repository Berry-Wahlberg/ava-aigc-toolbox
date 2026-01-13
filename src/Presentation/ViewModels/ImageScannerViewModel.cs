using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AIGenManager.Core.Domain.Entities;
using AIGenManager.Core.Domain.Services;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;

// 为实体类Image添加别名，避免与Avalonia.Controls.Image冲突
using DomainImage = AIGenManager.Core.Domain.Entities.Image;

namespace BerryAIGCToolbox.ViewModels;

public partial class ImageScannerViewModel : ViewModelBase
{
    private readonly IImageScannerService _imageScannerService;
    private readonly IThumbnailGenerationService _thumbnailGenerationService;
    
    [ObservableProperty]
    private ObservableCollection<DomainImage> _images = new ObservableCollection<DomainImage>();
    
    [ObservableProperty]
    private bool _isScanning = false;
    
    [ObservableProperty]
    private bool _isLoading = false;
    
    [ObservableProperty]
    private string _statusMessage = "";
    
    [ObservableProperty]
    private int _scanProgress = 0;
    
    [ObservableProperty]
    private string _selectedDirectory = string.Empty;
    
    [ObservableProperty]
    private bool _includeSubdirectories = true;
    
    public ImageScannerViewModel(
        IImageScannerService imageScannerService,
        IThumbnailGenerationService thumbnailGenerationService)
    {
        _imageScannerService = imageScannerService;
        _thumbnailGenerationService = thumbnailGenerationService;
    }
    
    [RelayCommand]
    private async Task ScanImagesAsync()
    {
        if (string.IsNullOrEmpty(SelectedDirectory) || !Directory.Exists(SelectedDirectory))
        {
            StatusMessage = "Please select a valid directory.";
            return;
        }
        
        try
        {
            IsScanning = true;
            StatusMessage = "Scanning images...";
            ScanProgress = 0;
            
            // 清空现有图片
            Images.Clear();
            
            // 使用图片扫描服务扫描图片
            var scannedImages = await _imageScannerService.ScanImagesAsync(SelectedDirectory, IncludeSubdirectories);
            
            // 将扫描到的图片添加到集合中
            foreach (var image in scannedImages)
            {
                Images.Add(image);
            }
            
            // 生成缩略图
            await GenerateThumbnailsAsync();
            
            StatusMessage = $"Scanned {Images.Count} images successfully.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error scanning images: {ex.Message}";
        }
        finally
        {
            IsScanning = false;
        }
    }
    
    [RelayCommand]
    private async Task SelectDirectoryAsync()
    {
        // 使用Avalonia的StorageProvider API选择文件夹
        var mainWindow = ViewModelBase.MainWindow;
        if (mainWindow == null)
        {
            StatusMessage = "Error: Main window not found.";
            return;
        }
        
        var options = new Avalonia.Platform.Storage.FolderPickerOpenOptions
        {
            Title = "Select Image Directory",
            AllowMultiple = false
        };
        
        var result = await mainWindow.StorageProvider.OpenFolderPickerAsync(options);
        
        if (result != null && result.Count > 0)
        {
            SelectedDirectory = result[0].Path.LocalPath;
        }
    }
    
    [RelayCommand]
    private void CancelScan()
    {
        _imageScannerService.CancelScan();
    }
    
    /// <summary>
    /// 生成所有图片的缩略图
    /// </summary>
    private async Task GenerateThumbnailsAsync()
    {
        if (Images.Count == 0)
        {
            return;
        }
        
        IsLoading = true;
        StatusMessage = "Generating thumbnails...";
        
        try
        {
            // 并行生成缩略图
            var tasks = Images.Select(async img =>
            {
                try
                {
                    img.ThumbnailLoadStatus = ThumbnailLoadStatus.Loading;
                    
                    // 使用缩略图生成服务生成缩略图
                    var thumbnailPath = await _thumbnailGenerationService.GetOrGenerateThumbnailAsync(img.Path);
                    
                    img.ThumbnailPath = thumbnailPath;
                    img.ThumbnailLoadStatus = !string.IsNullOrEmpty(thumbnailPath) ? ThumbnailLoadStatus.Loaded : ThumbnailLoadStatus.Failed;
                }
                catch (Exception ex)
                {
                    img.ThumbnailPath = string.Empty;
                    img.ThumbnailLoadStatus = ThumbnailLoadStatus.Failed;
                    Console.WriteLine($"Error generating thumbnail for {img.Path}: {ex.Message}");
                }
            });
            
            await Task.WhenAll(tasks);
            
            StatusMessage = $"Generated thumbnails for {Images.Count} images.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error generating thumbnails: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }
}