using AutoMapper;
using Infracciones.Dto;
using Infracciones.Persistencia.Entity;
using System.Collections.Generic;

namespace Infracciones.Mappers
{
    internal class ReglamentoMapper
    {
        internal static List<Reglamento> GetAll(List<ReglamentoEntity> entities)
        {
            IMapper mapper;
            List<Reglamento> lista;

            mapper = GetMapperEntityToItem();
            lista = mapper.Map<List<Reglamento>>(entities);

            return lista;
        }

        internal static ReglamentoEntity Get(Reglamento item)
        {
            IMapper mapper;
            ReglamentoEntity entity;

            mapper = GetMapperDtoToEntity();
            entity = mapper.Map<ReglamentoEntity>(item);

            return entity;
        }

        private static IMapper GetMapperEntityToDto()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<ReglamentoEntity, Reglamento>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }

        private static IMapper GetMapperEntityToItem()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<ReglamentoEntity, Reglamento>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }

        internal static Reglamento Get(ReglamentoEntity entity)
        {
            IMapper mapper;
            Reglamento item;

            mapper = GetMapperEntityToDto();
            item = mapper.Map<Reglamento>(entity);

            return item;
        }

        private static IMapper GetMapperDtoToEntity()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<Reglamento, ReglamentoEntity>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }
    }
}
