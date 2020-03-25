using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Athlete",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    ResourceState = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Premium = table.Column<string>(nullable: true),
                    Summit = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    BadgeTypeId = table.Column<int>(nullable: false),
                    ProfilePicMedium = table.Column<string>(nullable: true),
                    ProfilePicLarge = table.Column<string>(nullable: true),
                    Friend = table.Column<string>(nullable: true),
                    Follower = table.Column<string>(nullable: true),
                    FollowerCount = table.Column<int>(nullable: false),
                    FriendCount = table.Column<int>(nullable: false),
                    MutualFriendCount = table.Column<int>(nullable: false),
                    AthleteType = table.Column<int>(nullable: false),
                    DatePreference = table.Column<string>(nullable: true),
                    MeasurementPreference = table.Column<string>(nullable: true),
                    FTP = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athlete", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Athlete");
        }
    }
}
