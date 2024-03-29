﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace BaiThi0186.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20230629020322_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BaiThi0186.Models.HVDCau3", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HoVaTen")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("HVDCau3");
                });
#pragma warning restore 612, 618
        }
    }
}
