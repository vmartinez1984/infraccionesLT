using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infracciones.Dto
{
    public class UsuarioDeInicioDeSesion
    {
        [Required]
        [MaxLength(20)]
        [DisplayName("Usuario")]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

       public string Mensaje { get; set; }
    }
}