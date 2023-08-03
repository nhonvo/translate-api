using System.Text;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class TranslateController : ControllerBase
{
    private readonly AppConfiguration _appConfiguration;
    private readonly IHttpClientFactory _httpClientFactory;
    private string route = "";
    private string key = "";
    private string location = "";
    private string endpoint = "";
    private readonly ILogger<TranslateController> _logger;

    public TranslateController(AppConfiguration appConfiguration, IHttpClientFactory httpClientFactory, ILogger<TranslateController> logger)
    {
        _appConfiguration = appConfiguration;
        _httpClientFactory = httpClientFactory;
        key = _appConfiguration.AzureTranslate.Key;
        location = _appConfiguration.AzureTranslate.Location;
        endpoint = _appConfiguration.AzureTranslate.Endpoint;
        _logger = logger;

    }
    [HttpGet]
    public IActionResult Get() => Ok("Test");

    [HttpPost]
    public async Task<IActionResult> TranslateText(TranslateRequest request)
    {
        route = $"/translate?api-version=3.0&from={request.From}&to={request.To}";

        var client = _httpClientFactory.CreateClient("Azure_Translate");

        object[] body = new object[] { new { request.Text } };
        var requestBody = JsonConvert.SerializeObject(body);

        try
        {
            _logger.LogInformation("Translation request is being sent to Azure Cognitive Services.");

            // Build the request.
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Region", location);

            // Send the request and get response.
            HttpResponseMessage response = await client.PostAsync(endpoint + route, content).ConfigureAwait(false);

            // Send the request and get response.
            //HttpResponseMessage response = await client.SendAsync(res).ConfigureAwait(false);

            // Check for successful response.
            if (response.IsSuccessStatusCode)
            {
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();

                // Dispose of the HttpResponseMessage to release resources.
                response.Dispose();
                List<TranslateResponse> translateResponse = JsonConvert.DeserializeObject<List<TranslateResponse>>(result);
                string translatedText = translateResponse[0].Translations[0].Text;
                _logger.LogInformation($"Translation succeeded. Translated text: {translatedText}");

                return Ok(translatedText);
            }
            else
            {
                _logger.LogError($"Translation failed. HTTP status code: {response.StatusCode}");

                // Handle non-successful response (e.g., 404, 500, etc.).
                return BadRequest("Translation failed. HTTP status code: " + response.StatusCode);
            }
        }
        catch (HttpRequestException ex)
        {
            // Log network-related errors
            _logger.LogError("HTTP request failed: " + ex.Message);

            // Handle network-related errors.
            return BadRequest("HTTP request failed: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Log other exceptions
            _logger.LogError("An error occurred: " + ex.Message);

            // Handle other exceptions.
            return StatusCode(500, "An error occurred: " + ex.Message);
        }
    }
}
