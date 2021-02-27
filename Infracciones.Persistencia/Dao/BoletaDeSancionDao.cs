using Infracciones.Persistencia.Entity;
using System;
using System.Data.SqlClient;

namespace Infracciones.Persistencia.Dao
{
    public class BoletaDeSancionDao
    {
        public static int Add(BoletaDeSancionEntity entity)
        {
            try
            {
                string query;

                query = "";
                using(var db = new SqlConnection())
                {
                    entity.Id = db.Query<int>(query);
                }

                return entity.Id
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
