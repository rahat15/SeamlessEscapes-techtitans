using Microsoft.EntityFrameworkCore;
using SeamlessEscapesBlazor.Data;
using SeamlessEscapesBlazor.Models;
using System.Threading.Tasks;

namespace SeamlessEscapesBlazor.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task RegisterUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsUsernameTaken(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username);
        }

        public async Task<bool> IsEmailTaken(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }
    }
}