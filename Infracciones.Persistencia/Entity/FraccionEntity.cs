using System;

namespace Infracciones.Persistencia.Entity
{
    public class FraccionEntity
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int ArticuloId { get; set; }
        public bool IsActivo { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioIdAlta { get; set; }
        public int? UsuarioIdBaja { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeBaja { get; set; }
    }
}
