using Microsoft.EntityFrameworkCore.Migrations;

namespace PDFGenerator.Migrations
{
    public partial class MapCorrectionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "latitude",
                table: "samplemodel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "longitude",
                table: "samplemodel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "latitude",
                table: "samplemodel");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "samplemodel");
        }
    }
}
