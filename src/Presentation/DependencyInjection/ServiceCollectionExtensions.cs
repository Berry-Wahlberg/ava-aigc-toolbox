using Microsoft.Extensions.DependencyInjection;
using BerryAIGC.Toolkit.Services;

namespace BerryAIGC.Toolkit.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddSingleton<DataStore>();
        services.AddSingleton<Settings>();
        services.AddSingleton<NavigatorService>();
        services.AddSingleton<SearchService>();
        services.AddSingleton<FolderService>();
        services.AddSingleton<ThumbnailService>();
        services.AddSingleton<TagService>();
        services.AddSingleton<AlbumService>();
        services.AddSingleton<FileService>();
        services.AddSingleton<ScanningService>();
        services.AddSingleton<MetadataScannerService>();
        services.AddSingleton<MessageService>();
        services.AddSingleton<ToastService>();
        services.AddSingleton<WindowService>();
        services.AddSingleton<PreviewService>();
        services.AddSingleton<ProgressService>();
        services.AddSingleton<ContextMenuService>();
        services.AddSingleton<ExternalApplicationsService>();
        services.AddSingleton<IToastService, ToastService>();
    }
}
