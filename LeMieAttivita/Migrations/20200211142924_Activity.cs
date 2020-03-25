using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMieAttivita.Migrations
{
    public partial class Activity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    AthleteId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Distance = table.Column<double>(nullable: false),
                    MovingTime = table.Column<int>(nullable: false),
                    ElapsedTime = table.Column<int>(nullable: false),
                    TotalElevationGain = table.Column<double>(nullable: false),
                    Ride = table.Column<string>(nullable: true),
                    WorkoutType = table.Column<int>(nullable: false),
                    ExternalId = table.Column<int>(nullable: false),
                    UploadId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StartDateLocal = table.Column<DateTime>(nullable: false),
                    Timezone = table.Column<string>(nullable: true),
                    UtcOffset = table.Column<double>(nullable: false),
                    LocationCity = table.Column<string>(nullable: true),
                    LocationState = table.Column<string>(nullable: true),
                    LocationCountry = table.Column<string>(nullable: true),
                    StartLatitude = table.Column<double>(nullable: false),
                    StartLongitude = table.Column<double>(nullable: false),
                    AchievementCount = table.Column<int>(nullable: false),
                    KudosCount = table.Column<int>(nullable: false),
                    CommentCount = table.Column<int>(nullable: false),
                    AthleteCount = table.Column<int>(nullable: false),
                    PhotoCount = table.Column<int>(nullable: false),
                    Trainer = table.Column<bool>(nullable: false),
                    Commute = table.Column<bool>(nullable: false),
                    Manual = table.Column<bool>(nullable: false),
                    Private = table.Column<bool>(nullable: false),
                    Visibility = table.Column<string>(nullable: true),
                    Flagged = table.Column<bool>(nullable: false),
                    GearId = table.Column<int>(nullable: false),
                    FromAcceptedTag = table.Column<bool>(nullable: false),
                    UploadIdStr = table.Column<int>(nullable: false),
                    AverageSpeed = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    AverageWatts = table.Column<double>(nullable: false),
                    KiloJoules = table.Column<double>(nullable: false),
                    DeviceWatts = table.Column<bool>(nullable: false),
                    HasHeartrate = table.Column<bool>(nullable: false),
                    HeartrateOptOut = table.Column<bool>(nullable: false),
                    DisplayHideHeartrateOption = table.Column<bool>(nullable: false),
                    ElevHigh = table.Column<double>(nullable: false),
                    ElevLow = table.Column<double>(nullable: false),
                    PRCount = table.Column<int>(nullable: false),
                    TotalPhotoCount = table.Column<int>(nullable: false),
                    HasKudoed = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Calories = table.Column<double>(nullable: false),
                    False = table.Column<bool>(nullable: false),
                    PreferPerceivedExertion = table.Column<bool>(nullable: false),
                    DeviceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_Athlete_AthleteId",
                        column: x => x.AthleteId,
                        principalTable: "Athlete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_AthleteId",
                table: "Activity",
                column: "AthleteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");
        }
    }
}
