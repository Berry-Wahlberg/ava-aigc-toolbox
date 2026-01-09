using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Core.Application.Ports;

public interface ITagRepository
{
    Task<IEnumerable<Tag>> GetAllAsync();
    Task<Tag?> GetByIdAsync(int id);
    Task<Tag?> GetByNameAsync(string name);
    Task<Tag> AddAsync(Tag tag);
    Task<Tag> UpdateAsync(Tag tag);
    Task DeleteAsync(int id);
    Task<IEnumerable<Tag>> GetTagsByImageIdAsync(int imageId);
}
