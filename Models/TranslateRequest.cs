using Newtonsoft.Json;

namespace api.Models
{
    public class TranslateRequest
    {
        public string Text { get; set; } = string.Empty;
    }
    public class TranslateResponse
    {
        [JsonProperty("translations")]
        public List<Translation1> Translations { get; set; }
    }
    public class Translation1
    {
        [JsonProperty("text")]
        public string Text { get; set; } = string.Empty;
        [JsonProperty("to")]
        public string To { get; set; } = string.Empty;
    }
}