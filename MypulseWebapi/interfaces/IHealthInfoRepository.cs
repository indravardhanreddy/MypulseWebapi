using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface IHealthInfoRepository
    {
        Task<IEnumerable<HealthInfo>> GetAllAsync();
        Task<HealthInfo> GetByIdAsync(string id);
        Task<HealthInfo> GetByUserIdAsync(string userId);
        Task AddAsync(HealthInfo healthInfo);
        Task UpdateAsync(HealthInfo healthInfo);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);

    }
}
