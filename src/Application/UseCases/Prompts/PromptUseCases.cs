using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Prompts;

public record GetAllPromptsRequest();

public record GetPromptByIdRequest(int Id);

public record GetPromptsByNameRequest(string Name);

public record GetPromptsByCategoryRequest(string Category);

public record GetPromptsByContentRequest(string Content);

public record AddPromptRequest(string Name, string Content, string? NegativeContent = null, string? Category = null, string? Description = null, bool IsFavorite = false, bool IsSystem = false);

public record UpdatePromptRequest(int Id, string? Name = null, string? Content = null, string? NegativeContent = null, string? Category = null, string? Description = null, bool? IsFavorite = null, bool? IsSystem = null);

public record DeletePromptRequest(int Id);

public record IncrementPromptUsageRequest(int Id);

public record SetPromptFavoriteRequest(int Id, bool IsFavorite);

public record SetPromptSystemRequest(int Id, bool IsSystem);

public record SearchPromptsRequest(string Query, bool IncludeNegative = false, bool IncludeSystem = false);

public class GetAllPromptsUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetAllPromptsUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync(GetAllPromptsRequest request)
    {
        return await _promptRepository.GetAllAsync();
    }
}

public class GetPromptByIdUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetPromptByIdUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<Prompt?> ExecuteAsync(GetPromptByIdRequest request)
    {
        return await _promptRepository.GetByIdAsync(request.Id);
    }
}

public class GetPromptsByNameUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetPromptsByNameUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync(GetPromptsByNameRequest request)
    {
        return await _promptRepository.GetByNameAsync(request.Name);
    }
}

public class GetPromptsByCategoryUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetPromptsByCategoryUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync(GetPromptsByCategoryRequest request)
    {
        return await _promptRepository.GetByCategoryAsync(request.Category);
    }
}

public class GetPromptsByContentUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetPromptsByContentUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync(GetPromptsByContentRequest request)
    {
        return await _promptRepository.GetByContentAsync(request.Content);
    }
}

public class GetFavoritesUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetFavoritesUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync()
    {
        return await _promptRepository.GetFavoritesAsync();
    }
}

public class GetSystemPromptsUseCase
{
    private readonly IPromptRepository _promptRepository;

    public GetSystemPromptsUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync()
    {
        return await _promptRepository.GetSystemPromptsAsync();
    }
}

public class AddPromptUseCase
{
    private readonly IPromptRepository _promptRepository;

    public AddPromptUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<Prompt> ExecuteAsync(AddPromptRequest request)
    {
        var prompt = new Prompt(request.Name, request.Content)
        {
            NegativeContent = request.NegativeContent,
            Category = request.Category,
            Description = request.Description,
            IsFavorite = request.IsFavorite,
            IsSystem = request.IsSystem
        };
        
        return await _promptRepository.AddAsync(prompt);
    }
}

public class UpdatePromptUseCase
{
    private readonly IPromptRepository _promptRepository;

    public UpdatePromptUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<Prompt> ExecuteAsync(UpdatePromptRequest request)
    {
        var prompt = await _promptRepository.GetByIdAsync(request.Id);
        if (prompt == null)
        {
            return null;
        }
        
        if (request.Name != null) prompt.Name = request.Name;
        if (request.Content != null) prompt.Content = request.Content;
        if (request.NegativeContent != null) prompt.NegativeContent = request.NegativeContent;
        if (request.Category != null) prompt.Category = request.Category;
        if (request.Description != null) prompt.Description = request.Description;
        if (request.IsFavorite != null) prompt.IsFavorite = request.IsFavorite.Value;
        if (request.IsSystem != null) prompt.IsSystem = request.IsSystem.Value;
        
        prompt.ModifiedDate = DateTime.Now;
        
        return await _promptRepository.UpdateAsync(prompt);
    }
}

public class DeletePromptUseCase
{
    private readonly IPromptRepository _promptRepository;

    public DeletePromptUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<bool> ExecuteAsync(DeletePromptRequest request)
    {
        return await _promptRepository.DeleteAsync(request.Id);
    }
}

public class IncrementPromptUsageUseCase
{
    private readonly IPromptRepository _promptRepository;

    public IncrementPromptUsageUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<bool> ExecuteAsync(IncrementPromptUsageRequest request)
    {
        return await _promptRepository.IncrementUsageAsync(request.Id);
    }
}

public class SetPromptFavoriteUseCase
{
    private readonly IPromptRepository _promptRepository;

    public SetPromptFavoriteUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<bool> ExecuteAsync(SetPromptFavoriteRequest request)
    {
        return await _promptRepository.SetFavoriteAsync(request.Id, request.IsFavorite);
    }
}

public class SetPromptSystemUseCase
{
    private readonly IPromptRepository _promptRepository;

    public SetPromptSystemUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<bool> ExecuteAsync(SetPromptSystemRequest request)
    {
        return await _promptRepository.SetSystemAsync(request.Id, request.IsSystem);
    }
}

public class SearchPromptsUseCase
{
    private readonly IPromptRepository _promptRepository;

    public SearchPromptsUseCase(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<List<Prompt>> ExecuteAsync(SearchPromptsRequest request)
    {
        return await _promptRepository.SearchAsync(request.Query, request.IncludeNegative, request.IncludeSystem);
    }
}
