using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly ApplicationDBContext _context;

        public ConfigurationRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Configuration>> GetAllAsync()
        {
            return await _context.Configurations.ToListAsync();
        }

        public async Task<Configuration> GetByIdAsync(string id)
        {
            return await _context.Configurations.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(Configuration configuration)
        {
            _context.Configurations.Add(configuration);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Configuration configuration)
        {
            _context.Configurations.Update(configuration);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var configuration = await _context.Configurations.FindAsync(id);
            if (configuration != null)
            {
                _context.Configurations.Remove(configuration);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Configurations.AnyAsync(e => e.Id == id);
        }
    }
}
