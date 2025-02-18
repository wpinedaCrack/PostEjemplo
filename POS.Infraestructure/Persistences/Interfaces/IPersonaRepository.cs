using POS.Infraestructure.Commons.Bases.Request;
using POS.Infraestructure.Commons.Bases.Response;
using POST.Domain.Entities;

namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IPersonaRepository
    {
        //Task<IEnumerable<Persona>> ListPersonas();
        Task<BaseEntityResponse<Persona>> ListPersonas(BaseFiltersRequest filters);
    }
}
