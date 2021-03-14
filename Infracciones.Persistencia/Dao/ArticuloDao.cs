using Dapper;
using Infracciones.Persistencia.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infracciones.Persistencia.Dao
{
    public class ArticuloDao
    {
        public static int Add(ArticuloEntity entity)
        {
            try
            {
                string query;

                query = $@"INSERT INTO articulo
                (
                numero,           
                descripcion,
                usuario_id_alta,     
                is_activo,     
                fecha_de_registro                   
                )
                VALUES
                (
                @Numero, 
                @Descripcion,
                @UsuarioIdAlta,
                1,
                NOW()
                );
                SELECT LAST_INSERT_ID(); 
                ";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity.Id = db.Query<int>(query, new
                    {
                        Numero = entity.Numero,
                        Descripcion = entity.Descripcion,
                        UsuarioIdAlta = entity.UsuarioIdAlta
                    }).FirstOrDefault();
                }

                return entity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(int id, int usuarioIdBaja)
        {
            try
            {
                string query;

                query = $@"
                UPDATE articulo
                SET 
                usuario_id_baja     = @UsuarioIdBaja,
                is_activo           = 0,
                fecha_de_baja       = NOW()
                WHERE id = @Id";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    db.Query(query, new
                    {
                        UsuarioIdBaja = usuarioIdBaja,
                        Id = id
                    }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static ArticuloEntity Get(int id)
        {
            try
            {
                string query;
                ArticuloEntity entity;

                query = $@"
                SELECT 
                id                  Id,
                numero              Numero,
                descripcion         Descripcion,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM articulo                
                WHERE articulo.id = {id}
                LIMIT 1";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity = db.Query<ArticuloEntity>(query).FirstOrDefault();
                }

                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ArticuloEntity> GetAll(bool isActivo = true)
        {
            try
            {
                List<ArticuloEntity> entities;
                string query;
                int is_activo;

                is_activo = isActivo ? 1 : 0;
                query = $@"
                SELECT 
                 id                  Id,
                numero              Numero,
                descripcion         Descripcion,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM articulo
                WHERE articulo.is_activo = {is_activo}
                ";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entities = db.Query<ArticuloEntity>(query).ToList();
                }

                return entities;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Update(ArticuloEntity entity)
        {
            try
            {
                string query;

                query = $@"
                UPDATE articulo
                SET                                  
                descripcion     = @Descripcion              
                WHERE id        = @Id";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    db.Query(query, new
                    {
                        Descripcion = entity.Descripcion,
                        Id = entity.Id
                    }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
