using Infracciones.Dto;
using Infracciones.Mappers;
using Infracciones.Persistencia.Dao;
using Infracciones.Persistencia.Entity;
using System;
using System.Collections.Generic;

namespace Infracciones.BusinessLayer
{
    public class UsuarioBl
    {
        public static List<Usuario> GetAll(int? id)
        {
            try
            {
                List<Usuario> lista;
                List<UsuarioEntity> entities;

                if (id == null)
                    entities = UsuarioDao.GetAll();
                else
                    entities = UsuarioDao.GetAll(false);
                lista = UsuarioMapper.GetAll(entities);

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Usuario> GetAllEliminados()
        {
            try
            {
                List<Usuario> lista;
                List<UsuarioEntity> entities;

                entities = UsuarioDao.GetAll(false);
                lista = UsuarioMapper.GetAll(entities);

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Usuario Get(int id)
        {
            Usuario item;
            UsuarioEntity entity;

            entity = UsuarioDao.Get(id);
            item = UsuarioMapper.Get(entity);

            return item;
        }

        public static Usuario Get(string usuario, string contrasenia)
        {
            try
            {
                Usuario usuario1;
                UsuarioEntity usuarioEntity;

                usuarioEntity = UsuarioDao.Get(usuario, contrasenia);
                usuario1 = UsuarioMapper.Get(usuarioEntity);

                return usuario1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Add(Usuario item)
        {
            try
            {
                UsuarioEntity entity;

                entity = UsuarioMapper.Get(item);

                UsuarioDao.Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Update(Usuario item)
        {
            try
            {
                UsuarioEntity entity;

                entity = UsuarioMapper.Get(item);

                UsuarioDao.Update(entity);
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
                UsuarioDao.Delete(id, usuarioIdBaja);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Perfil> GetAllPerfiles()
        {
            try
            {
                List<Perfil> lista;
                List<PerfilEntity> entities;

                entities = PerfilDao.GetAll();
                lista = PerfilMapper.GetAll(entities);

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
