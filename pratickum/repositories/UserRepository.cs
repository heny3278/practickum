
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.repositories
{
    public class UserRepository : IDataRepository<User>
    {
        Icontext _context;
        public UserRepository(Icontext context)
        {
            _context = context;
        }
        public async Task<User> Add(User entity)
        {
            EntityEntry<User> newUser = _context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users.SingleAsync(a => a.Id == id);
        }
    }
}
