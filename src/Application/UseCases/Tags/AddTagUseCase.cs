using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Tags;

public record AddTagRequest(string Name);

public class AddTagUseCase : UseCase<AddTagRequest, Tag>
{
    private readonly ITagRepository _tagRepository;

    public AddTagUseCase(ITagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public override async Task<Tag> ExecuteAsync(AddTagRequest request)
    {
        // Check if tag already exists
        var existingTag = await _tagRepository.GetByNameAsync(request.Name);
        if (existingTag != null)
        {
            return existingTag;
        }

        // Create new tag
        var tag = new Tag(request.Name);
        return await _tagRepository.AddAsync(tag);
    }
}
