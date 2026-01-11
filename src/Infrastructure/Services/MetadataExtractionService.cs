using AIGenManager.Core.Domain.Services;
using MetadataExtractor;
using MetadataExtractor.Formats;
using System.IO;

namespace AIGenManager.Infrastructure.Services;

public class MetadataExtractionService : IMetadataExtractionService
{
    private readonly string[] _supportedExtensions = new[] { ".png", ".jpg", ".jpeg", ".webp" };

    public async Task<MetadataExtractionResult> ExtractMetadataAsync(string imagePath)
    {
        var result = new MetadataExtractionResult();

        try
        {
            if (!File.Exists(imagePath))
            {
                result.Success = false;
                result.ErrorMessage = "File not found";
                result.RequiresManualEntry = true;
                return result;
            }

            var extension = Path.GetExtension(imagePath).ToLowerInvariant();
            if (!_supportedExtensions.Contains(extension))
            {
                result.Success = false;
                result.ErrorMessage = $"Unsupported file format: {extension}";
                result.RequiresManualEntry = true;
                return result;
            }

            using var imageStream = File.OpenRead(imagePath);
            var metadata = ImageMetadataReader.ReadMetadata(imageStream);

            if (metadata == null)
            {
                result.Success = false;
                result.ErrorMessage = "No metadata found in image";
                result.RequiresManualEntry = true;
                return result;
            }

            result.Success = true;
            result.Prompt = GetMetadataValue(metadata, "Prompt", "UserComment");
            result.NegativePrompt = GetMetadataValue(metadata, "Negative Prompt", "NegativePrompt");
            result.Steps = ParseIntMetadata(metadata, "Steps", "SampleSteps");
            result.Sampler = GetMetadataValue(metadata, "Sampler", "Sampler");
            result.CFGScale = ParseDecimalMetadata(metadata, "CFG Scale", "CFGScale");
            result.Seed = ParseLongMetadata(metadata, "Seed");
            result.Width = ParseIntMetadata(metadata, "Width", "ImageWidth");
            result.Height = ParseIntMetadata(metadata, "Height", "ImageHeight");
            result.ModelName = GetMetadataValue(metadata, "Model", "ModelName");
            result.ModelHash = GetMetadataValue(metadata, "Model Hash", "ModelHash");
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Metadata extraction failed: {ex.Message}";
            result.RequiresManualEntry = true;
        }

        return result;
    }

    private string? GetMetadataValue(ImageMetadata metadata, params string[] possibleKeys)
    {
        foreach (var key in possibleKeys)
        {
            if (metadata.Tags.ContainsKey(key))
            {
                return metadata.Tags[key]?.ToString();
            }
        }
        return null;
    }

    private int? ParseIntMetadata(ImageMetadata metadata, params string[] possibleKeys)
    {
        var value = GetMetadataValue(metadata, possibleKeys);
        if (int.TryParse(value, out var intValue))
        {
            return intValue;
        }
        return null;
    }

    private long? ParseLongMetadata(ImageMetadata metadata, params string[] possibleKeys)
    {
        var value = GetMetadataValue(metadata, possibleKeys);
        if (long.TryParse(value, out var longValue))
        {
            return longValue;
        }
        return null;
    }

    private decimal? ParseDecimalMetadata(ImageMetadata metadata, params string[] possibleKeys)
    {
        var value = GetMetadataValue(metadata, possibleKeys);
        if (decimal.TryParse(value, out var decimalValue))
        {
            return decimalValue;
        }
        return null;
    }
}