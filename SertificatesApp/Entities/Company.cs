namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Company
    {
        [JsonConstructor]
        public Company(string name)
        {
            this.Name = name;
            this.Certificates = new HashSet<Certificate>();
        }

        [JsonProperty("company-name")]
        public string Name { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
    }
}
