using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;

namespace MypulseWebapi.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly ApplicationDBContext _context;

        public ManagerRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Manager>> GetAllAsync()
        {
            return await _context.Managers.ToListAsync();
        }

        public async Task<Manager> GetByIdAsync(string id)
        {
            return await _context.Managers
                              .Include(d => d.ChatSessions) 
                              .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task AddAsync(Manager manager)
        {
            _context.Managers.Add(manager);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Manager manager)
        {
            _context.Entry(manager).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var manager = await _context.Managers.FindAsync(id);
            if (manager != null)
            {
                _context.Managers.Remove(manager);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Managers.AnyAsync(e => e.Id == id);
        }
    }

}
