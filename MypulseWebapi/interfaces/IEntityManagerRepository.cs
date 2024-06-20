using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.interfaces
{
    public interface IEntityManagerRepository
    {
        Task<IEnumerable<EntityManager>> GetAllAsync(); // Method to get all hospitals
        Task<EntityManager> GetByIdAsync(string id); // Method to get a single hospital by ID
        Task AddAsync(EntityManager hospital); // Method to add a new hospital
        Task UpdateAsync(EntityManager hospital); // Method to update an existing hospital
        Task DeleteAsync(string id); // Method to delete a hospital by ID
        Task<bool> Exists(string id); // Method to check if a hospital exists by ID
    }
}
