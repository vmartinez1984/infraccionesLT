using System;

namespace Infracciones.Persistencia.Entity
{
    public class BoletaDeSancionEntity
    {
        public int Id { get; set; }
        public string NumeroDeLicencia { get; set; }
        public string Placa { get; set; }
        public string NombreDelconductor { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Coordenadas { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int SancionId { get; set; }
    }
}