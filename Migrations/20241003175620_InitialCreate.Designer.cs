﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MouseTrakerApp.Data;

#nullable disable

namespace MouseTrakerApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241003175620_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MouseTrakerApp.Data.MouseMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoordinatesJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MouseMovements", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
