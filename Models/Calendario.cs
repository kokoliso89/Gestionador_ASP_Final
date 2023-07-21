namespace LeagueMaster.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string? Estadio { get; set; }
        public string? Equipo_Local { get; set; }
        public string? Equipo_Visitante { get; set; }
        public string? Jornada { get; set; }
        public string? Competicion { get; set; }
        public string? Notas_Adicionales { get; set; }
        public string? Arbitro_1 { get; set; }
        public string? Arbitro_2 { get; set; }
        public string? Mesa_principal { get; set; }
        public ICollection<Partidos>? Partidos { get; set; }
        public ICollection<Equipos>? Equipos { get; set; }

    }
}
