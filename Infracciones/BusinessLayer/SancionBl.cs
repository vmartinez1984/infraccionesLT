using Infracciones.Dto;
using System;
using System.Collections.Generic;

namespace Infracciones.BusinessLayer
{
    public    class SancionBl
    {
        public static List<Sancion> GetAll()
        {
            try
            {
                List<Sancion> lista;

                lista = GetLista();

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Sancion> GetLista()
        {
            List<Sancion> lista;

            lista = new List<Sancion>();

            return lista;
        }
    }
}
