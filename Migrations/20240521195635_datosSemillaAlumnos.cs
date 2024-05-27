using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inscripciones.Migrations
{
    /// <inheritdoc />
    public partial class datosSemillaAlumnos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "alumnos",
                columns: new[] { "Id", "ApellidoNombre", "Direccion", "Email", "Telefono" },
                values: new object[] { 1, "Federico Bustamante", "San Juan 2043", "federicobustamante@gmail.com", "3498498494" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
