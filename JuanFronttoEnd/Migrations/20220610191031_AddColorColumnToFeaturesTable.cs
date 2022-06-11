using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanFronttoEnd.Migrations
{
    public partial class AddColorColumnToFeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bg_color",
                table: "Features",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bg_color",
                table: "Features");
        }
    }
}
