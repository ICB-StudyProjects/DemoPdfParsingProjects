namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class FileContainerModel
    {
        [JsonProperty("company-specifications")]
        public ICollection<Specification> Specifications { get; set; }

        [JsonProperty("lab-certificates")]
        public ICollection<CertificateDemo> Certificates { get; set; }

        [JsonProperty("templates")]
        public IEnumerable<Company> LabCertTemplates { get; set; }
    }
}
