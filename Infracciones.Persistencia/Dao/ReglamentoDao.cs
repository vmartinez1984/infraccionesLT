using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{
    public class ReglamentoDao
    {
        public static int Add(ReglamentoEntity entity)
        {
            try
            {
                string query;

                query = "";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity.Id = db.Query<int>(query).FirstOrDefault();
                }

                return entity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ReglamentoEntity Get(int id)
        {
            try
            {
                string query;
                ReglamentoEntity entity;

                query = "";

                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity = db.Query<ReglamentoEntity>(query).FirstOrDefault();
                }

                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ReglamentoEntity> GetAll()
        {
            try
            {
                List<ReglamentoEntity> entities;
                string query;

                query = "";
                using (var db = new MySqlConnection())
                {
                    entities = db.Query<ReglamentoEntity>(query).ToList();
                }

                return entities;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(int id)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
