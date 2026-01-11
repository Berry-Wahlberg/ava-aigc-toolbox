using System;
using System.IO;
using Xunit;
using AIGenManager.Infrastructure.Services;

namespace AIGenManager.Infrastructure.Tests;

public class FileSystemServiceTests
{
    private readonly FileSystemService _fileSystemService;

    public FileSystemServiceTests()
    {
        _fileSystemService = new FileSystemService();
    }

    [Fact]
    public void GetImageFiles_ShouldReturnEmptyForNonExistentFolder()
    {
        // Arrange
        var nonExistentPath = @"C:\NonExistentFolder\12345";

        // Act
        var result = _fileSystemService.GetImageFiles(nonExistentPath, false);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void GetImageFiles_ShouldReturnOnlySupportedFormats()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImages_" + Guid.NewGuid());
        Directory.CreateDirectory(tempFolder);

        try
        {
            // Create test files with different extensions
            File.WriteAllText(Path.Combine(tempFolder, "image1.png"), "fake png");
            File.WriteAllText(Path.Combine(tempFolder, "image2.jpg"), "fake jpg");
            File.WriteAllText(Path.Combine(tempFolder, "image3.jpeg"), "fake jpeg");
            File.WriteAllText(Path.Combine(tempFolder, "image4.webp"), "fake webp");
            File.WriteAllText(Path.Combine(tempFolder, "image5.txt"), "not an image");
            File.WriteAllText(Path.Combine(tempFolder, "image6.bmp"), "not supported");

            // Act
            var result = _fileSystemService.GetImageFiles(tempFolder, false);

            // Assert
            Assert.Equal(4, result.Count);
            Assert.All(result, f => f.EndsWith(".png") || f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".webp"));
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public void GetImageFiles_ShouldIncludeSubfoldersWhenRecursive()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImages_" + Guid.NewGuid());
        var subFolder = Path.Combine(tempFolder, "Subfolder");
        Directory.CreateDirectory(tempFolder);
        Directory.CreateDirectory(subFolder);

        try
        {
            // Create test files
            File.WriteAllText(Path.Combine(tempFolder, "root.png"), "root image");
            File.WriteAllText(Path.Combine(subFolder, "sub.png"), "sub image");

            // Act
            var result = _fileSystemService.GetImageFiles(tempFolder, true);

            // Assert
            Assert.Equal(2, result.Count);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public void GetImageFiles_ShouldNotIncludeSubfoldersWhenNotRecursive()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImages_" + Guid.NewGuid());
        var subFolder = Path.Combine(tempFolder, "Subfolder");
        Directory.CreateDirectory(tempFolder);
        Directory.CreateDirectory(subFolder);

        try
        {
            // Create test files
            File.WriteAllText(Path.Combine(tempFolder, "root.png"), "root image");
            File.WriteAllText(Path.Combine(subFolder, "sub.png"), "sub image");

            // Act
            var result = _fileSystemService.GetImageFiles(tempFolder, false);

            // Assert
            Assert.Single(result);
            Assert.EndsWith("root.png", result[0]);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public void IsValidImageFile_ShouldReturnFalseForNonExistentFile()
    {
        // Arrange
        var nonExistentFile = @"C:\NonExistent\file.png";

        // Act
        var result = _fileSystemService.IsValidImageFile(nonExistentFile);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidImageFile_ShouldReturnFalseForUnsupportedFormat()
    {
        // Arrange
        var tempFile = Path.GetTempFileName() + ".bmp";
        File.WriteAllText(tempFile, "fake bmp");

        try
        {
            // Act
            var result = _fileSystemService.IsValidImageFile(tempFile);

            // Assert
            Assert.False(result);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Fact]
    public void IsValidImageFile_ShouldReturnTrueForSupportedFormat()
    {
        // Arrange
        var tempFile = Path.GetTempFileName() + ".png";
        File.WriteAllText(tempFile, "fake png");

        try
        {
            // Act
            var result = _fileSystemService.IsValidImageFile(tempFile);

            // Assert
            Assert.True(result);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Fact]
    public void GetFileSize_ShouldReturnZeroForNonExistentFile()
    {
        // Arrange
        var nonExistentFile = @"C:\NonExistent\file.png";

        // Act
        var result = _fileSystemService.GetFileSize(nonExistentFile);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void GetFileSize_ShouldReturnCorrectSize()
    {
        // Arrange
        var tempFile = Path.GetTempFileName() + ".png";
        var content = "test content for file size";
        File.WriteAllText(tempFile, content);

        try
        {
            // Act
            var result = _fileSystemService.GetFileSize(tempFile);

            // Assert
            Assert.Equal(content.Length, result);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Fact]
    public void GetRelativePath_ShouldReturnRelativePath()
    {
        // Arrange
        var basePath = @"C:\Images";
        var fullPath = @"C:\Images\Subfolder\image.png";

        // Act
        var result = _fileSystemService.GetRelativePath(fullPath, basePath);

        // Assert
        Assert.Equal(@"Subfolder\image.png", result);
    }

    [Fact]
    public void GetRelativePath_ShouldReturnFullPathWhenNotInBasePath()
    {
        // Arrange
        var basePath = @"C:\Images";
        var fullPath = @"D:\Other\image.png";

        // Act
        var result = _fileSystemService.GetRelativePath(fullPath, basePath);

        // Assert
        Assert.Equal(fullPath, result);
    }
}