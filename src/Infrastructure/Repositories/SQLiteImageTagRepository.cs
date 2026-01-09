using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;
using SQLite;

namespace AIGenManager.Infrastructure.Repositories;

public class SQLiteImageTagRepository : IImageTagRepository
{
    private readonly SQLiteConnection _connection;

    public SQLiteImageTagRepository(SQLiteConnection connection)
    {
        _connection = connection;
    }

    public Task AddAsync(int imageId, int tagId)
    {
        var sql = "INSERT INTO ImageTag (ImageId, TagId) VALUES (?, ?)";
        _connection.Execute(sql, imageId, tagId);
        return Task.CompletedTask;
    }

    public Task RemoveAsync(int imageId, int tagId)
    {
        var sql = "DELETE FROM ImageTag WHERE ImageId = ? AND TagId = ?";
        _connection.Execute(sql, imageId, tagId);
        return Task.CompletedTask;
    }

    public Task RemoveAllByImageIdAsync(int imageId)
    {
        var sql = "DELETE FROM ImageTag WHERE ImageId = ?";
        _connection.Execute(sql, imageId);
        return Task.CompletedTask;
    }

    public Task RemoveAllByTagIdAsync(int tagId)
    {
        var sql = "DELETE FROM ImageTag WHERE TagId = ?";
        _connection.Execute(sql, tagId);
        return Task.CompletedTask;
    }

    public Task<IEnumerable<int>> GetImageIdsByTagIdAsync(int tagId)
    {
        var sql = "SELECT ImageId FROM ImageTag WHERE TagId = ?";
        var imageIds = _connection.Query<int>(sql, tagId);
        return Task.FromResult<IEnumerable<int>>(imageIds);
    }

    public Task<IEnumerable<int>> GetTagIdsByImageIdAsync(int imageId)
    {
        var sql = "SELECT TagId FROM ImageTag WHERE ImageId = ?";
        var tagIds = _connection.Query<int>(sql, imageId);
        return Task.FromResult<IEnumerable<int>>(tagIds);
    }

    public Task<bool> ExistsAsync(int imageId, int tagId)
    {
        var sql = "SELECT COUNT(*) FROM ImageTag WHERE ImageId = ? AND TagId = ?";
        var count = _connection.ExecuteScalar<int>(sql, imageId, tagId);
        return Task.FromResult(count > 0);
    }
}
