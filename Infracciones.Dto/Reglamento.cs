﻿namespace Infracciones.Dto
{
    public class Reglamento
    {
        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Fraccion { get; set; }
        public string Motivo { get; set; }
        public int Multa { get; set; }
    }
}