using System.IO;

namespace AIGenManager.Infrastructure.Services;

public class FileSystemService
{
    private readonly string[] _supportedExtensions = new[] { ".png", ".jpg", ".jpeg", ".webp" };

    public List<string> GetImageFiles(string folderPath, bool recursive = true)
    {
        var imageFiles = new List<string>();

        if (!Directory.Exists(folderPath))
        {
            return imageFiles;
        }

        var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        var files = Directory.GetFiles(folderPath, "*.*", searchOption);

        foreach (var file in files)
        {
            var extension = Path.GetExtension(file).ToLowerInvariant();
            if (_supportedExtensions.Contains(extension))
            {
                imageFiles.Add(file);
            }
        }

        return imageFiles;
    }

    public List<string> GetSubdirectories(string folderPath)
    {
        if (!Directory.Exists(folderPath))
        {
            return new List<string>();
        }

        return Directory.GetDirectories(folderPath).ToList();
    }

    public bool IsValidImageFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return false;
        }

        var extension = Path.GetExtension(filePath).ToLowerInvariant();
        return _supportedExtensions.Contains(extension);
    }

    public long GetFileSize(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return 0;
        }

        return new FileInfo(filePath).Length;
    }

    public string GetRelativePath(string fullPath, string basePath)
    {
        if (!fullPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
        {
            return fullPath;
        }

        return fullPath.Substring(basePath.Length).TrimStart(Path.DirectorySeparatorChar).TrimStart(Path.AltDirectorySeparatorChar);
    }
}