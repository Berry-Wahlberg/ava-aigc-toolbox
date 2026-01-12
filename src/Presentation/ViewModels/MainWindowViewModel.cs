using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
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
                Images = new ObservableCollection<Image>(images);
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

        // Apply NSFW filter
        if (!ShowNSFW)
        {
            filtered = filtered.Where(img => !img.NSFW);
        }

        // Apply minimum rating filter
        if (MinRating > 0)
        {
            filtered = filtered.Where(img => img.Rating >= MinRating);
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
        return SortOption switch
        {
            "Date Created" => images.OrderByDescending(img => img.CreatedDate),
            "Aesthetic Score" => images.OrderByDescending(img => img.AestheticScore),
            "Rating" => images.OrderByDescending(img => img.Rating),
            "File Name" => images.OrderBy(img => img.FileName),
            "Model Name" => images.OrderBy(img => img.Model),
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
                Title = "Select Folder to Import",
                AllowMultiple = false
            };
            
            var result = await mainWindow.StorageProvider.OpenFolderPickerAsync(options);
            
            if (result == null || result.Count == 0)
            {
                // User cancelled the dialog
                StatusMessage = "Import cancelled by user.";
                return;
            }
            
            var folderPath = result[0].Path.LocalPath;
            
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
