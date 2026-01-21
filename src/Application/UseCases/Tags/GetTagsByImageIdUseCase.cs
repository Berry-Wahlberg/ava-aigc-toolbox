using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Tags;

public record GetTagsByImageIdRequest(int ImageId);

public class GetTagsByImageIdUseCase : UseCase<GetTagsByImageIdRequest, IEnumerable<Tag>>
{
    private readonly ITagRepository _tagRepository;

    public GetTagsByImageIdUseCase(ITagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public override async Task<IEnumerable<Tag>> ExecuteAsync(GetTagsByImageIdRequest request)
    {
        return await _tagRepository.GetTagsByImageIdAsync(request.ImageId);
    }
}
