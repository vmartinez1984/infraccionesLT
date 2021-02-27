using Infracciones.Dto;
using Infracciones.Persistencia.Dao;
using Infracciones.Persistencia.Entity;
using System;

namespace Infracciones.BusinessLayer
{
    public class BoletaDeSancionBl
    {
        public static int Add(BoletaDeSancion boletaDeSancion)
        {
            try
            {
                BoletaDeSancionEntity entity;

                entity = GetEntity(boletaDeSancion);
                entity.Id = BoletaDeSancionDao.Add(entity);

                return entity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static BoletaDeSancionEntity GetEntity(BoletaDeSancion boletaDeSancion)
        {
            throw new NotImplementedException();
        }
    }
}
