using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Avalonia;
using AIGenManager.Application.UseCases.Folders;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Application.UseCases.Tags;
using AIGenManager.Application.UseCases.Albums;
using AIGenManager.Core.Domain.Entities;
// Use specific namespaces to avoid ambiguity
using OpenFolderDialog = Avalonia.Controls.OpenFolderDialog;
using Window = Avalonia.Controls.Window;

namespace BerryAIGCToolbox.ViewModels;

[DebuggerDisplay($"{{nameof(GetDebuggerDisplay)}},nq")] 
public partial class MainWindowViewModel : ViewModelBase
{
    private readonly GetRootFoldersUseCase _getRootFoldersUseCase;
    private readonly GetAllImagesUseCase _getAllImagesUseCase;
    private readonly GetImagesByFolderIdUseCase _getImagesByFolderIdUseCase;
    private readonly AIGenManager.Application.UseCases.Folders.ScanFolderUseCase _scanFolderUseCase;
    private readonly AIGenManager.Core.Domain.Services.IThumbnailGenerationService _thumbnailGenerationService;
    
    // Tag use cases
    private readonly GetAllTagsUseCase _getAllTagsUseCase;
    private readonly AddTagUseCase _addTagUseCase;
    
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
        _ = LoadImagesForFolderAsync();
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

    // New properties for modern UI
    [ObservableProperty]
    private string _searchQuery = string.Empty;

    [ObservableProperty]
    private string _sortOption = "Date Created";

    [ObservableProperty]
    private bool _isGridviewSelected = true;

    [ObservableProperty]
    private bool _isListviewSelected = false;

    [ObservableProperty]
    private bool _showNSFW = false;

    [ObservableProperty]
    private int _minRating = 0;

    [ObservableProperty]
    private bool _onlyFavorites = false;

    // Filtered images based on search, tags, and other criteria
    [ObservableProperty]
    private ObservableCollection<Image> _filteredImages = [];

    // Available sort options
    public List<string> SortOptions => new List<string>
    {
        "Date Created",
        "Aesthetic Score",
        "Rating",
        "File Name",
        "Model Name",
        "Steps"
    };

    // Available rating options
    public List<int> RatingOptions => new List<int> { 0, 1, 2, 3, 4, 5 };

    // Apply filters whenever relevant properties change
    partial void OnSearchQueryChanged(string value)
    {
        ApplyFilters();
    }

    partial void OnSortOptionChanged(string value)
    {
        ApplyFilters();
    }

    partial void OnShowNSFWChanged(bool value)
    {
        ApplyFilters();
    }

    partial void OnMinRatingChanged(int value)
    {
        ApplyFilters();
    }

    partial void OnOnlyFavoritesChanged(bool value)
    {
        ApplyFilters();
    }

    partial void OnImagesChanged(ObservableCollection<Image> value)
    {
        ApplyFilters();
    }

    partial void OnSelectedTagChanged(Tag? value)
    {
        ApplyFilters();
    }

    partial void OnSelectedAlbumChanged(Album? value)
    {
        ApplyFilters();
    }

    [RelayCommand]
    private async Task RefreshData()
    {
        await LoadData();
    }

    [RelayCommand]
    private async Task CleanupThumbnails()
    {
        try
        {
            IsLoading = true;
            StatusMessage = "Cleaning up invalid thumbnails...";
            
            await _thumbnailGenerationService.CleanupInvalidThumbnailsAsync();
            
            StatusMessage = "Thumbnail cleanup completed successfully.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error cleaning up thumbnails: {ex.Message}";
            Debug.WriteLine($"Error cleaning up thumbnails: {ex.Message}");
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async Task LoadImagesForSelectedFolder()
    {
        await LoadImagesForFolderAsync();
    }

    private async Task LoadImagesForFolderAsync()
    {
        if (SelectedFolder != null)
        {
            try
            {
                IsLoading = true;
                StatusMessage = "Loading images for folder...";
                var request = new GetImagesByFolderIdRequest(SelectedFolder.Id);
                var images = await _getImagesByFolderIdUseCase.ExecuteAsync(request);
                
                // Create observable collection
                Images = new ObservableCollection<Image>(images);
                
                // Generate thumbnails for images that don't have them
                await GenerateMissingThumbnailsAsync(Images);
                
                StatusMessage = $"Loaded {Images.Count} images for folder: {SelectedFolder.Path}";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading images for folder: {ex.Message}");
                StatusMessage = $"Error loading images for folder: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
    
    /// <summary>
    /// Generates thumbnails for images that don't have them
    /// </summary>
    /// <param name="images">Collection of images to process</param>
    private async Task GenerateMissingThumbnailsAsync(IEnumerable<Image> images)
    {
        var imagesToProcess = images.ToList();
        if (imagesToProcess.Count == 0)
        {
            return;
        }
        
        StatusMessage = $"Generating thumbnails for {imagesToProcess.Count} images...";
        
        const int MAX_CONCURRENT_TASKS = 8;
        var semaphore = new SemaphoreSlim(MAX_CONCURRENT_TASKS);
        var tasks = new List<Task>();
        var successCount = 0;
        var failureCount = 0;
        
        foreach (var img in imagesToProcess)
        {
            await semaphore.WaitAsync();
            
            var task = Task.Run(async () =>
            {
                try
                {
                    img.ThumbnailLoadStatus = ThumbnailLoadStatus.Loading;
                    
                    if (!File.Exists(img.Path))
                    {
                        Debug.WriteLine($"Image file not found: {img.Path}");
                        img.ThumbnailPath = string.Empty;
                        img.ThumbnailLoadStatus = ThumbnailLoadStatus.Failed;
                        return;
                    }
                    
                    var thumbnailPath = await _thumbnailGenerationService.GetOrGenerateThumbnailAsync(img.Path);
                    
                    if (!string.IsNullOrEmpty(thumbnailPath) && File.Exists(thumbnailPath))
                    {
                        img.ThumbnailPath = thumbnailPath;
                        img.ThumbnailLoadStatus = ThumbnailLoadStatus.Loaded;
                        Interlocked.Increment(ref successCount);
                    }
                    else
                    {
                        Debug.WriteLine($"Failed to generate thumbnail for: {img.Path}");
                        img.ThumbnailPath = string.Empty;
                        img.ThumbnailLoadStatus = ThumbnailLoadStatus.Failed;
                        Interlocked.Increment(ref failureCount);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error generating thumbnail for {img.Path}: {ex.Message}");
                    Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                    img.ThumbnailPath = string.Empty;
                    img.ThumbnailLoadStatus = ThumbnailLoadStatus.Failed;
                    Interlocked.Increment(ref failureCount);
                }
                finally
                {
                    semaphore.Release();
                }
            });
            
            tasks.Add(task);
        }
        
        await Task.WhenAll(tasks);
        
        StatusMessage = $"Thumbnail generation completed. Success: {successCount}, Failed: {failureCount}";
    }

    /// <summary>
    /// Applies all filters to the images collection
    /// </summary>
    private void ApplyFilters()
    {
        if (Images == null)
        {
            FilteredImages = new ObservableCollection<Image>();
            return;
        }

        IEnumerable<Image> filtered = Images;

        // Apply NSFW filter - only filter out images that are explicitly marked as NSFW
        if (!ShowNSFW)
        {
            filtered = filtered.Where(img => img.NSFW != true);
        }

        // Apply minimum rating filter - only filter if MinRating > 0 and image has a rating
        if (MinRating > 0)
        {
            filtered = filtered.Where(img => img.Rating == null || img.Rating >= MinRating);
        }

        // Apply favorites filter
        if (OnlyFavorites)
        {
            filtered = filtered.Where(img => img.Favorite);
        }

        // Apply search query
        if (!string.IsNullOrWhiteSpace(SearchQuery))
        {
            var query = SearchQuery.ToLowerInvariant();
            filtered = filtered.Where(img =>
                (img.Prompt?.ToLowerInvariant().Contains(query) ?? false) ||
                (img.NegativePrompt?.ToLowerInvariant().Contains(query) ?? false) ||
                (img.FileName?.ToLowerInvariant().Contains(query) ?? false) ||
                (img.Model?.ToLowerInvariant().Contains(query) ?? false) ||
                (img.Sampler?.ToLowerInvariant().Contains(query) ?? false));
        }

        // Apply selected tag filter
        if (SelectedTag != null)
        {
            // This is a placeholder - in reality, you'd check if the image has the selected tag
            // filtered = filtered.Where(img => img.Tags.Contains(SelectedTag));
        }

        // Apply selected album filter
        if (SelectedAlbum != null)
        {
            // This is a placeholder - in reality, you'd check if the image is in the selected album
            // filtered = filtered.Where(img => img.Albums.Contains(SelectedAlbum));
        }

        // Apply sorting
        filtered = ApplySorting(filtered);

        // Update filtered images collection
        FilteredImages = new ObservableCollection<Image>(filtered);
    }

    /// <summary>
    /// Applies sorting based on the current sort option
    /// </summary>
    private IEnumerable<Image> ApplySorting(IEnumerable<Image> images)
    {
        // Handle null values in sorting to prevent images from being filtered out
        return SortOption switch
        {
            "Date Created" => images.OrderByDescending(img => img.CreatedDate),
            "Aesthetic Score" => images.OrderByDescending(img => img.AestheticScore ?? 0),
            "Rating" => images.OrderByDescending(img => img.Rating ?? 0),
            "File Name" => images.OrderBy(img => img.FileName ?? ""),
            "Model Name" => images.OrderBy(img => img.Model ?? ""),
            "Steps" => images.OrderByDescending(img => img.Steps),
            _ => images.OrderByDescending(img => img.CreatedDate)
        };
    }

    [RelayCommand]
    private async Task LoadImagesByAlbum(Album album)
    {
        if (album != null)
        {
            try
            {
                IsLoading = true;
                StatusMessage = $"Loading images for album: {album.Name}...";
                var request = new GetImagesByAlbumIdRequest(album.Id);
                var images = await _getImagesByAlbumIdUseCase.ExecuteAsync(request);
                Images = new ObservableCollection<Image>(images);
                
                // Generate thumbnails for images that don't have them
                await GenerateMissingThumbnailsAsync(Images);
                
                StatusMessage = $"Loaded {Images.Count} images for album: {album.Name}";
                SelectedAlbum = album;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading images for album: {ex.Message}");
                StatusMessage = $"Error loading images for album: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private void ToggleFavorite(Image image)
    {
        if (image != null)
        {
            image.Favorite = !image.Favorite;
            // In a real implementation, you'd save this to the database
            ApplyFilters(); // Refresh the filtered list if only favorites is selected
        }
    }

    [RelayCommand]
    public void OpenImage(Image image)
    {
        if (image != null && !string.IsNullOrEmpty(image.Path))
        {
            try
            {
                // Open the image file with the default application
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = image.Path,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error opening image: {ex.Message}";
                Debug.WriteLine($"Error opening image: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Sets the rating for an image
    /// </summary>
    /// <param name="image">The image to rate</param>
    /// <param name="rating">The rating to set (0-5)</param>
    public void SetRating(Image image, int rating)
    {
        if (image != null)
        {
            image.Rating = rating;
            // In a real implementation, you'd save this to the database
            ApplyFilters(); // Refresh the filtered list if rating filter is applied
        }
    }

    [RelayCommand]
    private void ToggleNSFW(Image image)
    {
        if (image != null)
        {
            image.NSFW = !image.NSFW;
            // In a real implementation, you'd save this to the database
            ApplyFilters(); // Refresh the filtered list if NSFW filter is applied
        }
    }

    [RelayCommand]
    private async Task AddNewTag()
    {
        if (!string.IsNullOrWhiteSpace(NewTagName))
        {
            try
            {
                IsLoading = true;
                StatusMessage = $"Adding tag: {NewTagName}...";
                var tag = await _addTagUseCase.ExecuteAsync(new AddTagRequest(NewTagName));
                if (tag != null)
                {
                    Tags.Add(tag);
                    NewTagName = string.Empty;
                    StatusMessage = $"Tag '{tag.Name}' added successfully";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error adding tag: {ex.Message}");
                StatusMessage = $"Error adding tag: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task AddNewAlbum()
    {
        if (!string.IsNullOrWhiteSpace(NewAlbumName))
        {
            try
            {
                IsLoading = true;
                StatusMessage = $"Adding album: {NewAlbumName}...";
                var album = await _addAlbumUseCase.ExecuteAsync(new AddAlbumRequest(NewAlbumName));
                if (album != null)
                {
                    Albums.Add(album);
                    NewAlbumName = string.Empty;
                    StatusMessage = $"Album '{album.Name}' added successfully";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error adding album: {ex.Message}");
                StatusMessage = $"Error adding album: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private void ToggleView()
    {
        IsGridviewSelected = !IsGridviewSelected;
        IsListviewSelected = !IsListviewSelected;
    }

    public MainWindowViewModel(
        GetRootFoldersUseCase getRootFoldersUseCase,
        GetAllImagesUseCase getAllImagesUseCase,
        GetImagesByFolderIdUseCase getImagesByFolderIdUseCase,
        AIGenManager.Application.UseCases.Folders.ScanFolderUseCase scanFolderUseCase,
        AIGenManager.Core.Domain.Services.IThumbnailGenerationService thumbnailGenerationService,
        
        // Tag use cases
        GetAllTagsUseCase getAllTagsUseCase,
        AddTagUseCase addTagUseCase,
        
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
        _thumbnailGenerationService = thumbnailGenerationService;
        
        _getAllTagsUseCase = getAllTagsUseCase;
        _addTagUseCase = addTagUseCase;
        
        _getAllAlbumsUseCase = getAllAlbumsUseCase;
        _addAlbumUseCase = addAlbumUseCase;
        _addImageToAlbumUseCase = addImageToAlbumUseCase;
        _getImagesByAlbumIdUseCase = getImagesByAlbumIdUseCase;
        
        // Start loading data asynchronously without blocking the constructor
        _ = Task.Run(() => LoadData());
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
            
            // Generate thumbnails for all loaded images
            if (Images.Any())
            {
                await GenerateMissingThumbnailsAsync(Images);
            }
            
            StatusMessage = "Loading tags...";
            await LoadTags();
            
            StatusMessage = "Loading albums...";
            await LoadAlbums();
            
            HasData = Folders.Any() || Images.Any() || Tags.Any() || Albums.Any();
            StatusMessage = HasData ? "Data loaded successfully" : "No data found. Import images to get started.";
            
            // Initialize filtered images
            ApplyFilters();
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
            Console.WriteLine("Loading images from database...");
            var images = await _getAllImagesUseCase.ExecuteAsync();
            Console.WriteLine($"Loaded {images.Count()} images from database");
            Images = new ObservableCollection<Image>(images);
            Console.WriteLine($"Set Images property to {Images.Count} images");
            // Explicitly call ApplyFilters to ensure FilteredImages is updated
            ApplyFilters();
            Console.WriteLine($"Applied filters, FilteredImages count: {FilteredImages.Count}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading images: {ex.Message}");
            Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            Console.WriteLine($"Error loading images: {ex.Message}");
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
            // Get the main window reference
            var mainWindow = ViewModelBase.MainWindow;
            if (mainWindow == null)
            {
                StatusMessage = "Error: Main window not found.";
                return;
            }
            
            // Use Avalonia's StorageProvider API for folder selection
            var options = new Avalonia.Platform.Storage.FolderPickerOpenOptions
            {
                Title = "Select Folders to Import",
                AllowMultiple = true
            };
            
            var result = await mainWindow.StorageProvider.OpenFolderPickerAsync(options);
            
            if (result == null || result.Count == 0)
            {
                // User cancelled the dialog
                StatusMessage = "Import cancelled by user.";
                return;
            }
            
            IsLoading = true;
            int totalProcessed = 0;
            
            // Process all selected folders
            foreach (var folder in result)
            {
                var folderPath = folder.Path.LocalPath;
                StatusMessage = $"Scanning folder: {folderPath}...";
                
                var request = new ScanFolderRequest(folderPath, true);
                var processedCount = await _scanFolderUseCase.ExecuteAsync(request);
                totalProcessed += processedCount;
            }
            
            // Refresh data
            await LoadFolders();
            await LoadImages();
            
            // Generate thumbnails for newly imported images
            if (Images.Any())
            {
                await GenerateMissingThumbnailsAsync(Images);
            }
            
            StatusMessage = $"Successfully imported {totalProcessed} images from {result.Count} folders";
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
