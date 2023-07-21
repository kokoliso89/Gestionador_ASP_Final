namespace LeagueMaster.Models
{
    public class Partidos
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string? Estadio { get; set; }
        public string? Resultado { get; set; }
        public ICollection<Equipos>? Equipos { get; set; }
        public ICollection<Calendario>? Calendarios { get; set; }
        public ICollection<Estadisticas_Partidos>? Estadisticas_Partido { get; set; }

    }
}
