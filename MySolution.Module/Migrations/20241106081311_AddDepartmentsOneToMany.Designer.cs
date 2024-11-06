﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySolution.Module.BusinessObjects;

#nullable disable

namespace MySolution.Module.Migrations
{
    [DbContext(typeof(MySolutionEFCoreDbContext))]
    [Migration("20241106081311_AddDepartmentsOneToMany")]
    partial class AddDepartmentsOneToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", true)
                .HasAnnotation("Proxies:CheckEquality", true)
                .HasAnnotation("Proxies:LazyLoading", false)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleOfCourtesy_Int")
                        .HasColumnType("int");

                    b.Property<string>("WebPageAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
