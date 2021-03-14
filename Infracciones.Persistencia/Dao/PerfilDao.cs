using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{
    public class PerfilDao
    {
        public static List<PerfilEntity> GetAll()
        {
            try
            {
                List<PerfilEntity> entities;
                string query;

                query = $@"SELECT * FROM perfil;";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entities = db.Query<PerfilEntity>(query).ToList();
                }

                return entities;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}