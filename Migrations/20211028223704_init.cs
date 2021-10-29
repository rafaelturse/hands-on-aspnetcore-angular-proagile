using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgile.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    place = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    theme = table.Column<string>(nullable: true),
                    peopleAmount = table.Column<int>(nullable: false),
                    lot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
