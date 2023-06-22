using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_basico.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carritos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carritos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    peliculaId = table.Column<int>(type: "int", nullable: false),
                    salaId = table.Column<int>(type: "int", nullable: false),
                    fila = table.Column<int>(type: "int", nullable: false),
                    butaca = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarritoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entradas_Carritos_CarritoId",
                        column: x => x.CarritoId,
                        principalTable: "Carritos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entradas_Peliculas_peliculaId",
                        column: x => x.peliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entradas_Salas_salaId",
                        column: x => x.salaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_CarritoId",
                table: "Entradas",
                column: "CarritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_peliculaId",
                table: "Entradas",
                column: "peliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_salaId",
                table: "Entradas",
                column: "salaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Carritos");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
