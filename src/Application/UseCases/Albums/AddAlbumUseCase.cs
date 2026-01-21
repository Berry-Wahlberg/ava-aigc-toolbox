using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Application.UseCases.Albums;

public record AddAlbumRequest(string Name);

public class AddAlbumUseCase : UseCase<AddAlbumRequest, Album>
{
    private readonly IAlbumRepository _albumRepository;

    public AddAlbumUseCase(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public override async Task<Album> ExecuteAsync(AddAlbumRequest request)
    {
        var album = new Album(request.Name);
        return await _albumRepository.AddAsync(album);
    }
}
