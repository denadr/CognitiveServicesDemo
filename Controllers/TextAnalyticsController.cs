using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CognitiveServicesDemo.Controllers
{
    [Route("api/[controller]")]
    public class TextAnalyticsController : Controller
    {
        private TextAnalyticsService _textAnalytics;

        public TextAnalyticsController(TextAnalyticsService textAnalytics)
        {
            _textAnalytics = textAnalytics;
        }

        [HttpGet("[action]")]
        public async Task<dynamic> DetectLanguage([FromQuery] string input)
        {
            return await _textAnalytics.DetectLanguage(input);
        }

        [HttpGet("[action]")]
        public async Task<dynamic> AnalyzeSentiment([FromQuery] string input)
        {
            return await _textAnalytics.AnalyzeSentiment(input);
        }

        [HttpGet("[action]")]
        public async Task<dynamic> AnalyzeEntities([FromQuery] string input)
        {
            return await _textAnalytics.AnalyzeEntities(input);
        }

        [HttpGet("[action]")]
        public async Task<dynamic> AnalyzeKeyPhrases([FromQuery] string input)
        {
            return await _textAnalytics.AnalyzeKeyPhrases(input);
        }
    }
}
