using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class LicenseRepository : ILicenseRepository
    {
        private readonly ApplicationDBContext _context;

        public LicenseRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<License>> GetAllAsync()
        {
            return await _context.Licenses.Include(l => l.EntityManager).ToListAsync();
        }

        public async Task<License> GetByIdAsync(string id)
        {
            return await _context.Licenses.Include(l => l.EntityManager).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddAsync(License license)
        {
            _context.Licenses.Add(license);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(License license)
        {
            _context.Licenses.Update(license);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var license = await _context.Licenses.FindAsync(id);
            if (license != null)
            {
                _context.Licenses.Remove(license);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Licenses.AnyAsync(l => l.Id == id);
        }
    }
}
