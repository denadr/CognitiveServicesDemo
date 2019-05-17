using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

public class ComputerVisionService
{
    private const string _subscriptionKey = "cfc2d88f907d4fbeb2a0883d3bc9fcb2";
    private const string _endpoint = "https://westeurope.api.cognitive.microsoft.com/";

    public async Task<ImageAnalysis> AnalyzeImage(Stream image)
    {
        var credentials = new ApiKeyServiceClientCredentials(_subscriptionKey);
        var client = new ComputerVisionClient(credentials)
        {
            Endpoint = _endpoint
        };

        var result = await client.AnalyzeImageInStreamAsync(image, new List<VisualFeatureTypes>()
        {
            VisualFeatureTypes.ImageType,
            VisualFeatureTypes.Faces,
            VisualFeatureTypes.Adult,
            VisualFeatureTypes.Categories,
            VisualFeatureTypes.Color,
            VisualFeatureTypes.Tags,
            VisualFeatureTypes.Description,
            VisualFeatureTypes.Objects,
            VisualFeatureTypes.Brands
        },
        new List<Details>()
        {
            Details.Celebrities,
            Details.Landmarks
        });

        return result;
    }

    public async Task<IList<TextRecognitionResult>> ExtractText(Stream image)
    {
        var credentials = new ApiKeyServiceClientCredentials(_subscriptionKey);
        var client = new ComputerVisionClient(credentials)
        {
            Endpoint = _endpoint
        };

        var textHeaders = await client.BatchReadFileInStreamAsync(image, TextRecognitionMode.Handwritten);
        var operationId = textHeaders.OperationLocation.Substring(textHeaders.OperationLocation.Length - 36);

        ReadOperationResult result;
        do
        {
            result = await client.GetReadOperationResultAsync(operationId);
            await Task.Delay(1000);
        }
        while (result.Status == TextOperationStatusCodes.NotStarted || result.Status == TextOperationStatusCodes.Running);

        return result.RecognitionResults;
    }
}
