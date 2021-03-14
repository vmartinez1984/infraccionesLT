using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infracciones.Dto
{
    public  class Usuario
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Perfil")]
        public int PerfilId { get; set; }

        
        [DisplayName("Perfil")]
        public string PerfilNombre { get; set; }

        [Required]
        public int UsuarioIdAlta { get; set; }

        public int? UsuarioIdBaja { get; set; }

        [DisplayName("¿Esta activo?")]
        public bool IsActivo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Paterno { get; set; }

        [MaxLength(50)]
        public string Materno { get; set; }

        [Required]
        [DisplayName("Nombre de usuario")]
        [MaxLength(20)]
        public string NombreDeUsuario { get; set; }

        [Required]
        [DisplayName("Contraseña")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        [DisplayName("Confirmar contraseña")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        [Compare("Contrasenia")]
        public string ContraseniaConfirmacion { get; set; }

        [MaxLength(50)]
        public string Observaciones { get; set; }

        [DisplayName("Fecha de registro")]
        public DateTime FechaDeRegistro { get; set; }

        [DisplayName("Fecha de baja")]
        public DateTime? FechaDeBaja { get; set; }
    }
}