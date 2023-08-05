namespace api.Services
{
    using System.Text;
    using api.Models;
    using Newtonsoft.Json;
    public class TranslateService : ITranslateService
    {
        private readonly AppConfiguration _appConfiguration;
        private readonly IHttpClientFactory _httpClientFactory;
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
        }
        // private const string region_var = "TRANSLATOR_SERVICE_REGION";
        // private static readonly string region = Environment.GetEnvironmentVariable(region_var);

        // private const string key_var = "TRANSLATOR_TEXT_RESOURCE_KEY";
        // private static readonly string resourceKey = Environment.GetEnvironmentVariable(key_var);

        // private const string endpoint_var = "TRANSLATOR_TEXT_ENDPOINT";
        // private static readonly string endpoint = Environment.GetEnvironmentVariable(endpoint_var);
        // public async Task TranslateTextRequest(string route, string inputText)
        // {
        //     object[] body = new object[] { new { Text = inputText } };
        //     var requestBody = JsonConvert.SerializeObject(body);

        //     using (var client = new HttpClient())
        //     using (var request = new HttpRequestMessage())
        //     {
        //         // Build the request.
        //         request.Method = HttpMethod.Post;
        //         request.RequestUri = new Uri(endpoint + route);
        //         request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
        //         // request.Headers.Add("Ocp-Apim-Subscription-Key", resourceKey);
        //         // request.Headers.Add("Ocp-Apim-Subscription-Region", region);

        //         // Send the request and get response.
        //         HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
        //         // Read response as a string.
        //         string result = await response.Content.ReadAsStringAsync();
        //         TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
        //         // Iterate over the deserialized results.
        //         foreach (TranslationResult o in deserializedOutput)
        //         {
        //             // Print the detected input language and confidence score.
        //             Console.WriteLine("Detected input language: {0}\nConfidence score: {1}\n", o.DetectedLanguage.Language, o.DetectedLanguage.Score);
        //             // Iterate over the results and print each translation.
        //             foreach (Translation t in o.Translations)
        //             {
        //                 Console.WriteLine("Translated to {0}: {1}", t.To, t.Text);
        //             }
        //         }
        //     }
        // }
        public async Task<string> Translate(TranslateRequest request, string? from, string? to)
        {
            route = $"/translate?api-version=3.0&from={from}&to={to}";

            var client = _httpClientFactory.CreateClient("Azure_Translate");

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
    }

    public interface ITranslateService
    {
        // Task TranslateTextRequest(string route, string inputText);
        Task<string> Translate(TranslateRequest request, string? from, string? to);
    }
}