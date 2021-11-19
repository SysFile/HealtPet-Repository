using health.models;
using health.models.menu;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace health.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<User> Usuarios { get; set; }
        public DbSet<Menu> Menu { get; set; }

        internal void Query(string v)
        {
            throw new NotImplementedException();
        }
    }
}
