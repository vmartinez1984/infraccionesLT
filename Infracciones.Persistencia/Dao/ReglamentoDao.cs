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

                query = $@"
                INSERT INTO reglamento
                (
                    multa,
                    is_descuento,        
                    is_deposito,         
                    usuario_id_alta,       
                    articulo,            
                    fraccion,            
                    motivo,              
                    fecha_de_registro
                )
                VALUES
                (
                    @Multa,
                    @IsDescuento,
                    @IsDeposito,
                    @UsuarioIdAlta,                    
                    @Articulo,
                    @Fraccion,   
                    @Motivo,
                    NOW()
                );
                SELECT LAST_INSERT_ID(); 
                ";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    entity.Id = db.Query<int>(query, new
                    {
                        Multa = entity.Multa,
                        IsDescuento = entity.IsDescuento,
                        IsDeposito = entity.IsDeposito,
                        UsuarioIdAlta = entity.UsuarioIdAlta,
                        Articulo = entity.Articulo ,
                        Fraccion = entity.Fraccion,
                        Motivo = entity.Motivo
                    }).FirstOrDefault();
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

                query = $@"
                SELECT 
                id,
                multa               Multa,
                is_descuento        IsDescuento,
                is_deposito         IsDeposito,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                articulo            Artivo,
                fraccion            Fraccion,
                motivo              Motivo,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM reglamento
                WHERE id = {id}
                LIMIT 1;";
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

        public static List<ReglamentoEntity> GetAll(bool isActivo = true)
        {
            try
            {
                List<ReglamentoEntity> entities;
                string query;
                int is_activo;

                is_activo = isActivo ? 1 : 0;

                query = $@"
                SELECT 
                id,
                multa,
                is_descuento        IsDescuento,
                is_deposito         IsDeposito,
                usuario_id_alta     UsuarioIdAlta,
                usuario_id_baja     UsuarioIdBaja,
                articulo,
                fraccion,
                motivo,
                fecha_de_registro   FechaDeRegistro,
                fecha_de_baja       FechaDeBaja
                FROM reglamento
                WHERE is_activo = {is_activo}
                ";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
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

        public static void Delete(int id, int usuarioIdBaja)
        {
            try
            {
                string query;

                query = $@"
                UPDATE reglamento
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

        public static void Update(ReglamentoEntity entity)
        {
            try
            {
                string query;

                query = $@"
                UPDATE usuario
                SET 
                multa               @Multa,
                is_descuento        @IsDescuento,
                is_deposito         @IsDeposito,
                usuario_id_alta     @UsuarioIdAlta,
                usuario_id_baja     @UsuarioIdBaja,
                articulo            @Artivo,
                fraccion            @Fraccion,
                motivo              @Motivo                                
                WHERE id = @Id";
                using (var db = new MySqlConnection(Conexion.CadenaDeConexion))
                {
                    db.Query(query, new
                    {
                        Multa = entity.Multa,
                        IsDescuento = entity.IsDescuento,
                        IsDeposito = entity.IsDeposito,
                        UsuarioIdAlta = entity.UsuarioIdAlta,
                        Articulo = entity.Articulo,
                        Fraccion = entity.Fraccion,
                        Motivo = entity.Motivo,
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
