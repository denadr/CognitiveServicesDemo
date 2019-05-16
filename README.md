# TASK 1

Create an Microsoft Azure Account. For more information visit https://azure.microsoft.com/en-us/free/.

# TASK 2

1. Create Cognitive Services Resource within the Azure Portal. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/cognitive-services-apis-create-account#create-and-subscribe-to-an-azure-cognitive-services-resource.
2. Remember the required credentials to access your resource.
    - Endpoint URL
    - Subscription Key

If this is not possible for any reason, you could use the credentials of my demo resource:
- Endpoint URL: `https://westeurope.api.cognitive.microsoft.com/`
- Subscription Key: just ask me ;)

# TASK 3

Install required Cognitive Services NuGet packages
    
- TextAnalytics
- ComputerVision
    
by running the following commands.

```
dotnet add package Microsoft.Azure.CognitiveServices.Language.TextAnalytics
dotnet add package Microsoft.Azure.CognitiveServices.Vision.ComputerVision
```

# TASK 4

Validate that the code is running by typing

```
dotnet watch run
```

or hitting `F5`.

If the build was successful, open the app by visiting http://localhost:5000.

# TASK 5: Text Analytics

Basic documentation: https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/.

1. Insert your credentials (Task 2.2) into the properties of the `TextAnalyticsService` class respectively.
2. Implement the `DetectLanguage` method in the `TextAnalyticsService` class. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/quickstarts/csharp#perform-language-detection.
3. Implement the `AnalyzeSentiment` method in the `TextAnalyticsService` class. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/quickstarts/csharp#perform-sentiment-analysis.
4. Implement the `RecognizeEntities` method in the `TextAnalyticsService` class. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/quickstarts/csharp#perform-entity-recognition.
5. Implement the `ExtractKeyPhrases` method in the `TextAnalyticsService` class. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/quickstarts/csharp#perform-key-phrase-extraction.

# TASK 6: Computer Vision

Basic documentation: https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/.

1. Insert your credentials (Task 2.2) into the properties of the `ComputerVisionService` class respectively.
2. Implement the `AnalyzeImage` method in the `ComputerVisionService` class. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/quickstarts-sdk/csharp-analyze-sdk.
3. Implement the `ExtractText` method in the `ComputerVisionService` class. For more information visit https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/quickstarts-sdk/csharp-hand-text-sdk.
