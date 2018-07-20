namespace DocParserTest.Models
{
    using Newtonsoft.Json;

    public class Parser
    {
        [JsonConstructor]
        public Parser(string id, string label)
        {
            Id = id;
            Label = label;
        }
        public string Id { get; set; }

        public string Label { get; set; }
    }
}
