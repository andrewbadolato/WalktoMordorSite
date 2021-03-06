﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WalktoMordor.Models;
using System;

namespace WalktoMordor.Migrations.Tracker
{
    [DbContext(typeof(TrackerContext))]
    [Migration("20180508012224_distancecalcs")]
    partial class distancecalcs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
