﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SubjectAPI.Models;

#nullable disable

namespace SubjectAPI.Migrations
{
    [DbContext(typeof(SubjectDbContext))]
    partial class SubjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SubjectAPI.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<sbyte>("NumberOfHours")
                        .HasColumnType("tinyint");

                    b.Property<string>("SubjectName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
