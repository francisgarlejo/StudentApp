﻿// <auto-generated />
using System;
using Assignment1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment1.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    [Migration("20221008050031_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment1.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("GPA")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("GpaScale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudyProgramId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StudentId");

                    b.HasIndex("StudyProgramId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Age = 51,
                            FirstName = "Bart",
                            GPA = 2.7999999999999998,
                            GpaScale = "Satisfactory",
                            LastName = "Simpson",
                            StudyProgramId = "A"
                        },
                        new
                        {
                            StudentId = 2,
                            Age = 49,
                            FirstName = "Lisa",
                            GPA = 4.0,
                            GpaScale = "Excellent",
                            LastName = "Simpson",
                            StudyProgramId = "B"
                        },
                        new
                        {
                            StudentId = 3,
                            Age = 46,
                            FirstName = "Maggie",
                            GPA = 3.1000000000000001,
                            GpaScale = "Good",
                            LastName = "Simpson",
                            StudyProgramId = "C"
                        });
                });

            modelBuilder.Entity("Assignment1.Entities.StudyProgram", b =>
                {
                    b.Property<string>("StudyProgramId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudyProgramId");

                    b.ToTable("StudyPrograms");

                    b.HasData(
                        new
                        {
                            StudyProgramId = "A",
                            Name = "Computer Programming"
                        },
                        new
                        {
                            StudyProgramId = "B",
                            Name = "Bachelor of Applied Science"
                        },
                        new
                        {
                            StudyProgramId = "C",
                            Name = "Computer Programmer Analyst"
                        },
                        new
                        {
                            StudyProgramId = "D",
                            Name = "IT Innovation and Design"
                        },
                        new
                        {
                            StudyProgramId = "E",
                            Name = "Application and Web Design"
                        },
                        new
                        {
                            StudyProgramId = "F",
                            Name = "Infrastructure Engineer"
                        },
                        new
                        {
                            StudyProgramId = "G",
                            Name = "Software Engineer"
                        });
                });

            modelBuilder.Entity("Assignment1.Entities.Student", b =>
                {
                    b.HasOne("Assignment1.Entities.StudyProgram", "StudyProgram")
                        .WithMany()
                        .HasForeignKey("StudyProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudyProgram");
                });
#pragma warning restore 612, 618
        }
    }
}
