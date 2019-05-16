using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

public class ComputerVisionService
{
    private const string _subscriptionKey = "<enter your subscription key here>";
    private const string _endpoint = "<enter your cognitive services endpoint here>";

    public async Task<ImageAnalysis> AnalyzeImage(Stream image)
    {
        return null;
    }

    public async Task<IList<TextRecognitionResult>> ExtractText(Stream image)
    {
        return null;
    }
}
