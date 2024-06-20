using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllAsync();
        Task<Location> GetByIdAsync(string id);
        Task AddAsync(Location location);
        Task UpdateAsync(Location location);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);
    }
}
