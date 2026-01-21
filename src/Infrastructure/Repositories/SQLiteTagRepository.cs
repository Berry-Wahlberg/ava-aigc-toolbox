using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;
using SQLite;

namespace AIGenManager.Infrastructure.Repositories;

public class SQLiteTagRepository : ITagRepository
{
    private readonly SQLiteConnection _connection;

    public SQLiteTagRepository(SQLiteConnection connection)
    {
        _connection = connection;
    }

    public Task<IEnumerable<Tag>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Tag>>(_connection.Table<Tag>().ToList());
    }

    public Task<Tag?> GetByIdAsync(int id)
    {
        return Task.FromResult(_connection.Table<Tag>().Where(t => t.Id == id).FirstOrDefault());
    }

    public Task<Tag?> GetByNameAsync(string name)
    {
        return Task.FromResult(_connection.Table<Tag>().Where(t => t.Name == name).FirstOrDefault());
    }

    public Task<Tag> AddAsync(Tag tag)
    {
        _connection.Insert(tag);
        return Task.FromResult(tag);
    }

    public Task<Tag> UpdateAsync(Tag tag)
    {
        _connection.Update(tag);
        return Task.FromResult(tag);
    }

    public Task DeleteAsync(int id)
    {
        _connection.Delete<Tag>(id);
        return Task.CompletedTask;
    }

    public Task<IEnumerable<Tag>> GetTagsByImageIdAsync(int imageId)
    {
        var sql = @"
            SELECT t.*
            FROM Tag t
            INNER JOIN ImageTag it ON t.Id = it.TagId
            WHERE it.ImageId = ?
        ";
        var tags = _connection.Query<Tag>(sql, imageId);
        return Task.FromResult<IEnumerable<Tag>>(tags);
    }
}
