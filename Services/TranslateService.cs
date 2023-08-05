using api.Enum;
using api.Models;

namespace api.Services
{
    public class TranslateService : BaseService, ITranslateService
    {
        private readonly AppConfiguration _appConfiguration;
        private string route = "";
        private readonly string endpoint = "";
        public TranslateService(AppConfiguration configuration,
                                IHttpClientFactory httpClientFactory,
                                ILogger<TranslateService> logger) : base(configuration, httpClientFactory, logger)
        {
            _appConfiguration = configuration;
            endpoint = _appConfiguration.AzureTranslate.Endpoint;
        }
        public async Task<LanguageRoot> Get()
        {
            var result = await SendAsync<LanguageRoot>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = "https://api.cognitive.microsofttranslator.com/languages?api-version=3.0"
            }, "");
            return result;
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
        Task<LanguageRoot> Get();
        Task<List<LookUp>> LookUp(TranslateRequest request, string? from, string? to);
    }
}