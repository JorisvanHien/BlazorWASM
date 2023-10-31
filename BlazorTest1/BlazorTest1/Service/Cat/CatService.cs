using System.Net.Http.Json;
using BlazorTest1.Service.Cat.Models;
using static System.Net.WebRequestMethods;

namespace BlazorTest1.Service.Cat
{
    public class CatService : ICatService
    {
        private readonly HttpClient _httpClient;

        public CatService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<CatFact?> GetRandomCatFact()
        {
            return await _httpClient.GetFromJsonAsync<CatFact>(GetBaseUrl() + "fact");
        }

        private string GetBaseUrl()
        {
            return _httpClient.BaseAddress.ToString();
        }
    }
}
