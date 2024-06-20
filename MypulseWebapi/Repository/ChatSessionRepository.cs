using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Data;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Repository
{
    public class ChatSessionRepository : IChatSessionRepository
    {
        private readonly ApplicationDBContext _context;

        public ChatSessionRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChatSession>> GetAllAsync()
        {
            return await _context.ChatSessions
                .Include(cs => cs.Manager)
                .Include(cs => cs.User)
                .Include(cs => cs.Messages)
                .ToListAsync();
        }

        public async Task<ChatSession> GetByIdAsync(string id)
        {
            return await _context.ChatSessions
                .Include(cs => cs.Manager)
                .Include(cs => cs.User)
                .Include(cs => cs.Messages)
                .FirstOrDefaultAsync(cs => cs.Id == id);
        }

        public async Task AddAsync(ChatSession chatSession)
        {
            _context.ChatSessions.Add(chatSession);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ChatSession chatSession)
        {
            _context.ChatSessions.Update(chatSession);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var chatSession = await _context.ChatSessions.FindAsync(id);
            if (chatSession != null)
            {
                _context.ChatSessions.Remove(chatSession);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.ChatSessions.AnyAsync(cs => cs.Id == id);
        }
    }
}
