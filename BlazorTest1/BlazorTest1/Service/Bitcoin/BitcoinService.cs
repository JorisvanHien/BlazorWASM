using BlazorTest1.Service.Bitcoin.Models;
using System.Net.Http.Json;

namespace BlazorTest1.Service.Bitcoin
{
    public class BitcoinService : IBitcoinService
    {
        private readonly HttpClient _httpClient;

        public BitcoinService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BitcoinPrice?> GetEuroResult()
        {
            var bitCoinChart =  await _httpClient.GetFromJsonAsync<BitcoinChart>(GetBaseUrl() + "v1/bpi/currentprice.json");

            if (bitCoinChart == null) return null;

            return bitCoinChart.bpi?.EUR;

        }

        private string GetBaseUrl()
        {
            return _httpClient.BaseAddress.ToString();
        }
    }
}
