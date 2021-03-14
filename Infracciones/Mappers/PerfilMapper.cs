using AutoMapper;
using Infracciones.Dto;
using Infracciones.Persistencia.Entity;
using System.Collections.Generic;

namespace Infracciones.Mappers
{
    internal class PerfilMapper
    {
        public static List<Perfil> GetAll(List<PerfilEntity> entities)
        {
            IMapper mapper;
            List<Perfil> lista;

            mapper = GetMapperEntityToItem();
            lista = mapper.Map<List<Perfil>>(entities);

            return lista;
        }

        private static IMapper GetMapperEntityToItem()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<PerfilEntity, Perfil>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }
    }
}