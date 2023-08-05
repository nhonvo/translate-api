using api.Enum;

namespace api.Models
{
    #nullable disable
    public class APIRequest
    {
        public ApiType ApiType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
    }
}