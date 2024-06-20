using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MypulseWebapi.Models;

namespace MypulseWebapi.interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<T> GetAsync<T>(Expression<Func<User, bool>> filter, Expression<Func<User, T>> selector);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);
    }
}
