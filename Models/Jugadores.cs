using System.ComponentModel.DataAnnotations;

namespace LeagueMaster.Models
{
    public class Jugadores
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public string? Posicion { get; set; }
        public int Numero { get; set; }
        public bool Altura { get; set; }
        public string? Equipo { get; set; }
        ICollection<Equipos>? Equipos { get; set; }
        ICollection<Partidos>? Partidos { get; set; }

        ICollection<Estadisticas_Jugadores>? Estadisticas_Jugadores { get; set; }

        ICollection<Calendario>? Calendario { get; set; }


    }
}
