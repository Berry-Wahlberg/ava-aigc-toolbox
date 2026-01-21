# AI Integration
\n> **La version anglaise prévaut**\n\n
The AVA AIGC Toolbox offers several AI-powered features to enhance your workflow with AI-generated images. This guide covers how to use these advanced AI integration features.

## AI-Powered Tagging

### Automatic Tag Generation

The application can automatically generate tags for your images using AI:

#### Steps to Auto-Tag Images:
1. Select one or more images
2. Right-click and select **AI Tools > Auto-Tag Images**, or go to `Tools > AI Tools > Auto-Tag Images`
3. In the auto-tag dialog, select the tag generation model (if multiple are available)
4. Choose tag options:
   - **Number of Tags**: How many tags to generate per image
   - **Tag Confidence Threshold**: Minimum confidence level for generated tags
   - **Overwrite Existing Tags**: Replace existing tags with generated tags
5. Click **Generate Tags** to start the process
6. Monitor progress in the dialog
7. Review generated tags
8. Click **Apply** to apply the tags to the images

### Custom Tag Models

You can use custom tag models for more specific tagging needs:

#### Steps to Add Custom Tag Model:
1. Go to `Settings > AI > Tag Models`
2. Click **Add Model**
3. Select the model file from your filesystem
4. Enter a name for the model
5. Click **Save** to add the model

### Tag Model Settings

#### Steps to Configure Tag Models:
1. Go to `Settings > AI > Tag Models`
2. Select the model you want to configure
3. Adjust settings:
   - **Default Model**: Set as default tag model
   - **Confidence Threshold**: Default confidence level for this model
   - **Tag Language**: Language for generated tags
   - **Tag Categories**: Enable/disable specific tag categories
4. Click **Save** to apply changes

## AI Metadata Enhancement

### Smart Metadata Completion

The application can automatically enhance your image metadata using AI:

#### Steps to Enhance Metadata:
1. Select one or more images
2. Right-click and select **AI Tools > Enhance Metadata**, or go to `Tools > AI Tools > Enhance Metadata`
3. In the enhancement dialog, select which metadata fields to enhance:
   - **Prompt Enhancement**: Improve the prompt text
   - **Negative Prompt Generation**: Generate negative prompts for images without them
   - **Style Classification**: Add style tags and classification
4. Click **Enhance Metadata** to start the process
5. Monitor progress in the dialog
6. Review enhanced metadata
7. Click **Apply** to save the changes

### Prompt Improvement

You can improve your prompts using AI to generate better results in future image generations:

#### Steps to Improve Prompts:
1. Select an image with a prompt you want to improve
2. In the details panel, find the **AI Metadata** section
3. Click the **Improve Prompt** button next to the prompt field
4. The application will generate an improved prompt
5. Review the improved prompt
6. Click **Accept** to replace the original prompt, or **Discard** to keep the original

## AI Image Analysis

### Image Style Analysis

The application can analyze images to determine their artistic style:

#### Steps to Analyze Image Style:
1. Select one or more images
2. Right-click and select **AI Tools > Analyze Style**, or go to `Tools > AI Tools > Analyze Style`
3. In the style analysis dialog, select the style analysis model
4. Click **Analyze Style** to start the process
5. Monitor progress in the dialog
6. Review the style analysis results
7. Click **Apply** to add style tags to the images

### Image Quality Assessment

The application can assess the quality of AI-generated images:

#### Steps to Assess Image Quality:
1. Select one or more images
2. Right-click and select **AI Tools > Assess Quality**, or go to `Tools > AI Tools > Assess Quality`
3. In the quality assessment dialog, select the quality model
4. Click **Assess Quality** to start the process
5. Monitor progress in the dialog
6. Review the quality scores
7. Click **Apply** to add quality scores to the images

## AI Integration Settings

### General AI Settings

#### Steps to Configure AI Settings:
1. Go to `Settings > AI > General`
2. Configure general AI settings:
   - **Enable AI Features**: Toggle AI features on or off
   - **Default AI Model**: Set the default AI model for various tasks
   - **Max Parallel Requests**: Number of parallel AI requests
   - **Cache AI Results**: Cache AI results for faster processing
3. Click **Save** to apply changes

### API Integration

The application can integrate with external AI APIs:

#### Steps to Configure API Integration:
1. Go to `Settings > AI > API`
2. Select the API you want to configure
3. Enter API credentials:
   - **API Key**: Your API key for the service
   - **API URL**: API endpoint URL
   - **Rate Limit**: Maximum number of requests per minute
4. Click **Test Connection** to verify the configuration
5. Click **Save** to apply changes

### Supported AI Services

The application supports integration with various AI services:

- **Local Models**: Run AI models locally on your machine
- **OpenAI**: GPT for text generation and analysis
- **Stable Diffusion APIs**: For image generation and analysis
- **Custom APIs**: Add your own AI service endpoints

## AI Workflow Integration

### Integration with AI Generation Tools

The application can integrate with AI image generation tools:

#### Steps to Configure Workflow Integration:
1. Go to `Settings > AI > Workflow Integration`
2. Select the AI generation tool you want to integrate with
3. Configure the tool settings:
   - **Tool Path**: Path to the tool executable
   - **Default Settings**: Default settings for image generation
   - **Output Folder**: Folder where generated images are saved
4. Click **Test Integration** to verify the configuration
5. Click **Save** to apply changes

### Quick Generation

Generate new images directly from the application:

#### Steps to Generate Images:
1. Go to `Tools > AI Tools > Generate Images`
2. In the generation dialog, configure generation settings:
   - **Prompt**: Text prompt for image generation
   - **Negative Prompt**: Text specifying what to exclude
   - **Model**: AI model to use for generation
   - **Steps**: Number of generation steps
   - **Sampler**: Sampling method to use
   - **CFG Scale**: Classifier-free guidance scale
   - **Seed**: Random seed for generation
   - **Width/Height**: Generated image dimensions
3. Click **Generate** to start the generation process
4. Monitor progress in the dialog
5. When generation is complete, review the generated images
6. Click **Add to Library** to add the images to your library

## Best Practices for AI Integration

1. **Use Local Models When Possible**: Local models are faster and more private
2. **Optimize Settings**: Adjust confidence thresholds and parameters for your needs
3. **Review Generated Content**: Always review AI-generated tags and metadata
4. **Cache Results**: Enable caching for repeated AI operations
5. **Limit Parallel Requests**: Avoid overwhelming your system or API limits
6. **Update Models Regularly**: Keep your AI models up to date for better results
7. **Use Appropriate Models**: Choose the right model for each task (tagging, enhancement, etc.)
8. **Respect API Limits**: Follow API rate limits to avoid service disruptions

## Troubleshooting AI Issues

### AI Features Not Working
- **Check Model Availability**: Ensure the required AI models are installed
- **Check API Credentials**: Verify API keys and configurations
- **Check System Requirements**: Ensure your system meets the requirements for AI processing
- **Check Firewall Settings**: Ensure the application has network access for API calls

### Slow AI Processing
- **Reduce Parallel Requests**: Decrease the number of parallel AI requests
- **Use Smaller Models**: Switch to smaller, faster models for better performance
- **Enable Caching**: Ensure AI result caching is enabled
- **Close Other Applications**: Free up system resources by closing other applications

### Poor AI Results
- **Adjust Confidence Threshold**: Change the confidence threshold for better results
- **Try Different Models**: Experiment with different AI models
- **Improve Input Quality**: Ensure your input images are of good quality
- **Update Models**: Use the latest versions of AI models

### API Integration Issues
- **Check API Key**: Verify your API key is correct and has sufficient permissions
- **Check API Status**: Verify the API service is operational
- **Check Rate Limits**: Ensure you're not exceeding API rate limits
- **Check Network Connection**: Ensure you have a stable internet connection

## Next Steps

- Learn about [Batch Operations](./batch-operations.md) for bulk image processing
- Read about [Backup & Restore](./backup-restore.md) to safeguard your library
- Explore [Metadata Editing](../features/metadata-editing.md) for manual metadata management