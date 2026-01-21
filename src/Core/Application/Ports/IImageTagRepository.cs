using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Core.Application.Ports;

public interface IImageTagRepository
{
    Task AddAsync(int imageId, int tagId);
    Task RemoveAsync(int imageId, int tagId);
    Task RemoveAllByImageIdAsync(int imageId);
    Task RemoveAllByTagIdAsync(int tagId);
    Task<IEnumerable<int>> GetImageIdsByTagIdAsync(int tagId);
    Task<IEnumerable<int>> GetTagIdsByImageIdAsync(int imageId);
    Task<bool> ExistsAsync(int imageId, int tagId);
}
