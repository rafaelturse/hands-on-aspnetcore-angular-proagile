using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgile.WebAPI.Migrations
{
    public partial class imageURLfieldtoEventtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageURL",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageURL",
                table: "Events");
        }
    }
}
