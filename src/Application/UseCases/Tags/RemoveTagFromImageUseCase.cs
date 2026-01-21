using AIGenManager.Core.Application.Ports;

namespace AIGenManager.Application.UseCases.Tags;

public record RemoveTagFromImageRequest(int ImageId, string TagName);

public class RemoveTagFromImageUseCase : UseCase<RemoveTagFromImageRequest, bool>
{
    private readonly ITagRepository _tagRepository;
    private readonly IImageTagRepository _imageTagRepository;

    public RemoveTagFromImageUseCase(ITagRepository tagRepository, IImageTagRepository imageTagRepository)
    {
        _tagRepository = tagRepository;
        _imageTagRepository = imageTagRepository;
    }

    public override async Task<bool> ExecuteAsync(RemoveTagFromImageRequest request)
    {
        // Get tag
        var tag = await _tagRepository.GetByNameAsync(request.TagName);
        if (tag == null)
        {
            return false; // Tag doesn't exist
        }

        // Check if association exists
        if (!await _imageTagRepository.ExistsAsync(request.ImageId, tag.Id))
        {
            return false; // Association doesn't exist
        }

        // Remove association
        await _imageTagRepository.RemoveAsync(request.ImageId, tag.Id);
        return true;
    }
}
