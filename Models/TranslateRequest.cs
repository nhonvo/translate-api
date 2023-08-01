using Newtonsoft.Json;

namespace api.Models
{
    public class TranslateRequest
    {
        public string Text { get; set; } = string.Empty;
        public string? From { get; set; } = "en";
        public string? To { get; set; } = "vi";
    }
    public class TranslateResponse
    {
        [JsonProperty("translations")]
        public List<Translation> Translations { get; set; }
    }
    public class Translation
    {
        [JsonProperty("text")]
        public string Text { get; set; } = string.Empty;
        [JsonProperty("to")]
        public string To { get; set; } = string.Empty;
    }
}