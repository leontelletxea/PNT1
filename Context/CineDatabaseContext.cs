using Microsoft.EntityFrameworkCore;
using MVC_basico.Models;

namespace MVC_basico.Context
{
    public class CineDatabaseContext : DbContext
    {
        public CineDatabaseContext()
        {
        }

        public CineDatabaseContext(DbContextOptions<CineDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
    }
}
