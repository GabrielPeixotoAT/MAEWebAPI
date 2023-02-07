﻿// <auto-generated />
using System;
using MAEWebAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MAEWebAPI.Migrations
{
    [DbContext(typeof(SubjectContext))]
    [Migration("20230204164805_CriandoTabelaClassSchedule")]
    partial class CriandoTabelaClassSchedule
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.ClassSchedule", b =>
                {
                    b.Property<int>("ClassScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("SubjectIDFK")
                        .HasColumnType("int");

                    b.HasKey("ClassScheduleID");

                    b.ToTable("ClassSchedules");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
