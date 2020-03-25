﻿// <auto-generated />
using System;
using LeMieAttivita.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeMieAttivita.Migrations
{
    [DbContext(typeof(LeMieAttivitaContext))]
    partial class LeMieAttivitaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LeMieAttivita.Models.Activity", b =>
                {
                    b.Property<double>("Id");

                    b.Property<int>("AchievementCount");

                    b.Property<int>("AthleteCount");

                    b.Property<int>("AthleteId");

                    b.Property<double>("AverageSpeed");

                    b.Property<double>("AverageWatts");

                    b.Property<double>("Calories");

                    b.Property<int>("CommentCount");

                    b.Property<bool>("Commute");

                    b.Property<string>("Description");

                    b.Property<string>("DeviceName");

                    b.Property<bool>("DeviceWatts");

                    b.Property<bool>("DisplayHideHeartrateOption");

                    b.Property<double>("Distance");

                    b.Property<string>("ElapsedTime");

                    b.Property<double>("ElevHigh");

                    b.Property<double>("ElevLow");

                    b.Property<bool>("False");

                    b.Property<bool>("Flagged");

                    b.Property<string>("GearId");

                    b.Property<bool>("HasHeartrate");

                    b.Property<bool>("HasKudoed");

                    b.Property<bool>("HeartrateOptOut");

                    b.Property<double>("KiloJoules");

                    b.Property<int>("KudosCount");

                    b.Property<string>("LocationCity");

                    b.Property<string>("LocationCountry");

                    b.Property<string>("LocationState");

                    b.Property<bool>("Manual");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("MovingTime");

                    b.Property<string>("Name");

                    b.Property<int>("PRCount");

                    b.Property<int>("PhotoCount");

                    b.Property<bool>("PreferPerceivedExertion");

                    b.Property<bool>("Private");

                    b.Property<string>("Ride");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("StartDateLocal");

                    b.Property<string>("StartLatitude");

                    b.Property<string>("StartLongitude");

                    b.Property<string>("Timezone");

                    b.Property<double>("TotalElevationGain");

                    b.Property<int>("TotalPhotoCount");

                    b.Property<bool>("Trainer");

                    b.Property<double>("UtcOffset");

                    b.Property<string>("Visibility");

                    b.Property<int>("WorkoutType");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("LeMieAttivita.Models.ApiToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessToken");

                    b.Property<string>("ClientId");

                    b.Property<string>("ClientSecret");

                    b.Property<DateTime>("ExpiresAt");

                    b.Property<int>("ExpiresIn");

                    b.Property<string>("RefreshToken");

                    b.Property<DateTime>("RetrievalDate");

                    b.Property<string>("TokenType");

                    b.HasKey("Id");

                    b.ToTable("ApiToken");
                });

            modelBuilder.Entity("LeMieAttivita.Models.Athlete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApiTokenId");

                    b.Property<int>("AthleteType");

                    b.Property<int>("BadgeTypeId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("DatePreference");

                    b.Property<string>("FTP");

                    b.Property<string>("FirstName");

                    b.Property<string>("Follower");

                    b.Property<int>("FollowerCount");

                    b.Property<string>("Friend");

                    b.Property<int>("FriendCount");

                    b.Property<string>("LastName");

                    b.Property<string>("MeasurementPreference");

                    b.Property<int>("MutualFriendCount");

                    b.Property<string>("Premium");

                    b.Property<string>("ProfilePicLarge");

                    b.Property<string>("ProfilePicMedium");

                    b.Property<int>("ResourceState");

                    b.Property<string>("Sex");

                    b.Property<string>("State");

                    b.Property<string>("Summit");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Username");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ApiTokenId");

                    b.ToTable("Athlete");
                });

            modelBuilder.Entity("LeMieAttivita.Models.Activity", b =>
                {
                    b.HasOne("LeMieAttivita.Models.Athlete", "Athlete")
                        .WithMany()
                        .HasForeignKey("AthleteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LeMieAttivita.Models.Athlete", b =>
                {
                    b.HasOne("LeMieAttivita.Models.ApiToken", "ApiToken")
                        .WithMany()
                        .HasForeignKey("ApiTokenId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
