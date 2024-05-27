using Microsoft.EntityFrameworkCore;

namespace Inscripciones.Models
{
    public class InscripcionesContext : DbContext
    {
        public InscripcionesContext(DbContextOptions<InscripcionesContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;
                Database=InscripcionesContext; 
                User Id=sa; Password=1234; 
                MultipleActiveResultSets = True; Encrypt=False");
        }
        public virtual DbSet<Alumno> alumnos { get; set; }
        public virtual DbSet<Carrera> carreras { get; set; }


        //datos semilla
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().HasData(
               new Alumno()
               {
                   Id = 1,
                   ApellidoNombre = "Federico Bustamante",
                   Telefono = "3498498494",
                   Direccion = "San Juan 2043",
                   Email= "federicobustamante@gmail.com"
               });
        }
    }
}
