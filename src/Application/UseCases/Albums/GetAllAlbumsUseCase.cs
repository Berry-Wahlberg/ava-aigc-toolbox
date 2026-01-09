using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Albums;

public class GetAllAlbumsUseCase : UseCase<IEnumerable<Album>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAllAlbumsUseCase(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public override async Task<IEnumerable<Album>> ExecuteAsync()
    {
        return await _albumRepository.GetAllAsync();
    }
}
