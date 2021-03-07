using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{

    public class EstatusDeLaBoletaDeSancionDao
    {
        public List<EstatusDeLaBoletaDeSancionEntity> GetAll()
        {
            try
            {
                List<EstatusDeLaBoletaDeSancionEntity> entities;
                string query;

                query = "";
                using (var db = new MySqlConnection())
                {
                    entities = db.Query<EstatusDeLaBoletaDeSancionEntity>(query).ToList();
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
