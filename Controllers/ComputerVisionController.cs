using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;

namespace CognitiveServicesDemo.Controllers
{
    [Route("api/[controller]")]
    public class ComputerVisionController : Controller
    {
        private ComputerVisionService _computerVision;

        public ComputerVisionController(ComputerVisionService computerVision)
        {
            _computerVision = computerVision;
        }

        [HttpPost("[action]")]
        public async Task<dynamic> AnalyzeImage()
        {
            using (var image = Request.Form.Files.First().OpenReadStream())
            {
                return await _computerVision.AnalyzeImage(image);
            }
        }

        [HttpPost("[action]")]
        public async Task<dynamic> ExtractText()
        {
            return await _computerVision.ExtractText(Request.Body);
        }
    }
}
