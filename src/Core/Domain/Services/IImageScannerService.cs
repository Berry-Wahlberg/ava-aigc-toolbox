using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Core.Domain.Services;

/// <summary>
/// 图片扫描服务接口
/// </summary>
public interface IImageScannerService
{
    /// <summary>
    /// 扫描指定目录下的图片文件
    /// </summary>
    /// <param name="directoryPath">目录路径</param>
    /// <param name="includeSubdirectories">是否包含子目录</param>
    /// <returns>图片实体列表</returns>
    Task<IEnumerable<Image>> ScanImagesAsync(string directoryPath, bool includeSubdirectories = true);
    
    /// <summary>
    /// 获取指定图片的缩略图
    /// </summary>
    /// <param name="imagePath">图片路径</param>
    /// <param name="thumbnailSize">缩略图尺寸</param>
    /// <returns>缩略图流</returns>
    Task<MemoryStream> GetThumbnailAsync(string imagePath, int thumbnailSize = 200);
    
    /// <summary>
    /// 取消当前扫描操作
    /// </summary>
    void CancelScan();
}