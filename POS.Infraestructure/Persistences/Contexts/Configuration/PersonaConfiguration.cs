using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POST.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Persona__3214EC077A2BEF4A");

            builder.ToTable("Persona");

            builder.Property(e => e.Apellido).HasMaxLength(100);
            builder.Property(e => e.Email).HasMaxLength(100);         
        }
    }
}
