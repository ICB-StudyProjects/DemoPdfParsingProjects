namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Text;

    public class Specification
    {
        [JsonConstructor]
        public Specification(string name)
        {
            this.Name = name;
            this.Properties = new HashSet<Property>();
        }

        public string CompanyName { get => "SANDVIK"; }

        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var prop in this.Properties)
            {
                sb.AppendLine(prop.ToString());
            }

            return sb.ToString();
        }
    }
}
