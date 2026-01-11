using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using AIGenManager.Application.UseCases.Folders;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Application.UseCases.Tags;
using AIGenManager.Application.UseCases.Albums;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Presentation.ViewModels;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}},nq}}")]
public partial class MainWindowViewModel : ViewModelBase
{
    private readonly GetRootFoldersUseCase _getRootFoldersUseCase;
    private readonly GetAllImagesUseCase _getAllImagesUseCase;
    private readonly GetImagesByFolderIdUseCase _getImagesByFolderIdUseCase;
    
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

    [ObservableProperty]
    private Image? _selectedImage;

    [ObservableProperty]
    private string _newTagName = string.Empty;

    [ObservableProperty]
    private string _newAlbumName = string.Empty;

    public MainWindowViewModel(
        GetRootFoldersUseCase getRootFoldersUseCase,
        GetAllImagesUseCase getAllImagesUseCase,
        GetImagesByFolderIdUseCase getImagesByFolderIdUseCase,
        
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
        
        _getAllTagsUseCase = getAllTagsUseCase;
        _getTagsByImageIdUseCase = getTagsByImageIdUseCase;
        _addTagUseCase = addTagUseCase;
        _addTagToImageUseCase = addTagToImageUseCase;
        _removeTagFromImageUseCase = removeTagFromImageUseCase;
        
        _getAllAlbumsUseCase = getAllAlbumsUseCase;
        _addAlbumUseCase = addAlbumUseCase;
        _addImageToAlbumUseCase = addImageToAlbumUseCase;
        _getImagesByAlbumIdUseCase = getImagesByAlbumIdUseCase;
        
        LoadData();
    }

    private async void LoadData()
    {
        try
        {
            await LoadFolders();
            await LoadImages();
            await LoadTags();
            await LoadAlbums();
        }
        catch (Exception ex)
        {
            // Log error (in a real app, you'd use a logging framework)
            Debug.WriteLine($"Error loading data: {ex.Message}}");
        }
    }

    private async Task LoadFolders()
    {
        var folders = await _getRootFoldersUseCase.ExecuteAsync();
        Folders.Clear();
        foreach (var folder in folders)
        {
            Folders.Add(folder);
        }
    }

    private async Task LoadImages()
    {
        var images = await _getAllImagesUseCase.ExecuteAsync();
        Images.Clear();
        foreach (var image in images)
        {
            Images.Add(image);
        }
    }

    private async Task LoadTags()
    {
        var tags = await _getAllTagsUseCase.ExecuteAsync();
        Tags.Clear();
        foreach (var tag in tags)
        {
            Tags.Add(tag);
        }
    }

    private async Task LoadAlbums()
    {
        var albums = await _getAllAlbumsUseCase.ExecuteAsync();
        Albums.Clear();
        foreach (var album in albums)
        {
            Albums.Add(album);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}