namespace LeagueMaster.Models
{
    public class Estadisticas_Jugadores
    {

        public int Id { get; set; }
        public int Id_Jugador { get; set; }
        public string? Nombre_Jugador { get; set; }
        public int Minutos_Jugados { get; set; }
        public int Tiros_Campo_Intentados { get; set; }
        public int Tiros_Campo_Exitosos { get; set; }
        public decimal Porcentaje_Tiros_Campo { get; set; }
        public int Tiros_3P_Intentados { get; set; }
        public int Tiros_3P_Exitosos { get; set; }
        public decimal Porcentaje_Tiros_3P { get; set; }
        public int Tiros_2P_Intentados { get; set; }
        public int Tiros_2P_Exitosos { get; set; }
        public decimal Porcentaje_Tiros_2P { get; set; }
        public int Tiros_Libres_Intentados { get; set; }
        public int Tiros_Libres_Exitosos { get; set; }
        public decimal Porcentaje_Tiros_Libres { get; set; }
        public int Rebotes_Ofensivos { get; set; }
        public int Rebotes_Densivos { get; set; }
        public int Total_Rebotes { get; set; }
        public int Asistencias { get; set; }
        public int Robos { get; set; }
        public int Bloqueos { get; set; }
        public int Perdidas { get; set; }
        public ICollection<Jugadores>? Jugadores { get; set; }
        public ICollection<Equipos>? Equipos { get; set; }


    }
}
