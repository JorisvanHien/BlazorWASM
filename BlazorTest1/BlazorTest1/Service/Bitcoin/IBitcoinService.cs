using BlazorTest1.Service.Bitcoin.Models;

namespace BlazorTest1.Service.Bitcoin
{
    public interface IBitcoinService
    {
        Task<BitcoinPrice?> GetEuroResult();
    }
}
