using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
           CreateMap<EnderecoDTo, Endereco>().ReverseMap();

        }
    }
}
