namespace AIGenManager.Core.Domain.Entities;

public class Prompt
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public string? NegativeContent { get; set; }
    public int UsageCount { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public DateTime? LastUsedDate { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public bool IsFavorite { get; set; }
    public bool IsSystem { get; set; }
    
    public Prompt()
    {
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
        UsageCount = 0;
        IsSystem = false;
        IsFavorite = false;
    }
    
    public Prompt(string name, string content) : this()
    {
        Name = name;
        Content = content;
    }
}
