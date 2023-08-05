namespace api.Models
{
    #nullable disable
    public class LookUp
    {
        public string normalizedSource { get; set; }
        public string displaySource { get; set; }
        public List<Translation2> translations { get; set; }
    }
    public class BackTranslation
    {
        public string normalizedText { get; set; }
        public string displayText { get; set; }
        public int numExamples { get; set; }
        public int frequencyCount { get; set; }
    }
    public class Translation2
    {
        public string normalizedTarget { get; set; }
        public string displayTarget { get; set; }
        public string posTag { get; set; }
        public double confidence { get; set; }
        public string prefixWord { get; set; }
        public List<BackTranslation> backTranslations { get; set; }
    }
}