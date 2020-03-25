﻿// <auto-generated />
using System;
using LeMieAttivita.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeMieAttivita.Migrations
{
    [DbContext(typeof(LeMieAttivitaContext))]
    [Migration("20200211135045_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LeMieAttivita.Models.Athlete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.ToTable("Athlete");
                });
#pragma warning restore 612, 618
        }
    }
}
