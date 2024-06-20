using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        private readonly ApplicationDBContext _context;

        public AvailabilityRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Availability>> GetAllAsync()
        {
            return await _context.Availabilities
                .ToListAsync();
        }

        public async Task<Availability> GetByIdAsync(string id)
        {
            return await _context.Availabilities
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAsync(Availability availability)
        {
            _context.Availabilities.Add(availability);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Availability availability)
        {
            _context.Availabilities.Update(availability);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var availability = await _context.Availabilities.FindAsync(id);
            if (availability != null)
            {
                _context.Availabilities.Remove(availability);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Availabilities.AnyAsync(a => a.Id == id);
        }
    }
}
