using System;

namespace Infracciones.Persistencia.Entity
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public string PerfilNombre { get; set; }
        public int UsuarioIdAlta { get; set; }
        public int? UsuarioIdBaja { get; set; }
        public bool IsActivo { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeBaja { get; set; }
    }
}
