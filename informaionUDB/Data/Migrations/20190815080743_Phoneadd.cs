using Microsoft.EntityFrameworkCore.Migrations;

namespace informaionUDB.Data.Migrations
{
    public partial class Phoneadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhonePat",
                table: "Docktors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhonePat",
                table: "Docktors");
        }
    }
}
