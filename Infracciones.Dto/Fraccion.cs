using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infracciones.Dto
{
    public class Fraccion
    {
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public int ArticuloId { get; set; }
        public bool IsActivo { get; set; }

        [Required]
        [DisplayName("Descripción")]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

        [Required]
        public int UsuarioIdAlta { get; set; }

        public int? UsuarioIdBaja { get; set; }

        [DisplayName("Fecha de registro")]
        public DateTime FechaDeRegistro { get; set; }

        [DisplayName("Fecha de baja")]
        public DateTime? FechaDeBaja { get; set; }
    }
}
