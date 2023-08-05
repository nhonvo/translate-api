namespace api.Services
{
    using System.Text;
    using api.Enum;
    using api.Models;
    using Newtonsoft.Json;
    public class TranslateService : BaseService, ITranslateService
    {
        private readonly AppConfiguration _appConfiguration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient client;
        private string route = "";
        private readonly string endpoint = "";
        private readonly ILogger<TranslateService> _logger;
        public TranslateService(AppConfiguration configuration,
                                IHttpClientFactory httpClientFactory,
                                ILogger<TranslateService> logger) : base(configuration, httpClientFactory, logger)
        {
            _appConfiguration = configuration;
            _httpClientFactory = httpClientFactory;
            endpoint = _appConfiguration.AzureTranslate.Endpoint;
            _logger = logger;
            client = _httpClientFactory.CreateClient("Azure_Translate");
        }
        public async Task<string> Translate(TranslateRequest request, string? from, string? to)
        {
            route = $"/translate?api-version=3.0&from{from}=&to={to}";
            var result = await SendAsync<List<TranslateResponse>>(new APIRequest()
            {
                ApiType = ApiType.POST,
                // Token = token,
                Data = request,
                Url = endpoint + route
            }, request.Text);
            // List<TranslateResponse> translateResponse = JsonConvert.DeserializeObject<List<TranslateResponse>>(result)!;
            string translatedText = result[0].Translations[0].Text;
            return translatedText;
        }
        public async Task<List<LookUp>> LookUp(TranslateRequest request, string? from, string? to)
        {
            route = $"/dictionary/lookup?api-version=3.0&from={from}&to={to}";
            var result = await SendAsync<List<LookUp>>(new APIRequest()
            {
                ApiType = ApiType.POST,
                // Token = token,
                Data = request,
                Url = endpoint + route
            }, request.Text);
            return result;
        }

    }

    public interface ITranslateService
    {
        Task<string> Translate(TranslateRequest request, string? from, string? to);
        // Task<string> Translate(TranslateRequest request, string? from, string? to);
        Task<List<LookUp>> LookUp(TranslateRequest request, string? from, string? to);
    }
}