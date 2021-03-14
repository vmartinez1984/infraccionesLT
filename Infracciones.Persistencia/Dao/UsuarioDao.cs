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

                query = $@"INSERT INTO usuario
                (
                perfil_id,           
                usuario_id_alta,
                is_activo,     
                nombre,              
                paterno,             
                materno,             
                nombre_de_usuario,
                contrasenia,   
                observaciones,       
                fecha_de_registro                   
                )
                VALUES
                (
                @PerfilId,
                @UsuarioIdAlta,                
                1,
                @Nombre, 
                @Paterno,
                @Materno,
                @NombreDeUsuario,
                @Contrasenia,
                @Observaciones,
                NOW()
                );
                SELECT LAST_INSERT_ID(); 
                ";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity.Id = db.Query<int>(query, new
                    {
                        PerfilId = entity.PerfilId,
                        UsuarioIdAlta = entity.UsuarioIdAlta,
                        Nombre = entity.Nombre,
                        Paterno = entity.Paterno,
                        Materno = entity.Materno,
                        NombreDeUsuario = entity.NombreDeUsuario,
                        Contrasenia = entity.Contrasenia,
                        Observaciones = entity.Observaciones
                    }).FirstOrDefault();
                }

                return entity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntity Get(string usuario, string contrasenia)
        {
            try
            {
                string query;
                UsuarioEntity entity;

                query = $@"
                SELECT 
                id,
                perfil_id           PerfilId,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                is_activo           IsActivo,
                nombre,
                paterno,
                materno,
                nombre_de_usuario   NombreDeUsuario,
                contrasenia         Contrasenia,
                observaciones,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM usuario
                WHERE nombre_de_usuario = @Usuario AND contrasenia = @Contrasenia
                LIMIT 1
                ";

                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity = db.Query<UsuarioEntity>(query, new {
                        Usuario = usuario,
                        Contrasenia = contrasenia
                    }).FirstOrDefault();
                }

                return entity;
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

                query = $@"
                SELECT 
                usuario.id,
                perfil_id           PerfilId,
                perfil.nombre       PerfilNombre,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                usuario.is_activo   IsActivo,
                usuario.nombre,
                paterno,
                materno,
                nombre_de_usuario   NombreDeUsuario,
                contrasenia         Contrasenia,
                observaciones,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM usuario
                INNER JOIN perfil on perfil.id = usuario.perfil_id
                WHERE usuario.id = {id}
                LIMIT 1
                ";

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

        public static List<UsuarioEntity> GetAll(bool isActivo = true)
        {
            try
            {
                List<UsuarioEntity> entities;
                string query;
                int is_activo;

                is_activo = isActivo ? 1 : 0;
                query = $@"
                SELECT 
                usuario.id,
                perfil_id           PerfilId,
                perfil.nombre       PerfilNombre,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                usuario.is_activo   IsActivo,
                usuario.nombre,
                paterno,
                materno,
                nombre_de_usuario   NombreDeUsuario,
                contrasenia         Contrasenia,
                observaciones,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM usuario
                INNER JOIN perfil on perfil.id = usuario.perfil_id
                WHERE usuario.is_activo = {is_activo}
                ";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
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

        public static void Delete(int id, int usuarioIdBaja)
        {
            try
            {
                string query;

                query = $@"
                UPDATE usuario
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

        public static void Update(UsuarioEntity entity)
        {
            try
            {
                string query;

                query = $@"
                UPDATE usuario
                SET 
                perfil_id           = @PerfilId,                                
                nombre              = @Nombre, 
                paterno             = @Paterno,
                materno             = @Materno,
                nombre_de_usuario   = @NombreDeUsuario,
                contrasenia         = @Contrasenia,
                observaciones       = @Observaciones                
                WHERE id = @Id";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    db.Query(query, new
                    {
                        PerfilId = entity.PerfilId,
                        Nombre = entity.Nombre,
                        Paterno = entity.Paterno,
                        Materno = entity.Materno,
                        NombreDeUsuario = entity.NombreDeUsuario,
                        Contrasenia = entity.Contrasenia,
                        Observaciones = entity.Observaciones,
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