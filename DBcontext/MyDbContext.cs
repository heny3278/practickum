using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using repositories.entities;
using repositories;

namespace DBcontext
{
    public class MyDbContext: DbContext, Icontext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\הני איתן\\Documents\\practuckumHenyEitan.mdf\";Integrated Security=True;Connect Timeout=30");
            //optionsBuilder.UseSqlServer(@"server=(localDb)\msSQlLocalDb;database=PratickumHenyEitan;Trusted_Connection=True");

        }
        protected override void OnModelCreating(ModelBuilder modelbulider)
        {
            base.OnModelCreating(modelbulider);
        }

    }

    
}
