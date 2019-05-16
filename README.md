# TASK 1

Create an Microsoft Azure Account.

# TASK 2

1. Create Cognitive Services Resource within the Azure Portal.
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

1. Implement the `DetectLanguage` method in the `TextAnalyticsService` class.
2. Implement the `AnalyzeSentiment` method in the `TextAnalyticsService` class.
3. Implement the `AnalyzeEntities` method in the `TextAnalyticsService` class.
4. Implement the `AnalyzeKeyPhrases` method in the `TextAnalyticsService` class.

# TASK 6: Computer Vision

1. Implement the `AnalyzeImage` method in the `ComputerVisionService` class.
2. Implement the `ExtractText` method in the `ComputerVisionService` class.
