using LeagueMaster.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeagueMaster.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Jugadores> Jugadores { get; set; }
        public DbSet<Equipos> Equipos { get; set; }
        public DbSet<Partidos> Partidos { get; set; }
        public DbSet<Calendario> Calendario { get; set; }
        public DbSet<Estadisticas_Jugadores> Estadisticas_Jugadores { get; set; }
        public DbSet<Estadisticas_Partidos> Estadisticas_Partidos { get; set; }
        public DbSet<LeagueMaster.Models.Usuarios> Usuarios { get; set; } = default!;
        public DbSet<LeagueMaster.Models.Rol> Rol { get; set; } = default!;


    }
}