using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{
public    class TipoDeImagenDao
    {
        public List<TipoDeImagenEntity> GetAll()
        {
            try
            {
                List<TipoDeImagenEntity> entities;
                string query;

                query = "";
                using (var db = new MySqlConnection())
                {
                    entities = db.Query<TipoDeImagenEntity>(query).ToList();
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
