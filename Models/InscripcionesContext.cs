using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;
using Inscripciones.Controllers;
using System.Drawing;

namespace Inscripciones.Models
{
    public class InscripcionesContext : DbContext
    {
        public InscripcionesContext(DbContextOptions<InscripcionesContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    @"Server=.\SQLEXPRESS;
            //    Database=InscripcionesContext; 
            //    User Id=sa; Password=1234; 
            //    MultipleActiveResultSets = True; Encrypt=False");
            string cadenaConexion = "Server=5.57.213.17;Database=smartsof_fedebustamante; User=smartsof_bustamante;Password=bustamantefede123";
            optionsBuilder.UseMySql
                (cadenaConexion,
                ServerVersion.AutoDetect
                (cadenaConexion));
        }
        public virtual DbSet<Alumno> alumnos { get; set; }
        public virtual DbSet<Carrera> carreras { get; set; }
        public virtual DbSet<Inscripcion> inscripcion{ get; set; }
        public virtual DbSet<AnioCarrera> aniocarreras { get; set; }
        public virtual DbSet<Materia> materia { get; set; }
        public virtual DbSet<DetalleInscripcion> detalleInscripcion { get; set; }



        //datos semillas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region datos semillas alumnos
            var alumnos = new[]
            {
                new Alumno { Id = 1, ApellidoNombre = "Bustamante Federico Valentin", Email = "Federico@gmail.com", Direccion = "Belgrano 123", Telefono = "3498675354" },
                new Alumno { Id = 2, ApellidoNombre = "Javier López", Email = "javier.lopez@example.com", Direccion = "Calle de la Vida 101", Telefono = "3498765445" },
                new Alumno { Id = 3, ApellidoNombre = "Ana María Gómez", Email = "anamaria@gmail.com", Direccion = "Calle Falsa 123", Telefono = "3498765432" },
                new Alumno { Id = 4, ApellidoNombre = "Carlos Alberto Pérez", Email = "carlos.perez@example.com", Direccion = "Av Siempre Viva 742", Telefono = "3498765433" },
                new Alumno { Id = 5, ApellidoNombre = "Laura González", Email = "laura.gonzalez@example.com", Direccion = "Bv. Belgrano 154", Telefono = "3498765434" },
                new Alumno { Id = 6, ApellidoNombre = "Marcelo Diaz", Email = "marcelo.diaz@example.com", Direccion = "Calle de la Amargura 7", Telefono = "3498765435" },
                new Alumno { Id = 7, ApellidoNombre = "Verónica Herrera", Email = "veronica.herrera@example.com", Direccion = "Calle de los Enamorados 15", Telefono = "3498765436" },
                new Alumno { Id = 8, ApellidoNombre = "Miguel Angel Rodríguez", Email = "miguel.rodriguez@example.com", Direccion = "Av. de Mayo 123", Telefono = "3498765437" },
                new Alumno { Id = 9, ApellidoNombre = "Paula Fernández", Email = "paula.fernandez@example.com", Direccion = "Calle de los Pinos 24", Telefono = "3498765438" },
                new Alumno { Id = 10, ApellidoNombre = "Gabriel Suárez", Email = "gabriel.suarez@example.com", Direccion = "Calle Falsa 345", Telefono = "3498765439" }
            };
            modelBuilder.Entity<Alumno>().HasData(alumnos);
            #endregion

            #region Datos semilla de carreras
            var carreras = new[]
            {
                new Carrera { Id = 1, Nombre = "Tecnicatura Superior en Desarrollo de Software" },
                new Carrera { Id = 2, Nombre = "Tecnicatura Superior en Soporte de Infraestructura" },
                new Carrera { Id = 3, Nombre = "Tecnicatura Superior en Gestion de las Organizaciones" },
                new Carrera { Id = 4, Nombre = "Tecnicatura Superior en Enfermeria" },
                new Carrera { Id = 5, Nombre = "Profesorado de Educación Secundaria en Ciencias de la Administración" },
                new Carrera { Id = 6, Nombre = "Profesorado de Educación Inicial" },
                new Carrera { Id = 7, Nombre = "Profesorado de Educación Secundaria en Economía" },
                new Carrera { Id = 8, Nombre = "Profesorado de Educación Tecnológica" },
                new Carrera { Id = 9, Nombre = "Licenciatura en Cooperativismo y Mutualismo" }
            };
            modelBuilder.Entity<Carrera>().HasData(carreras);
            #endregion

            #region Datos semillas de AnioCarreras
            var AnioCarrearas = new[]
            {
                //TECNICO SUPERIOR EN DESARROLLO DE SOFTWARE
                new AnioCarrera { Id = 1, CarreraId = 1, Nombre = "1er año" },
                new AnioCarrera { Id = 2, CarreraId = 1, Nombre = "2do año" },
                new AnioCarrera { Id = 3, CarreraId = 1, Nombre = "3er año" },
                //Tecnicatura Superior en Soporte de Infraestructura
                new AnioCarrera { Id = 4, CarreraId = 2, Nombre = "1er año" },
                new AnioCarrera { Id = 5, CarreraId = 2, Nombre = "2do año" },
                new AnioCarrera { Id = 6, CarreraId = 2, Nombre = "3er año" },
                //Tecnicatura Superior en Gestion de las Organizaciones
                new AnioCarrera { Id = 7, CarreraId = 3, Nombre = "1er año" },
                new AnioCarrera { Id = 8, CarreraId = 3, Nombre = "2do año" },
                new AnioCarrera { Id = 9, CarreraId = 3, Nombre = "3er año" },
                //Tecnicatura Superior en Enfermeria
                new AnioCarrera { Id = 10, CarreraId = 4, Nombre = "1er año" },
                new AnioCarrera { Id = 11, CarreraId = 4, Nombre = "2do año" },
                new AnioCarrera { Id = 12, CarreraId = 4, Nombre = "3er año" },
                //Profesorado de Educación Secundaria en Ciencias de la Administración
                new AnioCarrera { Id = 13, CarreraId = 5, Nombre = "1er año" },
                new AnioCarrera { Id = 14, CarreraId = 5, Nombre = "2do año" },
                new AnioCarrera { Id = 15, CarreraId = 5, Nombre = "3er año" },
                new AnioCarrera { Id = 16, CarreraId = 5, Nombre = "4to año" },
                //Profesorado de Educación Inicial
                new AnioCarrera { Id = 17, CarreraId = 6, Nombre = "1er año" },
                new AnioCarrera { Id = 18, CarreraId = 6, Nombre = "2do año" },
                new AnioCarrera { Id = 19, CarreraId = 6, Nombre = "3er año" },
                new AnioCarrera { Id = 20, CarreraId = 6, Nombre = "4to año" },
                //Profesorado de Educación Secundaria en Economía
                new AnioCarrera { Id = 21, CarreraId = 7, Nombre = "1er año" },
                new AnioCarrera { Id = 22, CarreraId = 7, Nombre = "2do año" },
                new AnioCarrera { Id = 23, CarreraId = 7, Nombre = "3er año" },
                new AnioCarrera { Id = 24, CarreraId = 7, Nombre = "4to año" },
                //Profesorado de Educación Tecnológica
                new AnioCarrera { Id = 25, CarreraId = 8, Nombre = "1er año" },
                new AnioCarrera { Id = 26, CarreraId = 8, Nombre = "2do año" },
                new AnioCarrera { Id = 27, CarreraId = 8, Nombre = "3er año" },
                new AnioCarrera { Id = 28, CarreraId = 8, Nombre = "4to año" }
            };
            modelBuilder.Entity<AnioCarrera>().HasData(AnioCarrearas);
            #endregion

            #region datos semilla de materias
            //Profesorado de Educación Tecnológica
            var Materias = new[]
            {
                //1er Año
                new Materia { Id = 1, Nombre = "Pedagogía", AnioCarreraId = 25 },          
                new Materia { Id = 2, Nombre = "Movimiento y Cuerpo", AnioCarreraId = 25 },
                new Materia { Id = 3, Nombre = "Práctica Docente I: Escenarios Educativos", AnioCarreraId = 25 },
                new Materia { Id = 4, Nombre = "Introducción a la Tecnología", AnioCarreraId = 25 },
                new Materia { Id = 5, Nombre = "Historia de la Tecnología", AnioCarreraId = 25 },
                new Materia { Id = 6, Nombre = "Diseño y Producción de la Técnología 1", AnioCarreraId = 25 },
                new Materia { Id = 7, Nombre = "Matemática", AnioCarreraId = 25 },
                new Materia { Id = 8, Nombre = "Física", AnioCarreraId = 25 },

                //2do Año
                new Materia { Id = 9, Nombre = "Psicología de la Educación", AnioCarreraId = 26 },
                new Materia { Id = 10, Nombre = "Didáctica y Curriculum", AnioCarreraId = 26 },
                new Materia { Id = 11, Nombre = "Instituciones Educativas", AnioCarreraId = 26 },
                new Materia { Id = 12, Nombre = "Práctica Docente II: La Institución Escolar", AnioCarreraId = 26 },
                new Materia { Id = 13, Nombre = "Sujetos de la Educación I", AnioCarreraId = 26 },
                new Materia { Id = 14, Nombre = "Tic para la Enseñanza", AnioCarreraId = 26 },
                new Materia { Id = 15, Nombre = "Procesos Productivos", AnioCarreraId = 26 },
                new Materia { Id = 16, Nombre = "Tecnológica II", AnioCarreraId = 26 },
                new Materia { Id = 17, Nombre = "Didáctica Específica I", AnioCarreraId = 26 },

                //3er Año
                new Materia { Id = 18, Nombre = "Filosofía y Educación", AnioCarreraId = 27 },
                new Materia { Id = 19, Nombre = "Historia Social de la Educación", AnioCarreraId = 27 },
                new Materia { Id = 20, Nombre = "Metodología de la Investigación", AnioCarreraId = 27 },
                new Materia { Id = 21, Nombre = "Práctica Docente III: La Clase", AnioCarreraId = 27 },
                new Materia { Id = 22, Nombre = "Sujetos de la Educación II", AnioCarreraId = 27 },
                new Materia { Id = 23, Nombre = "Materiales", AnioCarreraId = 27 },
                new Materia { Id = 24, Nombre = "Química", AnioCarreraId = 27 },
                new Materia { Id = 25, Nombre = "Procesos de Control", AnioCarreraId = 27 },
                new Materia { Id = 26, Nombre = "Tecnologías Regionales", AnioCarreraId = 27 },
                new Materia { Id = 27, Nombre = "Diseño y Producción Tecnológica III", AnioCarreraId = 27 },
                new Materia { Id = 28, Nombre = "Didáctica Específica II", AnioCarreraId = 27 },

                //4to Año
                new Materia { Id = 29, Nombre = "Ética y Trabajo Docente", AnioCarreraId = 28 },
                new Materia { Id = 30, Nombre = "Educación Sexual Integral", AnioCarreraId = 28 },
                new Materia { Id = 31, Nombre = "Unidades de Definición Institucional I", AnioCarreraId = 28 },
                new Materia { Id = 32, Nombre = "Unidades de Definición Institucional II", AnioCarreraId = 28 },
                new Materia { Id = 33, Nombre = "Prácticas de Investigación", AnioCarreraId = 28 },
                new Materia { Id = 34, Nombre = "Práctica Docente IV: El Rol Docente y su Práctica", AnioCarreraId = 28 },
                new Materia { Id = 35, Nombre = "Biotecnología", AnioCarreraId = 28 },
                new Materia { Id = 36, Nombre = "Procesos de Comunicación", AnioCarreraId = 28 },
                new Materia { Id = 37, Nombre = "Problemáticas Sociotécnicas", AnioCarreraId = 28 },
                new Materia { Id = 38, Nombre = "Diseño y Producción Tecnológica IV", AnioCarreraId = 28 },
                new Materia { Id = 39, Nombre = "Taller de Producción Didáctica", AnioCarreraId = 28 }
        };
        modelBuilder.Entity<Materia>().HasData(Materias);
            #endregion

            #region definición de filtros de eliminación
            // (este código no lo habilitamos todavía porque es cuando agregamos un campo Eliminado a las tablas y modificamos los
            // repository para que al mandar a eliminar solo cambien este campo y lo pongan en verdadero, esta configuración de
            // eliminación hace que el sistema ignore los registros que tengan el eliminado en verdadero, así que hace que en
            // apariencia y funcionalidad esté "eliminado", pero van a seguir estando ahí para que podamos observar las eliminaciones que hubo)
            //modelBuilder.Entity<Alumno>().HasQueryFilter(m => !m.Eliminado);
            //modelBuilder.Entity<AnioCarrera>().HasQueryFilter(m => !m.Eliminado);
            //modelBuilder.Entity<Carrera>().HasQueryFilter(m => !m.Eliminado);
            //modelBuilder.Entity<Materia>().HasQueryFilter(m => !m.Eliminado);
            #endregion

        }

    }
}
