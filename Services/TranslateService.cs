namespace api.Services
{
    using System.Text;
    using api.Models;
    using Newtonsoft.Json;
    public class TranslateService : ITranslateService
    {
        private readonly AppConfiguration _appConfiguration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient client;
        private string route = "";
        private readonly string endpoint = "";
        private readonly ILogger<TranslateService> _logger;
        public TranslateService(AppConfiguration appConfiguration,
                                IHttpClientFactory httpClientFactory,
                                ILogger<TranslateService> logger)
        {
            _appConfiguration = appConfiguration;
            _httpClientFactory = httpClientFactory;
            endpoint = _appConfiguration.AzureTranslate.Endpoint;
            _logger = logger;
            client = _httpClientFactory.CreateClient("Azure_Translate");
        }
        public async Task<string> Translate(TranslateRequest request, string? from, string? to)
        {
            route = $"/translate?api-version=3.0&from{from}=&to={to}";

            object[] body = new object[] {
             new {
                 request.Text
            }
        };
            var requestBody = JsonConvert.SerializeObject(body);

            using var res = new HttpRequestMessage();
            // Build the request.
            res.Method = HttpMethod.Post;
            res.RequestUri = new Uri(endpoint + route);

            res.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            try
            {
                _logger.LogInformation("Translation request is being sent to Azure Cognitive Services.");

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(res).ConfigureAwait(false);

                // Check for successful response.
                if (response.IsSuccessStatusCode)
                {
                    // Read response as a string.
                    string result = await response.Content.ReadAsStringAsync();

                    // Dispose of the HttpResponseMessage to release resources.
                    response.Dispose();
                    List<TranslateResponse> translateResponse = JsonConvert.DeserializeObject<List<TranslateResponse>>(result)!;
                    string translatedText = translateResponse[0].Translations[0].Text;
                    _logger.LogInformation($"Translation succeeded. Translated text: {translatedText}");

                    return translatedText;
                }
                else
                {
                    _logger.LogError($"Translation failed. HTTP status code: {response.StatusCode}");

                    // Handle non-successful response (e.g., 404, 500, etc.).
                    throw new Exception("Translation failed. HTTP status code: " + response.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                // Log network-related errors
                _logger.LogError("HTTP request failed: " + ex.Message);

                // Handle network-related errors.
                throw;
            }
            catch (Exception ex)
            {
                // Log other exceptions
                _logger.LogError("An error occurred: " + ex.Message);

                // Handle other exceptions.
                throw;
            }
        }
        public async Task<List<LookUp>> LookUp(TranslateRequest request, string? from, string? to)
        {
            route = $"/dictionary/lookup?api-version=3.0&from={from}&to={to}";

            // var client = _httpClientFactory.CreateClient("Azure_Translate");

            object[] body = new object[] {
             new {
                 request.Text
            }
        };
            var requestBody = JsonConvert.SerializeObject(body);

            using var res = new HttpRequestMessage();
            // Build the request.
            res.Method = HttpMethod.Post;
            res.RequestUri = new Uri(endpoint + route);

            res.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            try
            {
                _logger.LogInformation("Dictionary lookup request is being sent to Azure Cognitive Services.");

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(res).ConfigureAwait(false);

                // Check for successful response.
                if (response.IsSuccessStatusCode)
                {
                    // Read response as a string.
                    string result = await response.Content.ReadAsStringAsync();

                    // Dispose of the HttpResponseMessage to release resources.
                    response.Dispose();
                    var translateResponse = JsonConvert.DeserializeObject<List<LookUp>>(result)!;
                    _logger.LogInformation($"Dictionary lookup succeeded. Translated text: {translateResponse}");

                    return translateResponse;
                }
                else
                {
                    _logger.LogError($"Dictionary lookup failed. HTTP status code: {response.StatusCode}");

                    // Handle non-successful response (e.g., 404, 500, etc.).
                    throw new Exception("Dictionary lookup failed. HTTP status code: " + response.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                // Log network-related errors
                _logger.LogError("HTTP request failed: " + ex.Message);

                // Handle network-related errors.
                throw;
            }
            catch (Exception ex)
            {
                // Log other exceptions
                _logger.LogError("An error occurred: " + ex.Message);

                // Handle other exceptions.
                throw;
            }
        }
    }

    public interface ITranslateService
    {
        Task<string> Translate(TranslateRequest request, string? from, string? to);
        Task<List<LookUp>> LookUp(TranslateRequest request, string? from, string? to);
    }
}