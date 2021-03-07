using Infracciones.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infracciones.BusinessLayer
{
   public class UsuarioBl
    {
        public static Usuario Get(string folio)
        {
            try
            {
                Usuario usuario;

                usuario = new Usuario();

                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
