using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infracciones.Dto
{
    [Description("Boleta de sanción")]
    public class BoletaDeSancion
    {
        [Range(0,int.MaxValue)]
        public int Id { get; set; }
        [DisplayName("Numero de licencia")]
        public string NumeroDeLicencia { get; set; }
        public string Placa { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string NombreDelconductor { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Coordenadas { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        [Required]
        public int RelgamentoId { get; set; }
    }
}