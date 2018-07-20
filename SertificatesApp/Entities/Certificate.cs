namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Certificate
    {
        [JsonConstructor]
        public Certificate(string name)
        {
            this.Name = name;
            this.Pages = new HashSet<Page>();
        }

        [JsonProperty("cert-name")]
        public string Name { get; set; }
        public IEnumerable<Page> Pages { get; set; }
    }
}
