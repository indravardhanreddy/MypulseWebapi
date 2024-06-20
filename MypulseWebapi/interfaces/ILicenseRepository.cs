using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface ILicenseRepository
    {
        Task<IEnumerable<License>> GetAllAsync();
        Task<License> GetByIdAsync(string id);
        Task AddAsync(License license);
        Task UpdateAsync(License license);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);
    }
}
