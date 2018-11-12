using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using RefitSample.Models;

namespace RefitSample.Services
{
    public interface IMakeUpApi
    {
        [Post("/api/v1/products.json?brand=maybelline")]
        Task<List<MakeDown>> GetMakeUps();
    }
}
