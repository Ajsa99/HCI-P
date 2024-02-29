using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace junBackend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aktivnost",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prioritet = table.Column<int>(type: "int", nullable: false),
                    datum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vreme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idKorisnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aktivnost", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "korisnik",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnik", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aktivnost");

            migrationBuilder.DropTable(
                name: "korisnik");
        }
    }
}
