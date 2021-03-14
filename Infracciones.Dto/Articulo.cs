using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infracciones.Dto
{
    [DisplayName("Artículo")]
    public class Articulo
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Número de artículo")]
        public int Numero { get; set; }

        [DisplayName("¿Esta activo?")]
        public bool IsActivo { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [Required]        
        [DisplayName("Usuario alta")]
        public int UsuarioIdAlta { get; set; }

        [DisplayName("Usuario baja")]
        public int? UsuarioIdBaja { get; set; }

        [DisplayName("Fecha de registro")]
        public DateTime FechaDeRegistro { get; set; }

        [DisplayName("Fecha de baja")]
        public DateTime? FechaDeBaja { get; set; }
    }
}