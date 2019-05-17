using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

public class TextAnalyticsService
{
    private const string _subscriptionKey = "cfc2d88f907d4fbeb2a0883d3bc9fcb2";
    private const string _endpoint = "https://westeurope.api.cognitive.microsoft.com/";

    public async Task<IList<DetectedLanguage>> DetectLanguage(string input)
    {
        var credentials = new ApiKeyServiceClientCredentials(_subscriptionKey);
        var client = new TextAnalyticsClient(credentials)
        {
            Endpoint = _endpoint
        };

        var result = await client.DetectLanguageAsync(true, new LanguageBatchInput(new List<LanguageInput>()
        {
            new LanguageInput(null, "1", input)
        }));

        return result.Documents.First().DetectedLanguages;
    }

    public async Task<double?> AnalyzeSentiment(string input)
    {
        var credentials = new ApiKeyServiceClientCredentials(_subscriptionKey);
        var client = new TextAnalyticsClient(credentials)
        {
            Endpoint = _endpoint
        };

        var result = await client.SentimentAsync(true, new MultiLanguageBatchInput(new List<MultiLanguageInput>()
        {
            new MultiLanguageInput(null, "1", input)
        }));

        return result.Documents.First().Score;
    }

    public async Task<IList<EntityRecord>> RecognizeEntities(string input)
    {
        var credentials = new ApiKeyServiceClientCredentials(_subscriptionKey);
        var client = new TextAnalyticsClient(credentials)
        {
            Endpoint = _endpoint
        };

        var result = await client.EntitiesAsync(true, new MultiLanguageBatchInput(new List<MultiLanguageInput>()
        {
            new MultiLanguageInput(null, "1", input)
        }));

        return result.Documents.First().Entities;
    }

    public async Task<IList<string>> ExtractKeyPhrases(string input)
    {
        var credentials = new ApiKeyServiceClientCredentials(_subscriptionKey);
        var client = new TextAnalyticsClient(credentials)
        {
            Endpoint = _endpoint
        };

        var result = await client.KeyPhrasesAsync(true, new MultiLanguageBatchInput(new List<MultiLanguageInput>()
        {
            new MultiLanguageInput(null, "1", input)
        }));

        return result.Documents.First().KeyPhrases;
    }
}
