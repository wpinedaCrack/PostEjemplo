using POS.Application.Commons.Bases;
using POS.Application.Dtos.Request;
using POS.Infraestructure.Commons.Bases.Request;
using POS.Infraestructure.Commons.Bases.Response;
using POST.Domain.Entities;

namespace POS.Application.Interfaces
{
    public interface IPersonaApplication
    {
        //Task<IEnumerable<Persona>> ListPersonas();
        Task<BaseResponse<BaseEntityResponse<PersonaRequestDto>>> ListPersonas(BaseFiltersRequest filters);
    }
}
