using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class AddingApiToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APIToken",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TokenType = table.Column<string>(nullable: true),
                    AccessToken = table.Column<string>(nullable: true),
                    ExpiresAt = table.Column<DateTime>(nullable: false),
                    ExpiresIn = table.Column<int>(nullable: false),
                    RefreshToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIToken", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APIToken");
        }
    }
}
