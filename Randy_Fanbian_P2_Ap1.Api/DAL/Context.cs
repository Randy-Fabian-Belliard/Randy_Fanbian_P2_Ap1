using Microsoft.EntityFrameworkCore;
using Randy_Fanbian_P2_Ap1.Models;
using System.Reflection.Emit;

namespace Randy_Fanbian_P2_Ap1.Api.DAL
{
    public class Context : DbContext
    {
        public DbSet<Accesorios> Accesorios { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        
        public Context(DbContextOptions<Context> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Accesorios>().HasData(new Accesorios() { AccesorioId = 1, Descripcion = "Camara Tracera" });
        modelBuilder.Entity<Accesorios>().HasData(new Accesorios() { AccesorioId = 2, Descripcion = "Pantalla interior" });
        modelBuilder.Entity<Accesorios>().HasData(new Accesorios() { AccesorioId = 3, Descripcion = "Interior en piel" });
        modelBuilder.Entity<Accesorios>().HasData(new Accesorios() { AccesorioId = 4, Descripcion = "Sun Roof" });
        modelBuilder.Entity<Accesorios>().HasData(new Accesorios() { AccesorioId = 5, Descripcion = "Aros de lujo" });
        }
        public DbSet<Randy_Fanbian_P2_Ap1.Models.VehiculoDetalle> VehiculoDetalle { get; set; } = default!;
    }

}






