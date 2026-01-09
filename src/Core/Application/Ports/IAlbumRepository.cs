using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Core.Application.Ports;

public interface IAlbumRepository
{
    Task<IEnumerable<Album>> GetAllAsync();
    Task<Album?> GetByIdAsync(int id);
    Task<Album> AddAsync(Album album);
    Task<Album> UpdateAsync(Album album);
    Task DeleteAsync(int id);
    Task<IEnumerable<Image>> GetImagesByAlbumIdAsync(int albumId);
    Task AddImageToAlbumAsync(int albumId, int imageId);
    Task RemoveImageFromAlbumAsync(int albumId, int imageId);
    Task<bool> IsImageInAlbumAsync(int albumId, int imageId);
}
