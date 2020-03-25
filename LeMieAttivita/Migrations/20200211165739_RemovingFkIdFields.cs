using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class RemovingFkIdFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "UploadId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "UploadIdStr",
                table: "Activity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExternalId",
                table: "Activity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UploadId",
                table: "Activity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UploadIdStr",
                table: "Activity",
                nullable: false,
                defaultValue: 0);
        }
    }
}
