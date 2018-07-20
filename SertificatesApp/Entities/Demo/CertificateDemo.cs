namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CertificateDemo
    {
        [JsonConstructor]
        public CertificateDemo(string labName, string certName)
        {
            LabName = labName;
            CertName = certName;
            Properties = new HashSet<Property>();
        }

        [JsonProperty("lab-name")]
        public string LabName { get; set; }

        [JsonProperty("cert-name")]
        public string CertName { get; set; }

        public ICollection<Property> Properties { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"-=-=-=>>> {this.LabName} - {this.CertName}");

            foreach (var prop in Properties)
            {
                //StringBuilder sbProp = new StringBuilder();
                //sbProp.AppendLine($"> {prop.Name}");
                //sbProp.AppendLine($"* {prop.TestResult}");

                sb.AppendLine($"> Property: {prop.Name}{Environment.NewLine}^Test Result: {prop.TestResult}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
