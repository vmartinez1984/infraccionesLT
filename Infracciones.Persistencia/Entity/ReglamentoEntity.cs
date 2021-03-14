using System;

namespace Infracciones.Persistencia.Entity
{
    public class ReglamentoEntity
    {
        public int Id { get; internal set; }
        public int Multa { get; set; }
        public int UsuarioIdAlta { get; set; }
        public int UsuarioIdBaja { get; set; }
        public bool IsDescuento { get; set; }
        public bool IsDeposito { get; set; }
        public bool Isactivo { get; set; }
        public string Articulo { get; set; }
        public string Fraccion { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeBaja { get; set; }
    }
}