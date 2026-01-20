using SQLite;

namespace BerryAIGC.Database;

public class Snippet {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Text { get; set; }
}

