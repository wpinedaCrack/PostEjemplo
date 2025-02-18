namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IUnitOfwork : IDisposable
    {
        IPersonaRepository Personas { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
