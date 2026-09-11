using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Ana_CV_page.Models;
using System.Text.Json;
using api.Services;

namespace api
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private readonly CvStorageService _cvStorage;

        public Function1(
            ILogger<Function1> logger,
            CvStorageService cvStorage)
        {
            _logger = logger;
            _cvStorage = cvStorage;
        }

        [Function("cv")]
        public async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "put", Route = "cv")] HttpRequest req)
        {
            _logger.LogInformation("Ana CV API processed a request.");

            if (HttpMethods.IsPut(req.Method))
            {
                var cvToSave = await req.ReadFromJsonAsync<CvData>();

                if (cvToSave is null)
                {
                    return new BadRequestObjectResult("Invalid CV data.");
                }

                await _cvStorage.SaveCvAsync(cvToSave);

                return new OkObjectResult(cvToSave);
            }

            var cv = await _cvStorage.GetCvAsync();

            return new OkObjectResult(cv);
        }
    }
}
