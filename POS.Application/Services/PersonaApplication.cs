using AutoMapper;
using POS.Application.Commons.Bases;
using POS.Application.Dtos.Request;
using POS.Application.Interfaces;
using POS.Application.Validators.Personas;
using POS.Infraestructure.Commons.Bases.Request;
using POS.Infraestructure.Commons.Bases.Response;
using POS.Infraestructure.Persistences.Interfaces;
using POST.Domain.Entities;

namespace POS.Application.Services
{
    public class PersonaApplication : IPersonaApplication
    {
        private readonly IUnitOfwork _unitOfwork;
        private readonly PersonaValidator _validationRules;
        private readonly IMapper _mapper;

        public PersonaApplication(IUnitOfwork unitOfwork, PersonaValidator validationRules, IMapper mapper)//, CategoryValidator validationRules)
        {
            _unitOfwork = unitOfwork;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        //public async Task<IEnumerable<Persona>> ListPersonas()
        //{
        //    var personas = await _unitOfwork.Personas.ListPersonas();
        //    return personas;
        //}

        public async Task<BaseResponse<BaseEntityResponse<PersonaRequestDto>>> ListPersonas(BaseFiltersRequest filters)
        {
            var response = new BaseResponse<BaseEntityResponse<PersonaRequestDto>>();
            var personas = await _unitOfwork.Personas.ListPersonas(filters);


            if (personas is not null)
            {
                response.IsSuccess = true;
                response.Data = _mapper.Map<BaseEntityResponse<PersonaRequestDto>>(personas);
                response.Message = "OK";// ReplyMessage.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Mal";// ReplyMessage.MESSAGE_QUERY_EMPY;
            }
            return response;
        }
    }
}
