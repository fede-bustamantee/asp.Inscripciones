using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inscripciones.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDetalleInscripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "detalleInscripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModalidadCursado = table.Column<int>(type: "int", nullable: false),
                    InscripcionId = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleInscripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleInscripcion_inscripcion_InscripcionId",
                        column: x => x.InscripcionId,
                        principalTable: "inscripcion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleInscripcion_materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_detalleInscripcion_InscripcionId",
                table: "detalleInscripcion",
                column: "InscripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_detalleInscripcion_MateriaId",
                table: "detalleInscripcion",
                column: "MateriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleInscripcion");
        }
    }
}
