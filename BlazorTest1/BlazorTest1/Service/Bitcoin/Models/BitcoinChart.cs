namespace BlazorTest1.Service.Bitcoin.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Bpi
    {
        public BitcoinPrice USD { get; set; }
        public BitcoinPrice GBP { get; set; }
        public BitcoinPrice EUR { get; set; }
    }

    public class BitcoinPrice
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

    public class BitcoinChart
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public Bpi bpi { get; set; }
    }

    public class Time
    {
        public string updated { get; set; }
        public DateTime updatedISO { get; set; }
        public string updateduk { get; set; }
    }
}
