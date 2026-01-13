using AIGenManager.Core.Domain.Services;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace AIGenManager.Infrastructure.Services;

public class MetadataExtractionService : IMetadataExtractionService
{
    private readonly string[] _supportedExtensions = new[] { ".png", ".jpg", ".jpeg", ".webp", ".txt", ".mp4" };
    private const string PNG_SIGNATURE = "\x89PNG\r\n\x1a\n";
    private const string IEND_CHUNK = "IEND";
    private const string TEXT_CHUNK = "tEXt";
    private const string ZTXT_CHUNK = "zTXt";
    private const string ITXT_CHUNK = "iTXt";

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

            switch (extension)
            {
                case ".png":
                    ExtractPngMetadata(imagePath, result);
                    break;
                case ".jpg":
                case ".jpeg":
                    ExtractJpegMetadata(imagePath, result);
                    break;
                case ".webp":
                    ExtractWebpMetadata(imagePath, result);
                    break;
                case ".txt":
                    ExtractTextMetadata(imagePath, result);
                    break;
                case ".mp4":
                    ExtractMp4Metadata(imagePath, result);
                    break;
            }

            // If no metadata was extracted, mark as requiring manual entry
            if (!result.Success && string.IsNullOrEmpty(result.ErrorMessage))
            {
                result.RequiresManualEntry = true;
            }
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Metadata extraction failed: {ex.Message}";
            result.RequiresManualEntry = true;
        }

        return Task.FromResult(result);
    }

    private void ExtractPngMetadata(string imagePath, MetadataExtractionResult result)
    {
        using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        using var reader = new BinaryReader(stream);
        
        // Verify PNG signature
        var signatureBytes = reader.ReadBytes(8);
        if (signatureBytes.Length < 8)
        {
            result.Success = false;
            result.ErrorMessage = "Invalid PNG signature";
            return;
        }
        
        var signature = Encoding.ASCII.GetString(signatureBytes);
        if (signature != PNG_SIGNATURE)
        {
            result.Success = false;
            result.ErrorMessage = "Invalid PNG file";
            return;
        }
        
        // Read all chunks until IEND
        while (stream.Position < stream.Length - 8) // Need at least 8 bytes for chunk header + IEND
        {
            // Read chunk header
            if (stream.Position + 8 > stream.Length)
                break;
            
            var length = reader.ReadInt32();
            var chunkTypeBytes = reader.ReadBytes(4);
            
            if (chunkTypeBytes.Length != 4)
                break;
            
            var chunkType = Encoding.ASCII.GetString(chunkTypeBytes);
            
            // Check for IEND chunk
            if (chunkType == IEND_CHUNK)
            {
                break;
            }
            
            // Validate chunk length
            if (length < 0 || stream.Position + length + 4 > stream.Length)
            {
                break;
            }
            
            // Read chunk data
            var data = reader.ReadBytes(length);
            
            // Skip CRC
            reader.ReadBytes(4);
            
            // Process text chunks
            if (chunkType == TEXT_CHUNK || chunkType == ZTXT_CHUNK || chunkType == ITXT_CHUNK)
            {
                var chunkData = Encoding.ASCII.GetString(data);
                ProcessPngTextChunk(chunkData, result);
            }
        }
        
        if (string.IsNullOrEmpty(result.Prompt) && string.IsNullOrEmpty(result.Model))
        {
            result.Success = false;
            result.ErrorMessage = "No metadata found in PNG file";
        }
        else
        {
            result.Success = true;
        }
    }

    private void ProcessPngTextChunk(string chunkData, MetadataExtractionResult result)
    {
        // PNG text chunks have keyword-value format separated by null byte
        int nullIndex = chunkData.IndexOf('\0');
        if (nullIndex < 0)
            return;

        string keyword = chunkData.Substring(0, nullIndex).Trim();
        string value = chunkData.Substring(nullIndex + 1).Trim();

        // Check for various metadata formats based on keyword
        switch (keyword.ToLower())
        {
            case "parameters":
            case "comment":
                ExtractAutomatic1111Metadata(value, result);
                break;
            case "invokeai_metadata":
            case "dream":
            case "sd-metadata":
                ExtractInvokeAIMetadata(value, result);
                break;
            case "novelai_metadata":
            case "novelai":
                ExtractNovelAIMetadata(value, result);
                break;
            case "dream_metadata":
                ExtractDreamMetadata(value, result);
                break;
            case "fooocus_metadata":
            case "ruinedfooocus_metadata":
                ExtractFooocusMetadata(value, result);
                break;
            case "stableswarm_metadata":
                ExtractStableSwarmMetadata(value, result);
                break;
        }

        // If no metadata was extracted from known keywords, check the value content
        if (string.IsNullOrEmpty(result.Prompt) && !string.IsNullOrEmpty(value))
        {
            if (value.Contains("parameters"))
            {
                ExtractAutomatic1111Metadata(value, result);
            }
            else if (value.Contains("invokeai_metadata"))
            {
                ExtractInvokeAIMetadata(value, result);
            }
        }
    }

    private void ExtractAutomatic1111Metadata(string chunkData, MetadataExtractionResult result)
    {
        // Pattern to match AUTOMATIC1111 metadata format
        var parameterMatch = Regex.Match(chunkData, @"parameters:([\s\S]*?)(\Z|\r\n\r\n)");
        if (parameterMatch.Success)
        {
            var parameters = parameterMatch.Groups[1].Value.Trim();
            ProcessAutomatic1111Parameters(parameters, result);
        }
        else
        {
            // Try without parameters prefix
            ProcessAutomatic1111Parameters(chunkData, result);
        }
    }

    private void ProcessAutomatic1111Parameters(string parameters, MetadataExtractionResult result)
    {
        // Extract prompt
        var promptMatch = Regex.Match(parameters, @"^(.*?)(?:Negative prompt:|Steps:|\Z)");
        if (promptMatch.Success)
        {
            result.Prompt = promptMatch.Groups[1].Value.Trim();
        }
        
        // Extract negative prompt
        var negativePromptMatch = Regex.Match(parameters, @"Negative prompt: (.*?)(?:Steps:|\Z)");
        if (negativePromptMatch.Success)
        {
            result.NegativePrompt = negativePromptMatch.Groups[1].Value.Trim();
        }
        
        // Extract steps
        var stepsMatch = Regex.Match(parameters, @"Steps: (\d+)");
        if (stepsMatch.Success)
        {
            result.Steps = int.Parse(stepsMatch.Groups[1].Value);
        }
        
        // Extract sampler
        var samplerMatch = Regex.Match(parameters, @"Sampler: ([^,]+)");
        if (samplerMatch.Success)
        {
            result.Sampler = samplerMatch.Groups[1].Value.Trim();
        }
        
        // Extract CFG scale
        var cfgMatch = Regex.Match(parameters, @"CFG scale: ([\d.]+)");
        if (cfgMatch.Success)
        {
            result.CFGScale = decimal.Parse(cfgMatch.Groups[1].Value);
        }
        
        // Extract seed
        var seedMatch = Regex.Match(parameters, @"Seed: (\d+)");
        if (seedMatch.Success)
        {
            result.Seed = long.Parse(seedMatch.Groups[1].Value);
        }
        
        // Extract size
        var sizeMatch = Regex.Match(parameters, @"Size: (\d+)x(\d+)");
        if (sizeMatch.Success)
        {
            result.Width = int.Parse(sizeMatch.Groups[1].Value);
            result.Height = int.Parse(sizeMatch.Groups[2].Value);
        }
        
        // Extract model
        var modelMatch = Regex.Match(parameters, @"Model: ([^,\n]+)");
        if (modelMatch.Success)
        {
            result.Model = modelMatch.Groups[1].Value.Trim();
        }
    }

    private void ExtractJpegMetadata(string imagePath, MetadataExtractionResult result)
    {
        try
        {
            using var image = Image.FromFile(imagePath);
            var propertyItems = image.PropertyItems;

            result.Width = image.Width;
            result.Height = image.Height;

            if (propertyItems == null || propertyItems.Length == 0)
            {
                result.Success = false;
                result.ErrorMessage = "No metadata found in JPEG file";
                return;
            }

            // Try to extract EXIF metadata
            foreach (var prop in propertyItems)
            {
                if (prop.Id == 0x010F) // Make
                {
                    result.Model = Encoding.UTF8.GetString(prop.Value).Trim();
                }
                else if (prop.Id == 0x0110) // Model
                {
                    result.Model = Encoding.UTF8.GetString(prop.Value).Trim();
                }
                else if (prop.Id == 0x0131) // Software
                {
                    result.Model = Encoding.UTF8.GetString(prop.Value).Trim();
                }
            }

            result.Success = true;
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Error extracting JPEG metadata: {ex.Message}";
        }
    }

    private void ExtractWebpMetadata(string imagePath, MetadataExtractionResult result)
    {
        try
        {
            using var image = Image.FromFile(imagePath);
            result.Width = image.Width;
            result.Height = image.Height;
            result.Success = true;
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Error extracting WebP metadata: {ex.Message}";
        }
    }

    private void ExtractTextMetadata(string imagePath, MetadataExtractionResult result)
    {
        try
        {
            var content = File.ReadAllText(imagePath);
            
            // Try to parse as JSON first
            if (TryParseJsonMetadata(content, result))
            {
                result.Success = true;
                return;
            }
            
            // Try to parse as AUTOMATIC1111 format
            ExtractAutomatic1111Metadata(content, result);
            if (!string.IsNullOrEmpty(result.Prompt) || !string.IsNullOrEmpty(result.Model))
            {
                result.Success = true;
                return;
            }
            
            result.Success = false;
            result.ErrorMessage = "No recognized metadata found in text file";
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Error extracting text metadata: {ex.Message}";
        }
    }

    private void ExtractMp4Metadata(string imagePath, MetadataExtractionResult result)
    {
        try
        {
            result.Width = 0;
            result.Height = 0;
            result.Success = true;
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Error extracting MP4 metadata: {ex.Message}";
        }
    }

    private void ExtractInvokeAIMetadata(string chunkData, MetadataExtractionResult result)
    {
        if (TryParseJsonMetadata(chunkData, result))
        {
            if (string.IsNullOrEmpty(result.Model))
                result.Model = "InvokeAI";
        }
    }

    private void ExtractNovelAIMetadata(string chunkData, MetadataExtractionResult result)
    {
        if (TryParseJsonMetadata(chunkData, result))
        {
            if (string.IsNullOrEmpty(result.Model))
                result.Model = "NovelAI";
        }
    }

    private void ExtractDreamMetadata(string chunkData, MetadataExtractionResult result)
    {
        if (TryParseJsonMetadata(chunkData, result))
        {
            if (string.IsNullOrEmpty(result.Model))
                result.Model = "Dream";
        }
    }

    private void ExtractFooocusMetadata(string chunkData, MetadataExtractionResult result)
    {
        if (TryParseJsonMetadata(chunkData, result))
        {
            if (string.IsNullOrEmpty(result.Model))
                result.Model = "Fooocus";
        }
    }

    private void ExtractStableSwarmMetadata(string chunkData, MetadataExtractionResult result)
    {
        if (TryParseJsonMetadata(chunkData, result))
        {
            if (string.IsNullOrEmpty(result.Model))
                result.Model = "Stable Swarm";
        }
    }

    private bool TryParseJsonMetadata(string jsonData, MetadataExtractionResult result)
    {
        try
        {
            var jsonDoc = JsonDocument.Parse(jsonData);
            var root = jsonDoc.RootElement;
            ExtractFromJson(root, result);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    private void ExtractFromJson(JsonElement element, MetadataExtractionResult result)
    {
        // Try to extract common fields
        if (element.TryGetProperty("prompt", out var promptElement))
            result.Prompt = promptElement.GetString();
        
        if (element.TryGetProperty("negative_prompt", out var negPromptElement))
            result.NegativePrompt = negPromptElement.GetString();
        if (element.TryGetProperty("negative", out var negElement))
            result.NegativePrompt = negElement.GetString();
        
        if (element.TryGetProperty("model", out var modelElement))
            result.Model = modelElement.GetString();
        if (element.TryGetProperty("model_name", out var modelNameElement))
            result.Model = modelNameElement.GetString();
        
        if (element.TryGetProperty("sampler", out var samplerElement))
            result.Sampler = samplerElement.GetString();
        if (element.TryGetProperty("sampler_name", out var samplerNameElement))
            result.Sampler = samplerNameElement.GetString();
        
        if (element.TryGetProperty("steps", out var stepsElement))
            result.Steps = stepsElement.GetInt32();
        
        if (element.TryGetProperty("cfg_scale", out var cfgElement))
            result.CFGScale = decimal.Parse(cfgElement.GetDouble().ToString());
        if (element.TryGetProperty("cfg", out var cfgScaleElement))
            result.CFGScale = decimal.Parse(cfgScaleElement.GetDouble().ToString());
        
        if (element.TryGetProperty("seed", out var seedElement))
        {
            long seedValue = 0;
            if (seedElement.ValueKind == JsonValueKind.String)
                long.TryParse(seedElement.GetString(), out seedValue);
            else
                seedValue = seedElement.GetInt64();
            
            result.Seed = seedValue;
        }
        
        if (element.TryGetProperty("width", out var widthElement))
            result.Width = widthElement.GetInt32();
        if (element.TryGetProperty("height", out var heightElement))
            result.Height = heightElement.GetInt32();
        
        // Recursively check nested objects
        if (element.TryGetProperty("metadata", out var metadataElement))
            ExtractFromJson(metadataElement, result);
        if (element.TryGetProperty("generation_metadata", out var genMetadataElement))
            ExtractFromJson(genMetadataElement, result);
        if (element.TryGetProperty("image_metadata", out var imgMetadataElement))
            ExtractFromJson(imgMetadataElement, result);
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
}