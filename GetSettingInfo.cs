using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace az_functions_demo
{
    public static class GetSettingInfo
    {
        [FunctionName("GetSettingInfo")]
        public static async Task<IActionResult> Run(
            [HttpTrigger("get")] HttpRequest req, 
            [Blob("content/settings.json")] string json,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return new OkObjectResult(json);
        }
    }
}
