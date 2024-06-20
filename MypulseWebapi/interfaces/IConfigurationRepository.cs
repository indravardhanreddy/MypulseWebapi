using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface IConfigurationRepository
    {
        Task<IEnumerable<Configuration>> GetAllAsync();
        Task<Configuration> GetByIdAsync(string id);
        Task AddAsync(Configuration configuration);
        Task UpdateAsync(Configuration configuration);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);

    }
}
