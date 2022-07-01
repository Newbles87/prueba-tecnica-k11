using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace K11.Repository.Encuenta.Migrations
{
    public partial class Migracion30062022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "trsobj");

            migrationBuilder.CreateTable(
                name: "Encuestas",
                schema: "trsobj",
                columns: table => new
                {
                    IdEncuesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioCrea = table.Column<int>(type: "int", nullable: false),
                    FechaCrea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModifica = table.Column<int>(type: "int", nullable: false),
                    FechaModifica = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuestas", x => x.IdEncuesta);
                });

            migrationBuilder.CreateTable(
                name: "PreguntasEncuestas",
                schema: "trsobj",
                columns: table => new
                {
                    IdPreguntaEncuesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEncuesta = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioCrea = table.Column<int>(type: "int", nullable: false),
                    FechaCrea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModifica = table.Column<int>(type: "int", nullable: false),
                    FechaModifica = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreguntasEncuestas", x => x.IdPreguntaEncuesta);
                    table.ForeignKey(
                        name: "FK_PreguntasEncuestas_Encuestas_IdEncuesta",
                        column: x => x.IdEncuesta,
                        principalSchema: "trsobj",
                        principalTable: "Encuestas",
                        principalColumn: "IdEncuesta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RespuestasEncuestas",
                schema: "trsobj",
                columns: table => new
                {
                    IdRespuestaEncuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPreguntaEncuesta = table.Column<int>(type: "int", nullable: false),
                    DescripcionRespuesta = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioCrea = table.Column<int>(type: "int", nullable: false),
                    FechaCrea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModifica = table.Column<int>(type: "int", nullable: false),
                    FechaModifica = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestasEncuestas", x => x.IdRespuestaEncuenta);
                    table.ForeignKey(
                        name: "FK_RespuestasEncuestas_PreguntasEncuestas_IdPreguntaEncuesta",
                        column: x => x.IdPreguntaEncuesta,
                        principalSchema: "trsobj",
                        principalTable: "PreguntasEncuestas",
                        principalColumn: "IdPreguntaEncuesta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreguntasEncuestas_IdEncuesta",
                schema: "trsobj",
                table: "PreguntasEncuestas",
                column: "IdEncuesta");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestasEncuestas_IdPreguntaEncuesta",
                schema: "trsobj",
                table: "RespuestasEncuestas",
                column: "IdPreguntaEncuesta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespuestasEncuestas",
                schema: "trsobj");

            migrationBuilder.DropTable(
                name: "PreguntasEncuestas",
                schema: "trsobj");

            migrationBuilder.DropTable(
                name: "Encuestas",
                schema: "trsobj");
        }
    }
}
