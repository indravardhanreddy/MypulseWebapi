using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;

namespace MypulseWebapi.Repository
{
    public class EntityManagerRepository : IEntityManagerRepository
    {
        private readonly ApplicationDBContext _context;

        public EntityManagerRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EntityManager>> GetAllAsync()
        {
            return await _context.EntityManagers.ToListAsync();
        }

        public async Task<EntityManager> GetByIdAsync(string id)
        {
            return await _context.EntityManagers
                              .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task AddAsync(EntityManager entitymanager)
        {
            _context.EntityManagers.Add(entitymanager);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(EntityManager entitymanager)
        {
            _context.Entry(entitymanager).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var entitymanager = await _context.EntityManagers.FindAsync(id);
            if (entitymanager != null)
            {
                _context.EntityManagers.Remove(entitymanager);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.EntityManagers.AnyAsync(e => e.Id == id);
        }
    }

}
