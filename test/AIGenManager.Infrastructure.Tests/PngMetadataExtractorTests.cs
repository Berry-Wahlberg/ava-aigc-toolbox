using System;
using System.IO;
using System.Text;
using Xunit;
using AIGenManager.Infrastructure.Services;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Infrastructure.Tests;

public class PngMetadataExtractorTests
{
    private readonly PngMetadataExtractor _extractor;

    public PngMetadataExtractorTests()
    {
        _extractor = new PngMetadataExtractor();
    }

    [Fact]
    public void ExtractPngMetadata_ShouldReturnFalseForNonPngFile()
    {
        // Arrange
        var tempFile = Path.GetTempFileName() + ".txt";
        File.WriteAllText(tempFile, "This is not a PNG file");
        var image = new Image(tempFile, "test.txt");

        try
        {
            // Act
            var result = _extractor.ExtractPngMetadata(tempFile, image);

            // Assert
            Assert.False(result);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Fact]
    public void ExtractPngMetadata_ShouldReturnFalseForInvalidPng()
    {
        // Arrange
        var tempFile = Path.GetTempFileName() + ".png";
        File.WriteAllBytes(tempFile, Encoding.ASCII.GetBytes("INVALID PNG DATA"));
        var image = new Image(tempFile, "invalid.png");

        try
        {
            // Act
            var result = _extractor.ExtractPngMetadata(tempFile, image);

            // Assert
            Assert.False(result);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Fact]
    public void ProcessTextChunk_ShouldExtractMetadataFromAutomatic1111Format()
    {
        // Arrange
        var image = new Image("test.png", "test.png");
        var parameters = "parameters:test prompt\nNegative prompt:negative test\nSteps:20\nSampler:Euler a\nCFG scale:7\nSeed:12345\nSize:512x512\nModel:SDXL 1.0";
        var chunkData = "parameters\0" + parameters; // PNG text chunk format: keyword + null byte + value

        // Act
        // We need to test the private method, so we'll create a minimal valid PNG file with the parameters
        var tempFile = CreateTestPngFile(parameters);
        try
        {
            var result = _extractor.ExtractPngMetadata(tempFile, image);

            // Assert
            Assert.True(result);
            Assert.Equal("test prompt", image.Prompt);
            Assert.Equal("negative test", image.NegativePrompt);
            Assert.Equal(20, image.Steps);
            Assert.Equal("Euler a", image.Sampler);
            Assert.Equal(7.0m, image.CFGScale);
            Assert.Equal(12345, image.Seed);
            Assert.Equal(512, image.Width);
            Assert.Equal(512, image.Height);
            Assert.Equal("SDXL 1.0", image.Model);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    [Fact]
    public void ExtractPngMetadata_ShouldHandleJsonMetadata()
    {
        // Arrange
        var image = new Image("test.png", "test.png");
        var jsonMetadata = "{\"prompt\":\"json test prompt\",\"negative_prompt\":\"json negative\",\"model\":\"JSON Model\",\"sampler\":\"DDIM\",\"steps\":25,\"cfg_scale\":7.5,\"seed\":67890,\"width\":768,\"height\":512}";
        var chunkData = "parameters\0" + jsonMetadata;

        // Act
        var tempFile = CreateTestPngFile(jsonMetadata);
        try
        {
            var result = _extractor.ExtractPngMetadata(tempFile, image);

            // Assert
            Assert.True(result);
            Assert.Equal("json test prompt", image.Prompt);
            Assert.Equal("json negative", image.NegativePrompt);
            Assert.Equal("JSON Model", image.Model);
            Assert.Equal("DDIM", image.Sampler);
            Assert.Equal(25, image.Steps);
            Assert.Equal(7.5m, image.CFGScale);
            Assert.Equal(67890, image.Seed);
            Assert.Equal(768, image.Width);
            Assert.Equal(512, image.Height);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    /// <summary>
    /// Creates a minimal valid PNG file with the given parameters in a text chunk
    /// </summary>
    private string CreateTestPngFile(string parameters)
    {
        var tempFile = Path.GetTempFileName() + ".png";
        
        using var stream = new FileStream(tempFile, FileMode.Create);
        using var writer = new BinaryWriter(stream);
        
        // PNG signature
        writer.Write(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 });
        
        // IHDR chunk (minimal valid header)
        WritePngChunk(writer, "IHDR", new byte[] { 0, 0, 0, 1, 0, 0, 0, 1, 8, 0, 0, 0, 0 });
        
        // Text chunk with parameters
        var textData = Encoding.ASCII.GetBytes("parameters\0" + parameters);
        WritePngChunk(writer, "tEXt", textData);
        
        // IEND chunk
        WritePngChunk(writer, "IEND", Array.Empty<byte>());
        
        return tempFile;
    }
    
    /// <summary>
    /// Writes a PNG chunk to the stream
    /// </summary>
    private void WritePngChunk(BinaryWriter writer, string chunkType, byte[] data)
    {
        // Length
        writer.Write((uint)data.Length);
        
        // Chunk type
        writer.Write(Encoding.ASCII.GetBytes(chunkType));
        
        // Chunk data
        writer.Write(data);
        
        // CRC (dummy value for testing)
        writer.Write((uint)0);
    }
}