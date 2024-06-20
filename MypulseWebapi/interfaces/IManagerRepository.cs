using MypulseWebapi.Models;

namespace MypulseWebapi.interfaces
{
    public interface IManagerRepository
    {
        Task<IEnumerable<Manager>> GetAllAsync();     // Get all managers
        Task<Manager> GetByIdAsync(string id);        // Get a single manager by ID
        Task AddAsync(Manager manager);                // Add a new manager
        Task UpdateAsync(Manager manager);             // Update an existing manager
        Task DeleteAsync(string id);                 // Delete a manager by ID
        Task<bool> Exists(string id);                // Check if a manager exists by ID
    }
}