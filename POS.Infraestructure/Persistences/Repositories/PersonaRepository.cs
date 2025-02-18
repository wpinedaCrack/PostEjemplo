using Microsoft.EntityFrameworkCore;
using POS.Infraestructure.Commons.Bases.Request;
using POS.Infraestructure.Commons.Bases.Response;
using POS.Infraestructure.Persistences.Interfaces;
using POST.Domain.Context;
using POST.Domain.Entities;

namespace POS.Infraestructure.Persistences.Repositories
{
    public class PersonaRepository : GenericRepository<Persona>, IPersonaRepository
    {
        private readonly POSContext _context;
        public PersonaRepository(POSContext context)
        {
            _context = context;
        }


        public async Task<BaseEntityResponse<Persona>> ListPersonas(BaseFiltersRequest filters)
        {
            var response = new BaseEntityResponse<Persona>();
            var personas = (from x in _context.Personas
                            where 1==1
                              select x).AsNoTracking().AsQueryable();

            response.TotalRecords = await personas.CountAsync();
            response.Items = await personas.ToListAsync();// await Ordering(filters, personas, !(bool)filters.Download!).ToListAsync();
            return response;
        }
    }
}
