using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Albums;

public record GetImagesByAlbumIdRequest(int AlbumId);

public class GetImagesByAlbumIdUseCase : UseCase<GetImagesByAlbumIdRequest, IEnumerable<Image>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetImagesByAlbumIdUseCase(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public override async Task<IEnumerable<Image>> ExecuteAsync(GetImagesByAlbumIdRequest request)
    {
        return await _albumRepository.GetImagesByAlbumIdAsync(request.AlbumId);
    }
}
