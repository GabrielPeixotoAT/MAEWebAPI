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
    [Migration("20230207041737_CriaRelacionamentosEntreAsEntidades3")]
    partial class CriaRelacionamentosEntreAsEntidades3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MAEWebAPI.Data.Models.Abstences.Abstence", b =>
                {
                    b.Property<int>("AbstenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassSheduleIDFK")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("SubjectIDFK")
                        .HasColumnType("int");

                    b.HasKey("AbstenceID");

                    b.HasIndex("ClassSheduleIDFK");

                    b.HasIndex("SubjectIDFK");

                    b.ToTable("Abstences");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Abstences.SubjectAbstences", b =>
                {
                    b.Property<int>("SubjectAbstencesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AbstencesCount")
                        .HasColumnType("int");

                    b.Property<int>("SubjectIDFK")
                        .HasColumnType("int");

                    b.HasKey("SubjectAbstencesID");

                    b.HasIndex("SubjectIDFK");

                    b.ToTable("SubjectsAbstences");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.ClassSchedule", b =>
                {
                    b.Property<int>("ClassScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SchoolDayIDFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("SubjectIDFK")
                        .HasColumnType("int");

                    b.HasKey("ClassScheduleID");

                    b.HasIndex("SchoolDayIDFK");

                    b.HasIndex("SubjectIDFK");

                    b.ToTable("ClassSchedules");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.SchoolDay", b =>
                {
                    b.Property<int>("SchoolDayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Description")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SchoolDayID");

                    b.ToTable("SchoolDays");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TotalClasses")
                        .HasColumnType("int");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Abstences.Abstence", b =>
                {
                    b.HasOne("MAEWebAPI.Data.Models.Subjects.ClassSchedule", "ClassSchedule")
                        .WithMany("Abstences")
                        .HasForeignKey("ClassSheduleIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAEWebAPI.Data.Models.Subjects.Subject", "Subject")
                        .WithMany("Abstences")
                        .HasForeignKey("SubjectIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassSchedule");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Abstences.SubjectAbstences", b =>
                {
                    b.HasOne("MAEWebAPI.Data.Models.Subjects.Subject", "Subject")
                        .WithMany("SubjectAbstences")
                        .HasForeignKey("SubjectIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.ClassSchedule", b =>
                {
                    b.HasOne("MAEWebAPI.Data.Models.Subjects.SchoolDay", "SchoolDay")
                        .WithMany("ClassSchedule")
                        .HasForeignKey("SchoolDayIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAEWebAPI.Data.Models.Subjects.Subject", "Subject")
                        .WithMany("ClassSchedules")
                        .HasForeignKey("SubjectIDFK");

                    b.Navigation("SchoolDay");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.ClassSchedule", b =>
                {
                    b.Navigation("Abstences");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.SchoolDay", b =>
                {
                    b.Navigation("ClassSchedule");
                });

            modelBuilder.Entity("MAEWebAPI.Data.Models.Subjects.Subject", b =>
                {
                    b.Navigation("Abstences");

                    b.Navigation("ClassSchedules");

                    b.Navigation("SubjectAbstences");
                });
#pragma warning restore 612, 618
        }
    }
}
