using Microsoft.EntityFrameworkCore.Migrations;

namespace informaionUDB.Data.Migrations
{
    public partial class addnewpropirty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhonePat",
                table: "Docktors",
                newName: "PhonePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhonePath",
                table: "Docktors",
                newName: "PhonePat");
        }
    }
}
