using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_DataAccess.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        /*public DbSet<Empleador> Empleadores { get; set; }*/
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pericia> Pericias { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Siniestro> Siniestros { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<ValDaño> ValDaños { get; set; }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<ValDaño>(entity =>
             {
                 entity.HasKey(e => e.Id);
                 entity.HasOne(e => e.Localidad)
                       .WithMany()
                       .HasForeignKey(e => e.LocalidadId)
                       .OnDelete(DeleteBehavior.Cascade);

                 entity.HasOne(e => e.Provincia)
                       .WithMany()
                       .HasForeignKey(e => e.ProvinciaId)
                       .OnDelete(DeleteBehavior.Cascade);
             });*/
    }
}

