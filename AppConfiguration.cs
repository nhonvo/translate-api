namespace api
{
    public class AppConfiguration
    {
        public AzureTranslate AzureTranslate { get; set; } = new AzureTranslate();
    }
    public class AzureTranslate
    {
        public string Key { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}