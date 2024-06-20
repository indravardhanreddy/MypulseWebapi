using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface IChatSessionRepository
    {
        Task<IEnumerable<ChatSession>> GetAllAsync();
        Task<ChatSession> GetByIdAsync(string id);
        Task AddAsync(ChatSession chatSession);
        Task UpdateAsync(ChatSession chatSession);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);
    }
}
