using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

public class TextAnalyticsService
{
    private const string _subscriptionKey = "<enter your subscription key here>";
    private const string _endpoint = "<enter your cognitive services endpoint here>";

    public async Task<IList<DetectedLanguage>> DetectLanguage(string input)
    {
        return null;
    }

    public async Task<double?> AnalyzeSentiment(string input)
    {
        return null;
    }

    public async Task<IList<EntityRecord>> RecognizeEntities(string input)
    {
        return null;
    }

    public async Task<IList<string>> ExtractKeyPhrases(string input)
    {
        return null;
    }
}
