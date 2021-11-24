using health.models;
using health.models.citas;
using health.models.ciudades;
using health.models.menu;
using health.models.paises;
using health.models.PermisosUser;
using health.models.Pets;
using health.models.raza;
using health.models.tipoDocumento;
using health.models.TiposUsuario;
using health.models.veterinaria;
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
        public DbSet<Pets> Mascotas { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<PermisosUsuario> PermisosUsuario { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Raza> Raza { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Veterinarias> Veterinarias { get; set; }
        public DbSet<Citas> Citas { get; set; }


        internal void Query(string v)
        {
            throw new NotImplementedException();
        }
    }
}
