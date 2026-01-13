using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Infrastructure.Services;
using Xunit;
using FluentAssertions;

namespace AIGenManager.Services.Tests;

public class ThumbnailGenerationServiceTests
{
    private readonly ThumbnailGenerationService _thumbnailService;

    public ThumbnailGenerationServiceTests()
    {
        _thumbnailService = new ThumbnailGenerationService();
    }

    [Fact]
    public async Task GenerateThumbnailAsync_ShouldCreateThumbnailFile()
    {
        // Arrange
        var testImagePath = CreateTestImage();
        
        try
        {
            // Act
            var thumbnailPath = await _thumbnailService.GenerateThumbnailAsync(testImagePath);
            
            // Assert
            thumbnailPath.Should().NotBeNullOrEmpty();
            File.Exists(thumbnailPath).Should().BeTrue();
            new FileInfo(thumbnailPath).Length.Should().BeGreaterThan(0);
        }
        finally
        {
            // Cleanup
            CleanupTestImage(testImagePath);
        }
    }

    [Fact]
    public async Task GenerateThumbnailAsync_ShouldReturnCachedThumbnail()
    {
        // Arrange
        var testImagePath = CreateTestImage();
        
        try
        {
            // Act
            var thumbnailPath1 = await _thumbnailService.GenerateThumbnailAsync(testImagePath);
            var thumbnailPath2 = await _thumbnailService.GenerateThumbnailAsync(testImagePath);
            
            // Assert
            thumbnailPath1.Should().Be(thumbnailPath2);
            File.Exists(thumbnailPath1).Should().BeTrue();
        }
        finally
        {
            // Cleanup
            CleanupTestImage(testImagePath);
        }
    }

    [Fact]
    public async Task GetOrGenerateThumbnailAsync_ShouldReturnExistingThumbnail()
    {
        // Arrange
        var testImagePath = CreateTestImage();
        
        try
        {
            // Act
            var thumbnailPath1 = await _thumbnailService.GetOrGenerateThumbnailAsync(testImagePath);
            var thumbnailPath2 = await _thumbnailService.GetOrGenerateThumbnailAsync(testImagePath);
            
            // Assert
            thumbnailPath1.Should().Be(thumbnailPath2);
            File.Exists(thumbnailPath1).Should().BeTrue();
        }
        finally
        {
            // Cleanup
            CleanupTestImage(testImagePath);
        }
    }

    [Fact]
    public async Task GetOrGenerateThumbnailAsync_ShouldReturnEmptyStringForNonExistentFile()
    {
        // Arrange
        var nonExistentPath = @"C:\nonexistent\image.png";
        
        // Act
        var thumbnailPath = await _thumbnailService.GetOrGenerateThumbnailAsync(nonExistentPath);
        
        // Assert
        thumbnailPath.Should().BeEmpty();
    }

    [Fact]
    public async Task ClearCacheAsync_ShouldRemoveAllThumbnails()
    {
        // Arrange
        var testImagePath = CreateTestImage();
        
        try
        {
            // Generate some thumbnails
            await _thumbnailService.GenerateThumbnailAsync(testImagePath);
            
            var cacheDirectory = _thumbnailService.GetCacheDirectory();
            var thumbnailCountBefore = Directory.GetFiles(cacheDirectory).Length;
            
            thumbnailCountBefore.Should().BeGreaterThan(0);
            
            // Act
            await _thumbnailService.ClearCacheAsync();
            
            // Assert
            var thumbnailCountAfter = Directory.GetFiles(cacheDirectory).Length;
            thumbnailCountAfter.Should().Be(0);
        }
        finally
        {
            // Cleanup
            CleanupTestImage(testImagePath);
        }
    }

    [Fact]
    public void GetCacheDirectory_ShouldReturnValidPath()
    {
        // Act
        var cacheDirectory = _thumbnailService.GetCacheDirectory();
        
        // Assert
        cacheDirectory.Should().NotBeNullOrEmpty();
        Directory.Exists(cacheDirectory).Should().BeTrue();
    }

    private string CreateTestImage()
    {
        var testDirectory = Path.Combine(Path.GetTempPath(), "ThumbnailTests");
        Directory.CreateDirectory(testDirectory);
        
        var testImagePath = Path.Combine(testDirectory, $"test_image_{Guid.NewGuid()}.png");
        
        using var bitmap = new System.Drawing.Bitmap(100, 100);
        using var graphics = System.Drawing.Graphics.FromImage(bitmap);
        graphics.Clear(System.Drawing.Color.Red);
        bitmap.Save(testImagePath, System.Drawing.Imaging.ImageFormat.Png);
        
        return testImagePath;
    }

    private void CleanupTestImage(string imagePath)
    {
        try
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
            
            var directory = Path.GetDirectoryName(imagePath);
            if (Directory.Exists(directory) && Directory.GetFiles(directory).Length == 0)
            {
                Directory.Delete(directory);
            }
        }
        catch
        {
            // Ignore cleanup errors
        }
    }
}
