namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;

    public class Range
    {
        [JsonConstructor]
        public Range(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public double? Min { get; set; }

        public double? Max { get; set; }
    }
}
