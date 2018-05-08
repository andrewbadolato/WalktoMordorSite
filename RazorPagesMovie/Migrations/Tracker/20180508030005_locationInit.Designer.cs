﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WalktoMordor.Models;

namespace WalktoMordor.Migrations.Tracker
{
    [DbContext(typeof(TrackerContext))]
    [Migration("20180508030005_locationInit")]
    partial class locationInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WalktoMordor.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EndLocation");

                    b.Property<decimal>("GoalMiles");

                    b.Property<string>("StartLocation");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("WalktoMordor.Models.Tracker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("DistCount");

                    b.Property<decimal>("DistTotal");

                    b.Property<decimal>("Distance");

                    b.Property<string>("OwnerID");

                    b.HasKey("ID");

                    b.ToTable("Tracker");
                });
#pragma warning restore 612, 618
        }
    }
}
