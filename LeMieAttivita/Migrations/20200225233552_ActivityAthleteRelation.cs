using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class ActivityAthleteRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAcceptedTag",
                table: "Activity");

            migrationBuilder.AlterColumn<string>(
                name: "StartLongitude",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "StartLatitude",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "MovingTime",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "GearId",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ElapsedTime",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Id",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "StartLongitude",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "StartLatitude",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovingTime",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GearId",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElapsedTime",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(double))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<bool>(
                name: "FromAcceptedTag",
                table: "Activity",
                nullable: false,
                defaultValue: false);
        }
    }
}
