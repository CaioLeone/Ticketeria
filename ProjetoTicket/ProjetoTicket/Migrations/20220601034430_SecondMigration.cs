using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTicket.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriasId",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assentos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EventosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locals_Eventos_EventosId",
                        column: x => x.EventosId,
                        principalTable: "Eventos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacidade = table.Column<int>(type: "int", nullable: true),
                    LocaisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salas_Locals_LocaisId",
                        column: x => x.LocaisId,
                        principalTable: "Locals",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssentoSala",
                columns: table => new
                {
                    AssentosId = table.Column<int>(type: "int", nullable: false),
                    SalasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssentoSala", x => new { x.AssentosId, x.SalasId });
                    table.ForeignKey(
                        name: "FK_AssentoSala_Assentos_AssentosId",
                        column: x => x.AssentosId,
                        principalTable: "Assentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssentoSala_Salas_SalasId",
                        column: x => x.SalasId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CategoriasId",
                table: "Eventos",
                column: "CategoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_AssentoSala_SalasId",
                table: "AssentoSala",
                column: "SalasId");

            migrationBuilder.CreateIndex(
                name: "IX_Locals_EventosId",
                table: "Locals",
                column: "EventosId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_LocaisId",
                table: "Salas",
                column: "LocaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Categorias_CategoriasId",
                table: "Eventos",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Categorias_CategoriasId",
                table: "Eventos");

            migrationBuilder.DropTable(
                name: "AssentoSala");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Assentos");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Locals");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_CategoriasId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "CategoriasId",
                table: "Eventos");
        }
    }
}
