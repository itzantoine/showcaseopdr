﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Showcaseopdr.Data;

#nullable disable

namespace Showcaseopdr.Migrations
{
    [DbContext(typeof(TaskDbContext))]
    [Migration("20230319133903_initialSeedingData")]
    partial class initialSeedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Showcaseopdr.Models.Task", b =>
                {
                    b.Property<int>("TaskNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Present")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskNumberId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskNumberId = 1,
                            Date = new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(2023, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Present = false,
                            StartTime = new DateTime(2023, 3, 19, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            TaskName = "Test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
