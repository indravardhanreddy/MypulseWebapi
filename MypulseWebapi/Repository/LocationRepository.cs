using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDBContext _context;

        public LocationRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Location> GetByIdAsync(string id)
        {
            return await _context.Locations.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddAsync(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Location location)
        {
            _context.Locations.Update(location);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location != null)
            {
                _context.Locations.Remove(location);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Locations.AnyAsync(l => l.Id == id);
        }
    }
}
