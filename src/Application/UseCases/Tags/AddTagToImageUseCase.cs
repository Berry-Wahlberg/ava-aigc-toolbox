using AIGenManager.Core.Application.Ports;

namespace AIGenManager.Application.UseCases.Tags;

public record AddTagToImageRequest(int ImageId, string TagName);

public class AddTagToImageUseCase : UseCase<AddTagToImageRequest, bool>
{
    private readonly ITagRepository _tagRepository;
    private readonly IImageTagRepository _imageTagRepository;

    public AddTagToImageUseCase(ITagRepository tagRepository, IImageTagRepository imageTagRepository)
    {
        _tagRepository = tagRepository;
        _imageTagRepository = imageTagRepository;
    }

    public override async Task<bool> ExecuteAsync(AddTagToImageRequest request)
    {
        // Get or create tag
        var tag = await _tagRepository.GetByNameAsync(request.TagName);
        if (tag == null)
        {
            tag = new Core.Domain.Entities.Tag(request.TagName);
            tag = await _tagRepository.AddAsync(tag);
        }

        // Check if association already exists
        if (await _imageTagRepository.ExistsAsync(request.ImageId, tag.Id))
        {
            return false; // Already exists
        }

        // Add association
        await _imageTagRepository.AddAsync(request.ImageId, tag.Id);
        return true;
    }
}
