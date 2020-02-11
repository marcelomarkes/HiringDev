using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiYoutube.Migrations
{
    public partial class Inictial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Canal",
                columns: table => new
                {
                    IdCanal = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCanal = table.Column<string>(maxLength: 150, nullable: false),
                    DescricaoCanal = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canal", x => x.IdCanal);
                });

            migrationBuilder.CreateTable(
                name: "CanalItem",
                columns: table => new
                {
                    IdCanalItem = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCanalItem = table.Column<string>(maxLength: 150, nullable: false),
                    IdCanal = table.Column<int>(nullable: true),
                    ComentarioCanalItem = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanalItem", x => x.IdCanalItem);
                    table.ForeignKey(
                        name: "FK_CanalItem_Canal_IdCanal",
                        column: x => x.IdCanal,
                        principalTable: "Canal",
                        principalColumn: "IdCanal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanalItem_IdCanal",
                table: "CanalItem",
                column: "IdCanal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanalItem");

            migrationBuilder.DropTable(
                name: "Canal");
        }
    }
}
