using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Tags;

public class GetAllTagsUseCase : UseCase<IEnumerable<Tag>>
{
    private readonly ITagRepository _tagRepository;

    public GetAllTagsUseCase(ITagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public override async Task<IEnumerable<Tag>> ExecuteAsync()
    {
        return await _tagRepository.GetAllAsync();
    }
}
