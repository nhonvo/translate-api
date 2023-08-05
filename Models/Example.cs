namespace api.Models
{
    public class ExampleRequest
    {
        public List<Example> Examples { get; set; }
    }
    public class Example
    {
        public string Text { get; set; } = string.Empty;
        public string Translation { get; set; } = string.Empty;
    }
}