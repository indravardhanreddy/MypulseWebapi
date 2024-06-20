using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface IMessageRepository
    {
        Task<IEnumerable<Message>> GetAllAsync();
        Task<Message> GetByIdAsync(string id);
        Task<IEnumerable<Message>> GetByChatSessionIdAsync(string chatSessionId);
        Task AddAsync(Message message);
        Task UpdateAsync(Message message);
        Task DeleteAsync(string id);
    }
}
