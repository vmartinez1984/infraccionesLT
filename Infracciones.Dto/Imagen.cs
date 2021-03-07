using System;

namespace Infracciones.Dto
{
    public class Imagen
    {
        public DateTime FechaDeRegistro { get; set; }
        public string ImagenEnBase64 { get; set; }
        public int BoletaDeSancionId { get; set; }
        public int Id { get; set; }
    }
}
