using AutoMapper;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Infraestructure.Commons.Bases.Response;
using POST.Domain.Entities;

namespace POS.Application.Mappers
{
    public class PersonaMappingsProfile : Profile
    {
        public PersonaMappingsProfile()
        {
            //CreateMap<Persona, PersonaResponseDto>();
            //CreateMap<PersonaRequestDto, Persona>();

            CreateMap<Persona, PersonaResponseDto>();
           //.ForMember(x => x.StateCategory, x => x.MapFrom(y => y.State.Equals((int)StateTypes.Active) ? "Activo" : "Inactivo")).ReverseMap();

            CreateMap<BaseEntityResponse<Persona>, BaseEntityResponse<PersonaRequestDto>>();

            CreateMap<Persona, PersonaRequestDto>().ReverseMap();



        }
    }

}
