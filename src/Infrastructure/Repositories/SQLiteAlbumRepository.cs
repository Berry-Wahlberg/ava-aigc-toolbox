using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;
using SQLite;

namespace AIGenManager.Infrastructure.Repositories;

public class SQLiteAlbumRepository : IAlbumRepository
{
    private readonly SQLiteConnection _connection;

    public SQLiteAlbumRepository(SQLiteConnection connection)
    {
        _connection = connection;
    }

    public Task<IEnumerable<Album>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Album>>(_connection.Table<Album>().OrderBy(a => a.Order).ToList());
    }

    public Task<Album?> GetByIdAsync(int id)
    {
        return Task.FromResult(_connection.Table<Album>().Where(a => a.Id == id).FirstOrDefault());
    }

    public Task<Album> AddAsync(Album album)
    {
        _connection.Insert(album);
        return Task.FromResult(album);
    }

    public Task<Album> UpdateAsync(Album album)
    {
        _connection.Update(album);
        return Task.FromResult(album);
    }

    public Task DeleteAsync(int id)
    {
        // First delete all album-image relationships
        var sql = "DELETE FROM AlbumImage WHERE AlbumId = ?";
        _connection.Execute(sql, id);
        
        // Then delete the album
        _connection.Delete<Album>(id);
        return Task.CompletedTask;
    }

    public Task<IEnumerable<Image>> GetImagesByAlbumIdAsync(int albumId)
    {
        var sql = @"
            SELECT i.*
            FROM Image i
            INNER JOIN AlbumImage ai ON i.Id = ai.ImageId
            WHERE ai.AlbumId = ?
        ";
        var images = _connection.Query<Image>(sql, albumId);
        return Task.FromResult<IEnumerable<Image>>(images);
    }

    public Task AddImageToAlbumAsync(int albumId, int imageId)
    {
        var sql = "INSERT INTO AlbumImage (AlbumId, ImageId) VALUES (?, ?)";
        _connection.Execute(sql, albumId, imageId);
        return Task.CompletedTask;
    }

    public Task RemoveImageFromAlbumAsync(int albumId, int imageId)
    {
        var sql = "DELETE FROM AlbumImage WHERE AlbumId = ? AND ImageId = ?";
        _connection.Execute(sql, albumId, imageId);
        return Task.CompletedTask;
    }

    public Task<bool> IsImageInAlbumAsync(int albumId, int imageId)
    {
        var sql = "SELECT COUNT(*) FROM AlbumImage WHERE AlbumId = ? AND ImageId = ?";
        var count = _connection.ExecuteScalar<int>(sql, albumId, imageId);
        return Task.FromResult(count > 0);
    }
}
