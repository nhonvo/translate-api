using api.Enum;

namespace api.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        public string? Token { get; set; }
    }
}