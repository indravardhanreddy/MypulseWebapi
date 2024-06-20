using System.Collections.Generic;
using System.Threading.Tasks;
using MypulseWebapi.Models;

namespace MypulseWebapi.interfaces
{
    public interface IAvailabilityRepository
    {
        Task<IEnumerable<Availability>> GetAllAsync();
        Task<Availability> GetByIdAsync(string id);
        Task AddAsync(Availability appointment);
        Task UpdateAsync(Availability appointment);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);
    }
}
