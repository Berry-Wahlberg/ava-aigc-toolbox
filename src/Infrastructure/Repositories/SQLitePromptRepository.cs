using System.Data;
using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;
using SQLite;

namespace AIGenManager.Infrastructure.Repositories;

public class SQLitePromptRepository : IPromptRepository
{
    private readonly SQLiteConnection _connection;

    public SQLitePromptRepository(SQLiteConnection connection)
    {
        _connection = connection;
    }

    public Task<List<Prompt>> GetAllAsync()
    {
        var prompts = _connection.Table<Prompt>().OrderByDescending(p => p.CreatedDate).ToList();
        return Task.FromResult(prompts);
    }

    public Task<Prompt?> GetByIdAsync(int id)
    {
        var prompt = _connection.Table<Prompt>().FirstOrDefault(p => p.Id == id);
        return Task.FromResult(prompt);
    }

    public Task<List<Prompt>> GetByNameAsync(string name)
    {
        var prompts = _connection.Table<Prompt>().Where(p => p.Name.Contains(name)).ToList();
        return Task.FromResult(prompts);
    }

    public Task<List<Prompt>> GetByCategoryAsync(string category)
    {
        var prompts = _connection.Table<Prompt>().Where(p => p.Category == category).ToList();
        return Task.FromResult(prompts);
    }

    public Task<List<Prompt>> GetFavoritesAsync()
    {
        var prompts = _connection.Table<Prompt>().Where(p => p.IsFavorite).ToList();
        return Task.FromResult(prompts);
    }

    public Task<List<Prompt>> GetSystemPromptsAsync()
    {
        var prompts = _connection.Table<Prompt>().Where(p => p.IsSystem).ToList();
        return Task.FromResult(prompts);
    }

    public Task<List<Prompt>> GetByContentAsync(string content)
    {
        var prompts = _connection.Table<Prompt>()
            .Where(p => p.Content.Contains(content) || (p.NegativeContent != null && p.NegativeContent.Contains(content)))
            .ToList();
        return Task.FromResult(prompts);
    }

    public Task<Prompt> AddAsync(Prompt prompt)
    {
        _connection.Insert(prompt);
        return Task.FromResult(prompt);
    }

    public Task<Prompt> UpdateAsync(Prompt prompt)
    {
        _connection.Update(prompt);
        return Task.FromResult(prompt);
    }

    public Task<bool> DeleteAsync(int id)
    {
        _connection.Delete<Prompt>(id);
        return Task.FromResult(true);
    }

    public Task<bool> IncrementUsageAsync(int id)
    {
        var prompt = _connection.Table<Prompt>().FirstOrDefault(p => p.Id == id);
        if (prompt != null)
        {
            prompt.UsageCount++;
            prompt.LastUsedDate = DateTime.Now;
            _connection.Update(prompt);
        }
        return Task.FromResult(true);
    }

    public Task<bool> SetFavoriteAsync(int id, bool isFavorite)
    {
        var prompt = _connection.Table<Prompt>().FirstOrDefault(p => p.Id == id);
        if (prompt != null)
        {
            prompt.IsFavorite = isFavorite;
            _connection.Update(prompt);
        }
        return Task.FromResult(true);
    }

    public Task<bool> SetSystemAsync(int id, bool isSystem)
    {
        var prompt = _connection.Table<Prompt>().FirstOrDefault(p => p.Id == id);
        if (prompt != null)
        {
            prompt.IsSystem = isSystem;
            _connection.Update(prompt);
        }
        return Task.FromResult(true);
    }

    public Task<List<Prompt>> SearchAsync(string query, bool includeNegative = false, bool includeSystem = false)
    {
        var prompts = _connection.Table<Prompt>();

        if (!string.IsNullOrWhiteSpace(query))
        {
            var lowerQuery = query.ToLower();
            prompts = prompts.Where(p =>
                p.Name.ToLower().Contains(lowerQuery) ||
                p.Content.ToLower().Contains(lowerQuery) ||
                (p.Description != null && p.Description.ToLower().Contains(lowerQuery)));
        }

        if (includeNegative)
        {
            var lowerQuery = query.ToLower();
            prompts = prompts.Where(p => p.NegativeContent != null && p.NegativeContent.ToLower().Contains(lowerQuery));
        }

        if (includeSystem)
        {
            prompts = prompts.Where(p => p.IsSystem);
        }
        else
        {
            prompts = prompts.Where(p => !p.IsSystem);
        }

        return Task.FromResult(prompts.ToList());
    }
}
