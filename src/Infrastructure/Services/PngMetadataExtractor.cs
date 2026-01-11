using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using AIGenManager.Core.Domain.Entities;

namespace AIGenManager.Infrastructure.Services;

/// <summary>
/// Service for extracting PNG metadata from AI-generated images
/// </summary>
public class PngMetadataExtractor
{
    private const string IEND_CHUNK = "IEND";
    private const string TEXT_CHUNK = "tEXt";
    private const string ZTXT_CHUNK = "zTXt";
    private const string ITXT_CHUNK = "iTXt";
    private const string PNG_SIGNATURE = "\x89PNG\r\n\x1a\n";
    
    /// <summary>
    /// Extracts metadata from a PNG file and populates an Image entity
    /// </summary>
    /// <param name="filePath">Path to the PNG file</param>
    /// <param name="image">Image entity to populate with metadata</param>
    /// <returns>True if metadata was successfully extracted, false otherwise</returns>
    public bool ExtractPngMetadata(string filePath, Image image)
    {
        try
        {
            using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var reader = new BinaryReader(stream);
            
            // Verify PNG signature
            var signatureBytes = reader.ReadBytes(8);
            if (signatureBytes.Length < 8)
                return false;
            
            var signature = Encoding.ASCII.GetString(signatureBytes);
            if (signature != PNG_SIGNATURE)
            {
                return false;
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
                    ProcessTextChunk(chunkData, image);
                }
            }
            
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    /// <summary>
    /// Processes text chunks to extract metadata
    /// </summary>
    /// <param name="chunkData">Text chunk data</param>
    /// <param name="image">Image entity to populate</param>
    private void ProcessTextChunk(string chunkData, Image image)
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
                ExtractAutomatic1111Metadata(value, image);
                break;
            case "invokeai_metadata":
            case "dream":
            case "sd-metadata":
                ExtractInvokeAIMetadata(value, image);
                break;
            case "novelai_metadata":
            case "novelai":
                ExtractNovelAIMetadata(value, image);
                break;
            case "dream_metadata":
                ExtractDreamMetadata(value, image);
                break;
            case "fooocus_metadata":
            case "ruinedfooocus_metadata":
                ExtractFooocusMetadata(value, image);
                break;
            case "stableswarm_metadata":
                ExtractStableSwarmMetadata(value, image);
                break;
        }

        // If no metadata was extracted from known keywords, check the value content
        if (string.IsNullOrEmpty(image.Model) && !string.IsNullOrEmpty(value))
        {
            if (value.Contains("parameters"))
            {
                ExtractAutomatic1111Metadata(value, image);
            }
            else if (value.Contains("invokeai_metadata"))
            {
                ExtractInvokeAIMetadata(value, image);
            }
        }
    }
    
    /// <summary>
    /// Extracts metadata from AUTOMATIC1111 format
    /// </summary>
    private void ExtractAutomatic1111Metadata(string chunkData, Image image)
    {
        // Pattern to match AUTOMATIC1111 metadata format
        var parameterMatch = Regex.Match(chunkData, @"parameters:([\s\S]*?)(\Z|\r\n\r\n)");
        if (parameterMatch.Success)
        {
            var parameters = parameterMatch.Groups[1].Value.Trim();
            
            // Extract prompt
            var promptMatch = Regex.Match(parameters, @"^(.*?)(?:Negative prompt:|Steps:|\Z)");
            if (promptMatch.Success)
            {
                image.Prompt = promptMatch.Groups[1].Value.Trim();
            }
            
            // Extract negative prompt
            var negativePromptMatch = Regex.Match(parameters, @"Negative prompt: (.*?)(?:Steps:|\Z)");
            if (negativePromptMatch.Success)
            {
                image.NegativePrompt = negativePromptMatch.Groups[1].Value.Trim();
            }
            
            // Extract steps
            var stepsMatch = Regex.Match(parameters, @"Steps: (\d+)");
            if (stepsMatch.Success)
            {
                image.Steps = int.Parse(stepsMatch.Groups[1].Value);
            }
            
            // Extract sampler
            var samplerMatch = Regex.Match(parameters, @"Sampler: ([^,]+)");
            if (samplerMatch.Success)
            {
                image.Sampler = samplerMatch.Groups[1].Value.Trim();
            }
            
            // Extract CFG scale
            var cfgMatch = Regex.Match(parameters, @"CFG scale: ([\d.]+)");
            if (cfgMatch.Success)
            {
                image.CFGScale = decimal.Parse(cfgMatch.Groups[1].Value);
            }
            
            // Extract seed
            var seedMatch = Regex.Match(parameters, @"Seed: (\d+)");
            if (seedMatch.Success)
            {
                image.Seed = long.Parse(seedMatch.Groups[1].Value);
            }
            
            // Extract size
            var sizeMatch = Regex.Match(parameters, @"Size: (\d+)x(\d+)");
            if (sizeMatch.Success)
            {
                image.Width = int.Parse(sizeMatch.Groups[1].Value);
                image.Height = int.Parse(sizeMatch.Groups[2].Value);
            }
            
            // Extract model
            var modelMatch = Regex.Match(parameters, @"Model: ([^,\n]+)");
            if (modelMatch.Success)
            {
                image.Model = modelMatch.Groups[1].Value.Trim();
            }
        }
    }
    
    /// <summary>
    /// Extracts metadata from InvokeAI format
    /// </summary>
    private void ExtractInvokeAIMetadata(string chunkData, Image image)
    {
        try
        {
            // Try to parse as JSON first
            if (TryParseJsonMetadata(chunkData, image))
            {
                if (string.IsNullOrEmpty(image.Model))
                    image.Model = "InvokeAI";
                return;
            }
            
            // Fallback to basic extraction
            image.Model = "InvokeAI";
        }
        catch (Exception)
        {
            image.Model = "InvokeAI";
        }
    }
    
    /// <summary>
    /// Extracts metadata from NovelAI format
    /// </summary>
    private void ExtractNovelAIMetadata(string chunkData, Image image)
    {
        try
        {
            // Try to parse as JSON first
            if (TryParseJsonMetadata(chunkData, image))
            {
                if (string.IsNullOrEmpty(image.Model))
                    image.Model = "NovelAI";
                return;
            }
            
            // Fallback to basic extraction
            image.Model = "NovelAI";
        }
        catch (Exception)
        {
            image.Model = "NovelAI";
        }
    }
    
    /// <summary>
    /// Extracts metadata from Dream format
    /// </summary>
    private void ExtractDreamMetadata(string chunkData, Image image)
    {
        try
        {
            // Try to parse as JSON first
            if (TryParseJsonMetadata(chunkData, image))
            {
                if (string.IsNullOrEmpty(image.Model))
                    image.Model = "Dream";
                return;
            }
            
            // Fallback to basic extraction
            image.Model = "Dream";
        }
        catch (Exception)
        {
            image.Model = "Dream";
        }
    }
    
    /// <summary>
    /// Extracts metadata from Fooocus format
    /// </summary>
    private void ExtractFooocusMetadata(string chunkData, Image image)
    {
        try
        {
            // Try to parse as JSON first
            if (TryParseJsonMetadata(chunkData, image))
            {
                if (string.IsNullOrEmpty(image.Model))
                    image.Model = "Fooocus";
                return;
            }
            
            // Fallback to basic extraction
            image.Model = "Fooocus";
        }
        catch (Exception)
        {
            image.Model = "Fooocus";
        }
    }
    
    /// <summary>
    /// Extracts metadata from Stable Swarm format
    /// </summary>
    private void ExtractStableSwarmMetadata(string chunkData, Image image)
    {
        try
        {
            // Try to parse as JSON first
            if (TryParseJsonMetadata(chunkData, image))
            {
                if (string.IsNullOrEmpty(image.Model))
                    image.Model = "Stable Swarm";
                return;
            }
            
            // Fallback to basic extraction
            image.Model = "Stable Swarm";
        }
        catch (Exception)
        {
            image.Model = "Stable Swarm";
        }
    }
    
    /// <summary>
    /// Attempts to parse JSON metadata
    /// </summary>
    /// <param name="jsonData">JSON metadata string</param>
    /// <param name="image">Image entity to populate</param>
    /// <returns>True if successful, false otherwise</returns>
    private bool TryParseJsonMetadata(string jsonData, Image image)
    {
        try
        {
            var jsonDoc = JsonDocument.Parse(jsonData);
            var root = jsonDoc.RootElement;
            
            // Extract common fields from different JSON structures
            ExtractFromJson(root, image);
            
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    /// <summary>
    /// Extracts metadata from JSON structure
    /// </summary>
    /// <param name="element">JSON element</param>
    /// <param name="image">Image entity to populate</param>
    private void ExtractFromJson(JsonElement element, Image image)
    {
        // Try to extract common fields
        if (element.TryGetProperty("prompt", out var promptElement))
            image.Prompt = promptElement.GetString();
        
        if (element.TryGetProperty("negative_prompt", out var negPromptElement))
            image.NegativePrompt = negPromptElement.GetString();
        if (element.TryGetProperty("negative", out var negElement))
            image.NegativePrompt = negElement.GetString();
        
        if (element.TryGetProperty("model", out var modelElement))
            image.Model = modelElement.GetString();
        if (element.TryGetProperty("model_name", out var modelNameElement))
            image.Model = modelNameElement.GetString();
        
        if (element.TryGetProperty("sampler", out var samplerElement))
            image.Sampler = samplerElement.GetString();
        if (element.TryGetProperty("sampler_name", out var samplerNameElement))
            image.Sampler = samplerNameElement.GetString();
        
        if (element.TryGetProperty("steps", out var stepsElement))
            image.Steps = stepsElement.GetInt32();
        
        if (element.TryGetProperty("cfg_scale", out var cfgElement))
            image.CFGScale = decimal.Parse(cfgElement.GetDouble().ToString());
        if (element.TryGetProperty("cfg", out var cfgScaleElement))
            image.CFGScale = decimal.Parse(cfgScaleElement.GetDouble().ToString());
        
        if (element.TryGetProperty("seed", out var seedElement))
        {
            long seedValue = 0;
            if (seedElement.ValueKind == JsonValueKind.String)
                long.TryParse(seedElement.GetString(), out seedValue);
            else
                seedValue = seedElement.GetInt64();
            
            image.Seed = seedValue;
        }
        
        if (element.TryGetProperty("width", out var widthElement))
            image.Width = widthElement.GetInt32();
        if (element.TryGetProperty("height", out var heightElement))
            image.Height = heightElement.GetInt32();
        
        // Recursively check nested objects
        if (element.TryGetProperty("metadata", out var metadataElement))
            ExtractFromJson(metadataElement, image);
        if (element.TryGetProperty("generation_metadata", out var genMetadataElement))
            ExtractFromJson(genMetadataElement, image);
        if (element.TryGetProperty("image_metadata", out var imgMetadataElement))
            ExtractFromJson(imgMetadataElement, image);
    }
}