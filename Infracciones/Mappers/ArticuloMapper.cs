using AutoMapper;
using Infracciones.Dto;
using Infracciones.Persistencia.Entity;
using System.Collections.Generic;
namespace Infracciones.Mappers
{
    internal class ArticuloMapper
    {
        internal static List<Articulo> GetAll(List<ArticuloEntity> entities)
        {
            IMapper mapper;
            List<Articulo> lista;

            mapper = GetMapperEntityToItem();
            lista = mapper.Map<List<Articulo>>(entities);

            return lista;
        }

        internal static ArticuloEntity Get(Articulo item)
        {
            IMapper mapper;
            ArticuloEntity entity;

            mapper = GetMapperDtoToEntity();
            entity = mapper.Map<ArticuloEntity>(item);

            return entity;
        }

        private static IMapper GetMapperEntityToDto()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<ArticuloEntity, Articulo>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }

        private static IMapper GetMapperEntityToItem()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<ArticuloEntity, Articulo>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }

        internal static Articulo Get(ArticuloEntity entity)
        {
            IMapper mapper;
            Articulo item;

            mapper = GetMapperEntityToDto();
            item = mapper.Map<Articulo>(entity);

            return item;
        }

        private static IMapper GetMapperDtoToEntity()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<Articulo, ArticuloEntity>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }
    }
}
