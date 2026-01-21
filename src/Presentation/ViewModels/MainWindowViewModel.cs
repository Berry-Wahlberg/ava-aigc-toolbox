using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Application.UseCases.Folders;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Application.UseCases.Tags;
using AIGenManager.Application.UseCases.Albums;
using AIGenManager.Core.Domain.Entities;

namespace BerryAIGCToolbox.ViewModels;

[DebuggerDisplay($"{{nameof(GetDebuggerDisplay)}},nq")] 
public partial class MainWindowViewModel : ViewModelBase
{
    private readonly GetRootFoldersUseCase _getRootFoldersUseCase;
    private readonly GetAllImagesUseCase _getAllImagesUseCase;
    private readonly GetImagesByFolderIdUseCase _getImagesByFolderIdUseCase;
    private readonly AIGenManager.Application.UseCases.Folders.ScanFolderUseCase _scanFolderUseCase;
    
    // Tag use cases
    private readonly GetAllTagsUseCase _getAllTagsUseCase;
    private readonly GetTagsByImageIdUseCase _getTagsByImageIdUseCase;
    private readonly AddTagUseCase _addTagUseCase;
    private readonly AddTagToImageUseCase _addTagToImageUseCase;
    private readonly RemoveTagFromImageUseCase _removeTagFromImageUseCase;
    
    // Album use cases
    private readonly GetAllAlbumsUseCase _getAllAlbumsUseCase;
    private readonly AddAlbumUseCase _addAlbumUseCase;
    private readonly AddImageToAlbumUseCase _addImageToAlbumUseCase;
    private readonly GetImagesByAlbumIdUseCase _getImagesByAlbumIdUseCase;

    [ObservableProperty]
    private ObservableCollection<Folder> _folders = [];

    [ObservableProperty]
    private ObservableCollection<Image> _images = [];

    [ObservableProperty]
    private ObservableCollection<Tag> _tags = [];

    [ObservableProperty]
    private ObservableCollection<Album> _albums = [];

    [ObservableProperty]
    private Folder? _selectedFolder;

    public bool HasSelectedFolder => SelectedFolder != null;

    partial void OnSelectedFolderChanged(Folder? value)
    {
        OnPropertyChanged(nameof(HasSelectedFolder));
    }

    [ObservableProperty]
    private Image? _selectedImage;

    public bool HasSelectedImage => SelectedImage != null;

    partial void OnSelectedImageChanged(Image? value)
    {
        OnPropertyChanged(nameof(HasSelectedImage));
    }

    [ObservableProperty]
    private Tag? _selectedTag;

    [ObservableProperty]
    private Album? _selectedAlbum;

    [ObservableProperty]
    private string _newTagName = string.Empty;

    [ObservableProperty]
    private string _newAlbumName = string.Empty;

    [ObservableProperty]
    private bool _isLoading = false;

    [ObservableProperty]
    private string _statusMessage = string.Empty;

    [ObservableProperty]
    private bool _hasData = false;

    public bool IsNotLoading => !IsLoading;

    partial void OnHasDataChanged(bool value)
    {
        OnPropertyChanged(nameof(ShowEmptyState));
        OnPropertyChanged(nameof(ShowMainContent));
    }

    partial void OnIsLoadingChanged(bool value)
    {
        OnPropertyChanged(nameof(IsNotLoading));
        OnPropertyChanged(nameof(ShowEmptyState));
        OnPropertyChanged(nameof(ShowMainContent));
    }

    public bool ShowEmptyState => !IsLoading && !HasData;

    public bool ShowMainContent => !IsLoading && HasData;

    [RelayCommand]
    private async Task RefreshData()
    {
        await LoadData();
    }

    [RelayCommand]
    private async Task LoadImagesForSelectedFolder()
    {
        if (SelectedFolder != null)
        {
            try
            {
                var request = new GetImagesByFolderIdRequest(SelectedFolder.Id);
                var images = await _getImagesByFolderIdUseCase.ExecuteAsync(request);
                Images = new ObservableCollection<Image>(images);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading images for folder: {ex.Message}");
            }
        }
    }

    [RelayCommand]
    private async Task LoadSampleData()
    {
        try
        {
            IsLoading = true;
            StatusMessage = "Generating sample data...";
            
            // Create sample folders
            var sampleFolders = new List<Folder>
            {
                new Folder("C:/AI Images/Stable Diffusion") { IsRoot = true, ImageCount = 5 },
                new Folder("C:/AI Images/Midjourney") { IsRoot = true, ImageCount = 3 },
                new Folder("C:/AI Images/DALL-E") { IsRoot = true, ImageCount = 2 }
            };
            
            foreach (var folder in sampleFolders)
            {
                Folders.Add(folder);
            }
            
            // Create sample images
            var sampleImages = new List<Image>
            {
                new Image("C:/AI Images/Stable Diffusion/image1.png", "portrait_001.png") 
                { 
                    Prompt = "Portrait of a woman in a garden, digital art, detailed", 
                    Steps = 30, 
                    Sampler = "Euler a", 
                    CFGScale = 7.0m,
                    Seed = 1234567890,
                    Width = 512,
                    Height = 768,
                    Model = "SDXL 1.0",
                    Rating = 4,
                    Favorite = true
                },
                new Image("C:/AI Images/Stable Diffusion/image2.png", "landscape_002.png") 
                { 
                    Prompt = "Beautiful mountain landscape at sunset, photorealistic", 
                    Steps = 40, 
                    Sampler = "DPM++ 2M", 
                    CFGScale = 8.0m,
                    Seed = 9876543210,
                    Width = 1024,
                    Height = 768,
                    Model = "SDXL 1.0",
                    Rating = 5
                },
                new Image("C:/AI Images/Midjourney/image1.png", "fantasy_001.png") 
                { 
                    Prompt = "Dragon flying over a medieval castle, fantasy art", 
                    Steps = 25, 
                    Sampler = "Midjourney v6", 
                    CFGScale = 7.5m,
                    Seed = 4567890123,
                    Width = 1024,
                    Height = 1024,
                    Model = "Midjourney v6",
                    Rating = 5,
                    Favorite = true
                },
                new Image("C:/AI Images/DALL-E/image1.png", "abstract_001.png") 
                { 
                    Prompt = "Abstract geometric patterns with vibrant colors", 
                    Steps = 20, 
                    Sampler = "DALL-E 3", 
                    CFGScale = 6.5m,
                    Seed = 7890123456,
                    Width = 1024,
                    Height = 1024,
                    Model = "DALL-E 3",
                    Rating = 3
                }
            };
            
            foreach (var image in sampleImages)
            {
                Images.Add(image);
            }
            
            // Create sample tags
            var sampleTags = new List<Tag>
            {
                new Tag { Name = "Portrait" },
                new Tag { Name = "Landscape" },
                new Tag { Name = "Fantasy" },
                new Tag { Name = "Abstract" },
                new Tag { Name = "Digital Art" },
                new Tag { Name = "Photorealistic" }
            };
            
            foreach (var tag in sampleTags)
            {
                Tags.Add(tag);
            }
            
            // Create sample albums
            var sampleAlbums = new List<Album>
            {
                new Album { Name = "Favorites" },
                new Album { Name = "High Quality" },
                new Album { Name = "Portrait Collection" }
            };
            
            foreach (var album in sampleAlbums)
            {
                Albums.Add(album);
            }
            
            HasData = true;
            StatusMessage = "Sample data loaded successfully!";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error loading sample data: {ex.Message}";
            Debug.WriteLine($"Error loading sample data: {ex.Message}");
        }
        finally
        {
            IsLoading = false;
        }
    }

    public MainWindowViewModel(
        GetRootFoldersUseCase getRootFoldersUseCase,
        GetAllImagesUseCase getAllImagesUseCase,
        GetImagesByFolderIdUseCase getImagesByFolderIdUseCase,
        AIGenManager.Application.UseCases.Folders.ScanFolderUseCase scanFolderUseCase,
        
        // Tag use cases
        GetAllTagsUseCase getAllTagsUseCase,
        GetTagsByImageIdUseCase getTagsByImageIdUseCase,
        AddTagUseCase addTagUseCase,
        AddTagToImageUseCase addTagToImageUseCase,
        RemoveTagFromImageUseCase removeTagFromImageUseCase,
        
        // Album use cases
        GetAllAlbumsUseCase getAllAlbumsUseCase,
        AddAlbumUseCase addAlbumUseCase,
        AddImageToAlbumUseCase addImageToAlbumUseCase,
        GetImagesByAlbumIdUseCase getImagesByAlbumIdUseCase)
    {
        _getRootFoldersUseCase = getRootFoldersUseCase;
        _getAllImagesUseCase = getAllImagesUseCase;
        _getImagesByFolderIdUseCase = getImagesByFolderIdUseCase;
        _scanFolderUseCase = scanFolderUseCase;
        
        _getAllTagsUseCase = getAllTagsUseCase;
        _getTagsByImageIdUseCase = getTagsByImageIdUseCase;
        _addTagUseCase = addTagUseCase;
        _addTagToImageUseCase = addTagToImageUseCase;
        _removeTagFromImageUseCase = removeTagFromImageUseCase;
        
        _getAllAlbumsUseCase = getAllAlbumsUseCase;
        _addAlbumUseCase = addAlbumUseCase;
        _addImageToAlbumUseCase = addImageToAlbumUseCase;
        _getImagesByAlbumIdUseCase = getImagesByAlbumIdUseCase;
        
        // Start loading data asynchronously without blocking the constructor
        _ = LoadData();
    }

    private async Task LoadData()
    {
        try
        {
            IsLoading = true;
            StatusMessage = "Loading folders...";
            await LoadFolders();
            
            StatusMessage = "Loading images...";
            await LoadImages();
            
            StatusMessage = "Loading tags...";
            await LoadTags();
            
            StatusMessage = "Loading albums...";
            await LoadAlbums();
            
            HasData = Folders.Any() || Images.Any() || Tags.Any() || Albums.Any();
            StatusMessage = HasData ? "Data loaded successfully" : "No data found. Import images or load sample data to get started.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error loading data: {ex.Message}";
            Debug.WriteLine($"Error loading data: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
        finally
        {
            IsLoading = false;
        }
    }

    private async Task LoadFolders()
    {
        try
        {
            var folders = await _getRootFoldersUseCase.ExecuteAsync();
            Folders = new ObservableCollection<Folder>(folders);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading folders: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private async Task LoadImages()
    {
        try
        {
            var images = await _getAllImagesUseCase.ExecuteAsync();
            Images = new ObservableCollection<Image>(images);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading images: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private async Task LoadTags()
    {
        try
        {
            var tags = await _getAllTagsUseCase.ExecuteAsync();
            Tags = new ObservableCollection<Tag>(tags);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading tags: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private async Task LoadAlbums()
    {
        try
        {
            var albums = await _getAllAlbumsUseCase.ExecuteAsync();
            Albums = new ObservableCollection<Album>(albums);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading albums: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    [RelayCommand]
    private async Task ImportFolder()
    {
        try
        {
            // Show folder picker dialog (implementation will depend on Avalonia UI framework)
            // For now, we'll simulate with a hardcoded path for testing
            var folderPath = "C:\\AI Images";
            
            IsLoading = true;
            StatusMessage = $"Scanning folder: {folderPath}...";
            
            var request = new ScanFolderRequest(folderPath, true);
            var processedCount = await _scanFolderUseCase.ExecuteAsync(request);
            
            // Refresh data
            await LoadFolders();
            await LoadImages();
            
            StatusMessage = $"Successfully imported {processedCount} images from {folderPath}";
            HasData = Folders.Any() || Images.Any() || Tags.Any() || Albums.Any();
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error importing folder: {ex.Message}";
            Debug.WriteLine($"Error importing folder: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
        finally
        {
            IsLoading = false;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString() ?? GetType().Name;
    }
}
