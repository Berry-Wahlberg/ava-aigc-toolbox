using AIGenManager.Core.Domain.Services;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace AIGenManager.Infrastructure.Services;

public class MetadataExtractionService : IMetadataExtractionService
{
    private readonly string[] _supportedExtensions = new[] { ".png", ".jpg", ".jpeg", ".webp" };

    public Task<MetadataExtractionResult> ExtractMetadataAsync(string imagePath)
    {
        var result = new MetadataExtractionResult();

        try
        {
            if (!File.Exists(imagePath))
            {
                result.Success = false;
                result.ErrorMessage = "File not found";
                result.RequiresManualEntry = true;
                return Task.FromResult(result);
            }

            var extension = Path.GetExtension(imagePath).ToLowerInvariant();
            if (!_supportedExtensions.Contains(extension))
            {
                result.Success = false;
                result.ErrorMessage = $"Unsupported file format: {extension}";
                result.RequiresManualEntry = true;
                return Task.FromResult(result);
            }

            using var image = Image.FromFile(imagePath);
            var propertyItems = image.PropertyItems;

            if (propertyItems == null || propertyItems.Length == 0)
            {
                result.Success = false;
                result.ErrorMessage = "No metadata found in image";
                result.RequiresManualEntry = true;
                return Task.FromResult(result);
            }

            result.Success = true;
            result.Prompt = GetPropertyText(propertyItems, 0x010F);
            result.NegativePrompt = GetPropertyText(propertyItems, 0x9286);
            result.Steps = ParseIntMetadata(GetPropertyText(propertyItems, 0x927C));
            result.Sampler = GetPropertyText(propertyItems, 0x927D);
            result.CFGScale = ParseDecimalMetadata(GetPropertyText(propertyItems, 0x927E));
            result.Seed = ParseLongMetadata(GetPropertyText(propertyItems, 0x927B));
            result.Width = image.Width;
            result.Height = image.Height;
            result.ModelName = GetPropertyText(propertyItems, 0x0110);
            result.ModelHash = GetPropertyText(propertyItems, 0x0131);
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Metadata extraction failed: {ex.Message}";
            result.RequiresManualEntry = true;
        }

        return Task.FromResult(result);
    }

    private string? GetPropertyText(PropertyItem[] propertyItems, int propertyId)
    {
        foreach (var item in propertyItems)
        {
            if (item.Id == propertyId)
            {
                return Encoding.UTF8.GetString(item.Value);
            }
        }
        return null;
    }

    private int? ParseIntMetadata(string? value)
    {
        if (int.TryParse(value, out var intValue))
        {
            return intValue;
        }
        return null;
    }

    private long? ParseLongMetadata(string? value)
    {
        if (long.TryParse(value, out var longValue))
        {
            return longValue;
        }
        return null;
    }

    private decimal? ParseDecimalMetadata(string? value)
    {
        if (decimal.TryParse(value, out var decimalValue))
        {
            return decimalValue;
        }
        return null;
    }
}