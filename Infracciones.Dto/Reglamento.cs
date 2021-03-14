using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infracciones.Dto
{
    public class Reglamento
    {
        public int Id { get; internal set; }

        [Required]
        [Range(1,50)]
        public int Multa { get; set; }

        [Required]
        public int UsuarioIdAlta { get; set; }

        public int? UsuarioIdBaja { get; set; }

        [DisplayName("¿Tiene descuento?")]
        public bool IsDescuento { get; set; }

        [DisplayName("¿Amerita deposito?")]
        public bool IsDeposito { get; set; }

        [DisplayName("¿Está activo?")]
        public bool Isactivo { get; set; }

        [Required]
        [DisplayName("Artículo")]
        [MaxLength(500)]
        public string Articulo { get; set; }

        [Required]
        [DisplayName("Fracción")]
        [MaxLength(500)]
        public string Fraccion { get; set; }

        [Required]
        [MaxLength(500)]
        public string Motivo { get; set; }

        [DisplayName("Fecha de registro")]
        public DateTime FechaDeRegistro { get; set; }

        [DisplayName("Fecha de baja")]
        public DateTime FechaDeBaja { get; set; }
    }
}