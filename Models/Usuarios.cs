namespace LeagueMaster.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Edad { get; set; }
        public string? Genero { get; set; }
        public string? Correo { get; set; }
        public string? Contrasena { get; set; }
        public ICollection<Rol>? Roles { get; set; }

    }
}
