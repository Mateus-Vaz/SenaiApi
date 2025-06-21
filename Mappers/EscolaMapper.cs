using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper()
        {
            CreateMap<EscolaDTos, Escola>().ReverseMap();
                  
            CreateMap<EscolaEdicaoDTo, Escola>().ReverseMap();

            CreateMap<EnderecoDTo, Endereco>().ReverseMap();

        }
    }
}
