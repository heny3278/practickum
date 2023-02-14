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
    public class ChildRepository : IDataRepository<Child>
    {
        Icontext _context;
        public ChildRepository(Icontext context)
        {
            _context = context;
        }

        public async Task<Child> Add(Child entity)
        {
            EntityEntry<Child> newChild = _context.Children.Add(entity);
            await _context.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task<List<Child>> GetAll()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetById(int id)
        {
            return await _context.Children.FindAsync(id);
        }
    }
}
