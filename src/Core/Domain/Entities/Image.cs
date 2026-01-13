using CommunityToolkit.Mvvm.ComponentModel;

namespace AIGenManager.Core.Domain.Entities;

public enum ImportStatus
{
    Pending,
    Success,
    Failed,
    RequiresManualEntry
}

public enum ThumbnailLoadStatus
{
    NotLoaded,
    Loading,
    Loaded,
    Failed,
    Regenerating
}

public partial class Image : ObservableObject
{
    // Required for SQLite-net
    public Image() {}
    
    private int _id;
    public int Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }
    
    private int _rootFolderId;
    public int RootFolderId
    {
        get => _rootFolderId;
        set => SetProperty(ref _rootFolderId, value);
    }
    
    private int _folderId;
    public int FolderId
    {
        get => _folderId;
        set => SetProperty(ref _folderId, value);
    }
    
    private string _path;
    public string Path
    {
        get => _path;
        set => SetProperty(ref _path, value);
    }
    
    private string _fileName;
    public string FileName
    {
        get => _fileName;
        set => SetProperty(ref _fileName, value);
    }
    
    private string? _prompt;
    public string? Prompt
    {
        get => _prompt;
        set => SetProperty(ref _prompt, value);
    }
    
    private string? _negativePrompt;
    public string? NegativePrompt
    {
        get => _negativePrompt;
        set => SetProperty(ref _negativePrompt, value);
    }
    
    private int _steps;
    public int Steps
    {
        get => _steps;
        set => SetProperty(ref _steps, value);
    }
    
    private string? _sampler;
    public string? Sampler
    {
        get => _sampler;
        set => SetProperty(ref _sampler, value);
    }
    
    private decimal _cfgScale;
    public decimal CFGScale
    {
        get => _cfgScale;
        set => SetProperty(ref _cfgScale, value);
    }
    
    private long _seed;
    public long Seed
    {
        get => _seed;
        set => SetProperty(ref _seed, value);
    }
    
    private int _width;
    public int Width
    {
        get => _width;
        set => SetProperty(ref _width, value);
    }
    
    private int _height;
    public int Height
    {
        get => _height;
        set => SetProperty(ref _height, value);
    }
    
    private string? _modelHash;
    public string? ModelHash
    {
        get => _modelHash;
        set => SetProperty(ref _modelHash, value);
    }
    
    private string? _model;
    public string? Model
    {
        get => _model;
        set => SetProperty(ref _model, value);
    }
    
    private int _batchSize;
    public int BatchSize
    {
        get => _batchSize;
        set => SetProperty(ref _batchSize, value);
    }
    
    private int _batchPos;
    public int BatchPos
    {
        get => _batchPos;
        set => SetProperty(ref _batchPos, value);
    }
    
    private DateTime _createdDate;
    public DateTime CreatedDate
    {
        get => _createdDate;
        set => SetProperty(ref _createdDate, value);
    }
    
    private DateTime _modifiedDate;
    public DateTime ModifiedDate
    {
        get => _modifiedDate;
        set => SetProperty(ref _modifiedDate, value);
    }
    
    // User-defined properties
    private string? _customTags;
    public string? CustomTags
    {
        get => _customTags;
        set => SetProperty(ref _customTags, value);
    }
    
    private int? _rating;
    public int? Rating
    {
        get => _rating;
        set => SetProperty(ref _rating, value);
    }
    
    private bool _favorite;
    public bool Favorite
    {
        get => _favorite;
        set => SetProperty(ref _favorite, value);
    }
    
    private bool _forDeletion;
    public bool ForDeletion
    {
        get => _forDeletion;
        set => SetProperty(ref _forDeletion, value);
    }
    
    private bool _nsfw;
    public bool NSFW
    {
        get => _nsfw;
        set => SetProperty(ref _nsfw, value);
    }
    
    private bool _unavailable;
    public bool Unavailable
    {
        get => _unavailable;
        set => SetProperty(ref _unavailable, value);
    }
    
    // Additional properties
    private decimal? _aestheticScore;
    public decimal? AestheticScore
    {
        get => _aestheticScore;
        set => SetProperty(ref _aestheticScore, value);
    }
    
    private string? _hyperNetwork;
    public string? HyperNetwork
    {
        get => _hyperNetwork;
        set => SetProperty(ref _hyperNetwork, value);
    }
    
    private decimal? _hyperNetworkStrength;
    public decimal? HyperNetworkStrength
    {
        get => _hyperNetworkStrength;
        set => SetProperty(ref _hyperNetworkStrength, value);
    }
    
    private int? _clipSkip;
    public int? ClipSkip
    {
        get => _clipSkip;
        set => SetProperty(ref _clipSkip, value);
    }
    
    private int? _ensd;
    public int? ENSD
    {
        get => _ensd;
        set => SetProperty(ref _ensd, value);
    }
    
    private long _fileSize;
    public long FileSize
    {
        get => _fileSize;
        set => SetProperty(ref _fileSize, value);
    }
    
    private bool _noMetadata;
    public bool NoMetadata
    {
        get => _noMetadata;
        set => SetProperty(ref _noMetadata, value);
    }
    
    private string? _workflow;
    public string? Workflow
    {
        get => _workflow;
        set => SetProperty(ref _workflow, value);
    }
    
    private string? _workflowId;
    public string? WorkflowId
    {
        get => _workflowId;
        set => SetProperty(ref _workflowId, value);
    }
    
    private bool _hasError;
    public bool HasError
    {
        get => _hasError;
        set => SetProperty(ref _hasError, value);
    }
    
    private string? _hash;
    public string? Hash
    {
        get => _hash;
        set => SetProperty(ref _hash, value);
    }
    
    private DateTime? _viewedDate;
    public DateTime? ViewedDate
    {
        get => _viewedDate;
        set => SetProperty(ref _viewedDate, value);
    }
    
    private DateTime? _touchedDate;
    public DateTime? TouchedDate
    {
        get => _touchedDate;
        set => SetProperty(ref _touchedDate, value);
    }
    
    private ImageType _type;
    public ImageType Type
    {
        get => _type;
        set => SetProperty(ref _type, value);
    }
    
    private string? _thumbnailPath;
    public string? ThumbnailPath
    {
        get => _thumbnailPath;
        set => SetProperty(ref _thumbnailPath, value);
    }
    
    // 计算属性：直接返回缩略图URI
    public Uri? ThumbnailUri
    {
        get
        {
            if (string.IsNullOrEmpty(ThumbnailPath))
            {
                return null;
            }
            
            try
            {
                // 确保路径使用正确的URI格式
                string uriPath = ThumbnailPath;
                if (!uriPath.StartsWith("file://"))
                {
                    // 转换为绝对路径的URI格式
                    uriPath = uriPath.Replace('\\', '/');
                    if (!uriPath.StartsWith("/"))
                    {
                        uriPath = $"/{uriPath}";
                    }
                    uriPath = $"file://{uriPath}";
                }
                return new Uri(uriPath, UriKind.Absolute);
            }
            catch (Exception)
            {
                // 如果URI格式无效，返回null
                return null;
            }
        }
    }
    
    private ThumbnailLoadStatus _thumbnailLoadStatus = ThumbnailLoadStatus.NotLoaded;
    public ThumbnailLoadStatus ThumbnailLoadStatus
    {
        get => _thumbnailLoadStatus;
        set => SetProperty(ref _thumbnailLoadStatus, value);
    }
    
    // 计算属性：是否正在加载缩略图
    public bool IsThumbnailLoading => ThumbnailLoadStatus == ThumbnailLoadStatus.Loading;
    
    // 计算属性：是否加载失败
    public bool IsThumbnailFailed => ThumbnailLoadStatus == ThumbnailLoadStatus.Failed;
    
    // Import-related properties
    private ImportStatus _importStatus;
    public ImportStatus ImportStatus
    {
        get => _importStatus;
        set => SetProperty(ref _importStatus, value);
    }
    
    private string? _importErrorMessage;
    public string? ImportErrorMessage
    {
        get => _importErrorMessage;
        set => SetProperty(ref _importErrorMessage, value);
    }
    
    private bool _manualMetadataRequired;
    public bool ManualMetadataRequired
    {
        get => _manualMetadataRequired;
        set => SetProperty(ref _manualMetadataRequired, value);
    }

    public Image(string path, string fileName)
    {
        Path = path;
        FileName = fileName;
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
        Type = ImageType.Image;
        ImportStatus = ImportStatus.Pending;
    }
}