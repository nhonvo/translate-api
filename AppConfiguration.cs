namespace api
{
    public class AppConfiguration
    {
        public AzureTranslate AzureTranslate { get; set; } 
    }
    public class AzureTranslate
    {
        public string Key { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
    }
}