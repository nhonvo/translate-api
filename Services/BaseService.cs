using api.Enum;
using api.Models;
using Newtonsoft.Json;
using System.Text;
namespace api.Services
{
    public interface IBaseService
    {
        Task<T> SendAsync<T>(APIRequest apiRequest, string requestContent);
    }
    public class BaseService : IBaseService
    {
        public IHttpClientFactory _httpClient { get; set; }
        private readonly AppConfiguration _configuration;
        private readonly ILogger<TranslateService> _logger;

        public BaseService(
            AppConfiguration configuration,
            IHttpClientFactory httpClient,
            ILogger<TranslateService> logger
            )
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _logger = logger;
        }
        public async Task<T> SendAsync<T>(APIRequest apiRequest, string Text)
        {
            try
            {
                _logger.LogInformation("Request is being sent to Azure Cognitive Services.");
                var client = _httpClient.CreateClient("Azure_Translate");

                HttpRequestMessage message = new();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
              
                if (apiRequest.Data != null)
                {
                    object[] body = new object[] {
                         new {
                             Text
                        }};
                    var requestBody = JsonConvert.SerializeObject(body);

                    message.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                }
                switch (apiRequest.ApiType)
                {
                    case ApiType.GET:
                        message.Method = HttpMethod.Get;
                        break;
                    case ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                }
                HttpResponseMessage responseMessage = null;
                responseMessage = await client.SendAsync(message);
                if (responseMessage.IsSuccessStatusCode)
                {

                    var responseContent = await responseMessage.Content.ReadAsStringAsync();

                    var response = JsonConvert.DeserializeObject<T>(responseContent);
                    _logger.LogInformation($"Translation succeeded. Translated text: {response}");

                    return response;
                }
                else
                {
                    _logger.LogError($"Translation failed. HTTP status code: {responseMessage.StatusCode}");

                    //             // Handle non-successful response (e.g., 404, 500, etc.).
                    throw new Exception("Translation failed. HTTP status code: " + responseMessage.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                // Log network-related errors
                _logger.LogError("HTTP request failed: " + ex.Message);

                // Handle network-related errors.
                throw;
            }
            catch (Exception exception)
            {
                
                _logger.LogError("An error occurred: " + exception.Message);
                throw new Exception(exception.ToString());
            }
        }
    }
}
