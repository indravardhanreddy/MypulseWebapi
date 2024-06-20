using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.Users
                                 .Include(u => u.HealthInfo)
                                 .Include(u => u.EntityManagers)
                                 .Include(u => u.Managers)
                                 .Include(u => u.Appointments)
                                 .Include(u => u.Notifications)
                                 .Include(u => u.ChatSessions)
                                 .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<T> GetAsync<T>(Expression<Func<User, bool>> filter, Expression<Func<User, T>> selector)
        {
            return await _context.Users
                                 .Where(filter)
                                 .Select(selector)
                                 .FirstOrDefaultAsync();
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
    }
}
