using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class ApiTokenAndAthlete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_APIToken",
                table: "APIToken");

            migrationBuilder.RenameTable(
                name: "APIToken",
                newName: "ApiToken");

            migrationBuilder.AddColumn<int>(
                name: "ApiTokenId",
                table: "Athlete",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "ApiToken",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "ApiToken",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RetrievalDate",
                table: "ApiToken",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiToken",
                table: "ApiToken",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Athlete_ApiTokenId",
                table: "Athlete",
                column: "ApiTokenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Athlete_ApiToken_ApiTokenId",
                table: "Athlete",
                column: "ApiTokenId",
                principalTable: "ApiToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Athlete_ApiToken_ApiTokenId",
                table: "Athlete");

            migrationBuilder.DropIndex(
                name: "IX_Athlete_ApiTokenId",
                table: "Athlete");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiToken",
                table: "ApiToken");

            migrationBuilder.DropColumn(
                name: "ApiTokenId",
                table: "Athlete");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ApiToken");

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "ApiToken");

            migrationBuilder.DropColumn(
                name: "RetrievalDate",
                table: "ApiToken");

            migrationBuilder.RenameTable(
                name: "ApiToken",
                newName: "APIToken");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APIToken",
                table: "APIToken",
                column: "Id");
        }
    }
}
