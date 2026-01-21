using AIGenManager.Core.Application.Ports;

namespace AIGenManager.Application.UseCases.Albums;

public record AddImageToAlbumRequest(int AlbumId, int ImageId);

public class AddImageToAlbumUseCase : UseCase<AddImageToAlbumRequest, bool>
{
    private readonly IAlbumRepository _albumRepository;

    public AddImageToAlbumUseCase(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public override async Task<bool> ExecuteAsync(AddImageToAlbumRequest request)
    {
        // Check if image is already in album
        if (await _albumRepository.IsImageInAlbumAsync(request.AlbumId, request.ImageId))
        {
            return false; // Already exists
        }

        // Add image to album
        await _albumRepository.AddImageToAlbumAsync(request.AlbumId, request.ImageId);
        return true;
    }
}
