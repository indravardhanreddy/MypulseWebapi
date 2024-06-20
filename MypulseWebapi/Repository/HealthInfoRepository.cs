using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class HealthInfoRepository : IHealthInfoRepository
    {
        private readonly ApplicationDBContext _context;

        public HealthInfoRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HealthInfo>> GetAllAsync()
        {
            return await _context.HealthInfos.Include(h => h.User).ToListAsync();
        }

        public async Task<HealthInfo> GetByIdAsync(string id)
        {
            return await _context.HealthInfos.Include(h => h.User).FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<HealthInfo> GetByUserIdAsync(string userId)
        {
            return await _context.HealthInfos.Include(h => h.User).FirstOrDefaultAsync(h => h.UserId == userId);
        }

        public async Task AddAsync(HealthInfo healthInfo)
        {
            _context.HealthInfos.Add(healthInfo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(HealthInfo healthInfo)
        {
            _context.HealthInfos.Update(healthInfo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var healthInfo = await _context.HealthInfos.FindAsync(id);
            if (healthInfo != null)
            {
                _context.HealthInfos.Remove(healthInfo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.HealthInfos.AnyAsync(e => e.Id == id);
        }
    }
}
