using System.Net;

namespace api.Models
{
    #nullable disable
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public object resultObj { get; set; }
    }
}