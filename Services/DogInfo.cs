namespace wikiapp.Services
{
    public class DataJson
    {
        public List<DogInfo> data { get; set; }
    }

    public class DogInfo
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Attributes
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
