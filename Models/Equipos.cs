namespace LeagueMaster.Models
{
    public class Equipos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Entrenador { get; set; }
        public string? Ciudad { get; set; }
        public bool Activo { get; set; }
        public string? Pais { get; set; }
        public ICollection<Jugadores>? Jugadores { get; set; }
        public ICollection<Partidos>? Partidos { get; set; }
        public ICollection<Rol>? roles { get; set; }
        public ICollection<Calendario>? calendario { get; set; }


    }
}
