using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper()
        {
            CreateMap<EscolaDTos, Escola>()
                  .ForMember(dest => dest.Nome,opt => opt.MapFrom(src=>src.Nome))
                  .ReverseMap();

            CreateMap<EscolaEdicaoDTo, Escola>().ReverseMap();

        }
    }
}
