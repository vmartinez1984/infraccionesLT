using Infracciones.Dto;
using Infracciones.Mappers;
using Infracciones.Persistencia.Dao;
using Infracciones.Persistencia.Entity;
using System;
using System.Collections.Generic;

namespace Infracciones.BusinessLayer
{
    public class ReglamentoBl
    {
        public static void Add(Reglamento item)
        {
            try
            {
                ReglamentoEntity entity;

                entity = ReglamentoMapper.Get(item);

                ReglamentoDao.Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(int id, int ReglamentoIdBaja)
        {
            try
            {
                ReglamentoDao.Delete(id, ReglamentoIdBaja);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Reglamento Get(int id)
        {
            Reglamento item;
            ReglamentoEntity entity;

            entity = ReglamentoDao.Get(id);
            item = ReglamentoMapper.Get(entity);

            return item;
        }

        public static List<Reglamento> GetAll(int? id)
        {
            try
            {
                List<Reglamento> lista;
                List<ReglamentoEntity> entities;

                if (id == null)
                    entities = ReglamentoDao.GetAll();
                else
                    entities = ReglamentoDao.GetAll(false);
                lista = ReglamentoMapper.GetAll(entities);

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Update(Reglamento item)
        {
            try
            {
                ReglamentoEntity entity;

                entity = ReglamentoMapper.Get(item);

                ReglamentoDao.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
