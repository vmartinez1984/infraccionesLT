using Infracciones.Dto;
using System;
using System.Collections.Generic;

namespace Infracciones.BusinessLayer
{
    public    class SancionBl
    {
        public static List<Reglamento> GetAll()
        {
            try
            {
                List<Reglamento> lista;

                lista = GetLista();

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Reglamento> GetLista()
        {
            List<Reglamento> lista;

            lista = new List<Reglamento>();

            return lista;
        }
    }
}
