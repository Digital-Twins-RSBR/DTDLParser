namespace ParserWebAPI.models
{
    public class ModelElement
    {
        public long Id { get; set; }
        public string type {  get; set; }
        public string name { get; set; }
        public string schema { get; set; }

        public List<string> supplementTypes { get; set; }
    }
}
