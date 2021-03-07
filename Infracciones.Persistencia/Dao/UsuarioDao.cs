using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{
   public class UsuarioDao
    {
        public static int Add(UsuarioEntity entity)
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

        public static UsuarioEntity Get(int id)
        {
            try
            {
                string query;
                UsuarioEntity entity;

                query = "";

                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity = db.Query<UsuarioEntity>(query).FirstOrDefault();
                }

                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<UsuarioEntity> GetAll()
        {
            try
            {
                List<UsuarioEntity> entities;
                string query;

                query = "";
                using (var db = new MySqlConnection())
                {
                    entities = db.Query<UsuarioEntity>(query).ToList();
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
