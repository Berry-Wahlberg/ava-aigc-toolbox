using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Core.Application.Ports;

public interface IPromptRepository
{
    Task<List<Prompt>> GetAllAsync();
    Task<Prompt?> GetByIdAsync(int id);
    Task<List<Prompt>> GetByNameAsync(string name);
    Task<List<Prompt>> GetByCategoryAsync(string category);
    Task<List<Prompt>> GetFavoritesAsync();
    Task<List<Prompt>> GetSystemPromptsAsync();
    Task<List<Prompt>> GetByContentAsync(string content);
    Task<Prompt> AddAsync(Prompt prompt);
    Task<Prompt> UpdateAsync(Prompt prompt);
    Task<bool> DeleteAsync(int id);
    Task<bool> IncrementUsageAsync(int id);
    Task<bool> SetFavoriteAsync(int id, bool isFavorite);
    Task<bool> SetSystemAsync(int id, bool isSystem);
    Task<List<Prompt>> SearchAsync(string query, bool includeNegative = false, bool includeSystem = false);
}
