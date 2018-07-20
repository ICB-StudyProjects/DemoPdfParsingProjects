namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System.Text;

    public class Property
    {
        [JsonConstructor]
        public Property(string name, double min, double max)
        {
            Name = name;
            Range = new Range(min, max);
        }

        public string Name { get; set; }

        public Range Range { get; set; }

        [JsonProperty("test-result")]
        public double? TestResult { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"> {this.Name} ");
            sb.AppendLine($"^^ Range: ");
            sb.AppendLine($"--- Min: ${Range.Min}");
            sb.AppendLine($"--- Max: ${Range.Max}");

            return sb.ToString();
        }
    }
}
