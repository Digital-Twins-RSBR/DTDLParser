namespace ParserWebAPI.models
{
    public class DTDLModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<ModelElement> modelElements { get; set; }

        public List<ModelRelationship> modelRelationships { get; set; }
    }
}
