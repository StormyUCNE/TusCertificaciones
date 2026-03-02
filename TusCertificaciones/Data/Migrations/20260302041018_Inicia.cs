using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TusCertificaciones.Migrations
{
    /// <inheritdoc />
    public partial class Inicia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadosCertificaciones",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosCertificaciones", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    RNE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TandaSeccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.RNE);
                    table.ForeignKey(
                        name: "FK_Estudiantes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Certificaciones",
                columns: table => new
                {
                    CertificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumDistritoEducativo = table.Column<int>(type: "int", nullable: false),
                    NumRegional = table.Column<int>(type: "int", nullable: false),
                    LugarExpedicion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCertificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreCentroEducativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreDirectorCentroEducativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreDirectorDistrito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UbicacionRegional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UbicacionDistrito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificaciones", x => x.CertificacionId);
                    table.ForeignKey(
                        name: "FK_Certificaciones_EstadosCertificaciones_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadosCertificaciones",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Certificaciones_Estudiantes_RNE",
                        column: x => x.RNE,
                        principalTable: "Estudiantes",
                        principalColumn: "RNE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificaciones_EstadoId",
                table: "Certificaciones",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificaciones_RNE",
                table: "Certificaciones",
                column: "RNE");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_UserId",
                table: "Estudiantes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificaciones");

            migrationBuilder.DropTable(
                name: "EstadosCertificaciones");

            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
