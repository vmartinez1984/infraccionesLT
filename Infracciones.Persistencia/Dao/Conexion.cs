using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infracciones.Persistencia.Dao
{
    public class Conexion
    {
        public static string CadenaDeConexion { get { return "Server=127.0.0.1;Database=infracciones;Uid=root;Pwd=;"; } }
    }
}
