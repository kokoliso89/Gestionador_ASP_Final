namespace LeagueMaster.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string NivelAcceso { get; set; }
        public ICollection<Usuarios>? Usuarios { get; set; }

    }
}
