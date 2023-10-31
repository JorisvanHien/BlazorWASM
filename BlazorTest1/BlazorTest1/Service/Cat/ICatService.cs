using BlazorTest1.Service.Cat.Models;

namespace BlazorTest1.Service.Cat
{
    public interface ICatService
    {

        public Task<CatFact?> GetRandomCatFact();
    }
}
