using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inscripciones.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDatosSemilladeAlumnoCarreraanioCarreraYMateria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApellidoNombre", "Direccion", "Email", "Telefono" },
                values: new object[] { "Bustamante Federico Valentin", "Belgrano 123", "Federico@gmail.com", "3498675354" });

            migrationBuilder.InsertData(
                table: "alumnos",
                columns: new[] { "Id", "ApellidoNombre", "Direccion", "Email", "Telefono" },
                values: new object[,]
                {
                    { 2, "Javier López", "Calle de la Vida 101", "javier.lopez@example.com", "3498765445" },
                    { 3, "Ana María Gómez", "Calle Falsa 123", "anamaria@gmail.com", "3498765432" },
                    { 4, "Carlos Alberto Pérez", "Av Siempre Viva 742", "carlos.perez@example.com", "3498765433" },
                    { 5, "Laura González", "Bv. Belgrano 154", "laura.gonzalez@example.com", "3498765434" },
                    { 6, "Marcelo Diaz", "Calle de la Amargura 7", "marcelo.diaz@example.com", "3498765435" },
                    { 7, "Verónica Herrera", "Calle de los Enamorados 15", "veronica.herrera@example.com", "3498765436" },
                    { 8, "Miguel Angel Rodríguez", "Av. de Mayo 123", "miguel.rodriguez@example.com", "3498765437" },
                    { 9, "Paula Fernández", "Calle de los Pinos 24", "paula.fernandez@example.com", "3498765438" },
                    { 10, "Gabriel Suárez", "Calle Falsa 345", "gabriel.suarez@example.com", "3498765439" }
                });

            migrationBuilder.InsertData(
                table: "carreras",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Tecnicatura Superior en Desarrollo de Software" },
                    { 2, "Tecnicatura Superior en Soporte de Infraestructura" },
                    { 3, "Tecnicatura Superior en Gestion de las Organizaciones" },
                    { 4, "Tecnicatura Superior en Enfermeria" },
                    { 5, "Profesorado de Educación Secundaria en Ciencias de la Administración" },
                    { 6, "Profesorado de Educación Inicial" },
                    { 7, "Profesorado de Educación Secundaria en Economía" },
                    { 8, "Profesorado de Educación Tecnológica" },
                    { 9, "Licenciatura en Cooperativismo y Mutualismo" }
                });

            migrationBuilder.InsertData(
                table: "aniocarreras",
                columns: new[] { "Id", "CarreraId", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "1er año" },
                    { 2, 1, "2do año" },
                    { 3, 1, "3er año" },
                    { 4, 2, "1er año" },
                    { 5, 2, "2do año" },
                    { 6, 2, "3er año" },
                    { 7, 3, "1er año" },
                    { 8, 3, "2do año" },
                    { 9, 3, "3er año" },
                    { 10, 4, "1er año" },
                    { 11, 4, "2do año" },
                    { 12, 4, "3er año" },
                    { 13, 5, "1er año" },
                    { 14, 5, "2do año" },
                    { 15, 5, "3er año" },
                    { 16, 5, "4to año" },
                    { 17, 6, "1er año" },
                    { 18, 6, "2do año" },
                    { 19, 6, "3er año" },
                    { 20, 6, "4to año" },
                    { 21, 7, "1er año" },
                    { 22, 7, "2do año" },
                    { 23, 7, "3er año" },
                    { 24, 7, "4to año" },
                    { 25, 8, "1er año" },
                    { 26, 8, "2do año" },
                    { 27, 8, "3er año" },
                    { 28, 8, "4to año" }
                });

            migrationBuilder.InsertData(
                table: "materia",
                columns: new[] { "Id", "AnioCarreraId", "Nombre" },
                values: new object[,]
                {
                    { 1, 25, "Pedagogía" },
                    { 2, 25, "Movimiento y Cuerpo" },
                    { 3, 25, "Práctica Docente I: Escenarios Educativos" },
                    { 4, 25, "Introducción a la Tecnología" },
                    { 5, 25, "Historia de la Tecnología" },
                    { 6, 25, "Diseño y Producción de la Técnología 1" },
                    { 7, 25, "Matemática" },
                    { 8, 25, "Física" },
                    { 9, 26, "Psicología de la Educación" },
                    { 10, 26, "Didáctica y Curriculum" },
                    { 11, 26, "Instituciones Educativas" },
                    { 12, 26, "Práctica Docente II: La Institución Escolar" },
                    { 13, 26, "Sujetos de la Educación I" },
                    { 14, 26, "Tic para la Enseñanza" },
                    { 15, 26, "Procesos Productivos" },
                    { 16, 26, "Tecnológica II" },
                    { 17, 26, "Didáctica Específica I" },
                    { 18, 27, "Filosofía y Educación" },
                    { 19, 27, "Historia Social de la Educación" },
                    { 20, 27, "Metodología de la Investigación" },
                    { 21, 27, "Práctica Docente III: La Clase" },
                    { 22, 27, "Sujetos de la Educación II" },
                    { 23, 27, "Materiales" },
                    { 24, 27, "Química" },
                    { 25, 27, "Procesos de Control" },
                    { 26, 27, "Tecnologías Regionales" },
                    { 27, 27, "Diseño y Producción Tecnológica III" },
                    { 28, 27, "Didáctica Específica II" },
                    { 29, 28, "Ética y Trabajo Docente" },
                    { 30, 28, "Educación Sexual Integral" },
                    { 31, 28, "Unidades de Definición Institucional I" },
                    { 32, 28, "Unidades de Definición Institucional II" },
                    { 33, 28, "Prácticas de Investigación" },
                    { 34, 28, "Práctica Docente IV: El Rol Docente y su Práctica" },
                    { 35, 28, "Biotecnología" },
                    { 36, 28, "Procesos de Comunicación" },
                    { 37, 28, "Problemáticas Sociotécnicas" },
                    { 38, 28, "Diseño y Producción Tecnológica IV" },
                    { 39, 28, "Taller de Producción Didáctica" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "materia",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "aniocarreras",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApellidoNombre", "Direccion", "Email", "Telefono" },
                values: new object[] { "Federico Bustamante", "San Juan 2043", "federicobustamante@gmail.com", "3498498494" });
        }
    }
}
