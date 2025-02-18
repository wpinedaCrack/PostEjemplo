using Microsoft.EntityFrameworkCore;
using POST.Domain.Entities;
using System.Reflection;

namespace POST.Domain.Context;

public partial class POSContext : DbContext
{
    public POSContext()
    {
    }

    public POSContext(DbContextOptions<POSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Persona>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__Persona__3214EC077A2BEF4A");

        //    entity.ToTable("Persona");

        //    entity.Property(e => e.Apellido).HasMaxLength(100);
        //    entity.Property(e => e.Email).HasMaxLength(100);
        //    entity.Property(e => e.Nombre).HasMaxLength(100);
        //});

        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
