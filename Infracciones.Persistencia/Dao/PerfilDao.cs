using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{
public    class PerfilDao
    {
        public List<PerfilEntity> GetAll()
        {
            try
            {
                List<PerfilEntity> entities;
                string query;

                query = "";
                using (var db = new MySqlConnection())
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
