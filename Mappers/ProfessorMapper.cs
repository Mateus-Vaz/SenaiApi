using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class ProfessorMapper : Profile
    {
        public ProfessorMapper()
        {
            CreateMap<ProfessorDTo, Professor>().ReverseMap();

        }
    }
}
