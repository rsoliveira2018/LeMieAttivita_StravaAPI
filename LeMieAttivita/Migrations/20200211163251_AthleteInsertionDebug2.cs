using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class AthleteInsertionDebug2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Athlete_AthleteId",
                table: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_Activity_AthleteId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "AthleteId",
                table: "Activity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AthleteId",
                table: "Activity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Activity_AthleteId",
                table: "Activity",
                column: "AthleteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Athlete_AthleteId",
                table: "Activity",
                column: "AthleteId",
                principalTable: "Athlete",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
