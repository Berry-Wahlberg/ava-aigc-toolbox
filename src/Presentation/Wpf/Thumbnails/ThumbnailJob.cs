using BerryAIGC.Common;
using BerryAIGC.Toolkit.Common;
using BerryAIGC.Toolkit.Models;

namespace BerryAIGC.Toolkit.Thumbnails;

public class ThumbnailJob
{
    public long BatchId { get; set; }
    public EntryType EntryType { get; set; }
    public string Path { get; set; }
    public ImageType Type { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public bool Rebuild { get; set; }
}






