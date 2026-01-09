using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Albums;

public record GetAlbumByIdRequest(int AlbumId);

public class GetAlbumByIdUseCase : UseCase<GetAlbumByIdRequest, Album?>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumByIdUseCase(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public override async Task<Album?> ExecuteAsync(GetAlbumByIdRequest request)
    {
        return await _albumRepository.GetByIdAsync(request.AlbumId);
    }
}
