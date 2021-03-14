using AutoMapper;
using Infracciones.Dto;
using Infracciones.Persistencia.Entity;
using System.Collections.Generic;

namespace Infracciones.Mappers
{
    public class UsuarioMapper
    {
        public static List<Usuario> GetAll(List<UsuarioEntity> entities)
        {
            IMapper mapper;
            List<Usuario> lista;

            mapper = GetMapperEntityToItem();
            lista = mapper.Map<List<Usuario>>(entities);

            return lista;
        }

        public static UsuarioEntity Get(Usuario item)
        {
            IMapper mapper;
            UsuarioEntity entity;

            mapper = GetMapperDtoToEntity();
            entity = mapper.Map<UsuarioEntity>(item);

            return entity;
        }

        private static IMapper GetMapperEntityToDto()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<UsuarioEntity, Usuario>()
                 .ForMember(dest => dest.ContraseniaConfirmacion, opt => opt.MapFrom(src => src.Contrasenia))
            );
            Mapper = Config.CreateMapper();

            return Mapper;
        }

        private static IMapper GetMapperEntityToItem()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<UsuarioEntity, Usuario>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }

        internal static Usuario Get(UsuarioEntity entity)
        {
            IMapper mapper;
            Usuario item;

            mapper = GetMapperEntityToDto();
            item = mapper.Map<Usuario>(entity);

            return item;
        }

        private static IMapper GetMapperDtoToEntity()
        {
            IMapper Mapper;
            MapperConfiguration Config;
            Config = new MapperConfiguration(cfg => cfg.CreateMap<Usuario, UsuarioEntity>());
            Mapper = Config.CreateMapper();

            return Mapper;
        }
    }
}
