using System.Collections.Generic;
using System.Threading.Tasks;
using MypulseWebapi.Models;

namespace MypulseWebapi.interfaces
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetAllAsync();
        Task<Appointment> GetByIdAsync(string id);
        Task AddAsync(Appointment appointment);
        Task UpdateAsync(Appointment appointment);
        Task DeleteAsync(string id);
        Task<bool> Exists(string id);
    }
}
