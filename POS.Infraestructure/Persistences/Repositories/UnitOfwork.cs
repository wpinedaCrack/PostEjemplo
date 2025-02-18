using POS.Infraestructure.Persistences.Interfaces;
using POST.Domain.Context;

namespace POS.Infraestructure.Persistences.Repositories
{
    public class UnitOfwork : IUnitOfwork
    {
        private readonly POSContext _context;
        public IPersonaRepository Personas { get; private set; }

        public UnitOfwork(POSContext context)
        {
            _context = context;
            Personas = new PersonaRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
