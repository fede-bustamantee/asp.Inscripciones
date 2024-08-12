using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inscripciones.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApellidoNombre", "Direccion", "Email", "Telefono" },
                values: new object[] { "Federico Valentin Bustamante", "Belgrano 34", "federico@gmail.com", "3498405574" });

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 8, 11, 23, 34, 57, 178, DateTimeKind.Local).AddTicks(4209));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "alumnos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApellidoNombre", "Direccion", "Email", "Telefono" },
                values: new object[] { "Rubén Alejandro Ramirez", "Bv Roque Saenz Peña 2942", "aleramirezsj@gmail.com", "15447106" });

            migrationBuilder.UpdateData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 8, 11, 22, 57, 26, 90, DateTimeKind.Local).AddTicks(9727));
        }
    }
}
