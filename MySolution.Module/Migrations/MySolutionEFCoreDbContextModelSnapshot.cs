﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySolution.Module.BusinessObjects;

#nullable disable

namespace MySolution.Module.Migrations
{
    [DbContext(typeof(MySolutionEFCoreDbContext))]
    partial class MySolutionEFCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", true)
                .HasAnnotation("Proxies:CheckEquality", true)
                .HasAnnotation("Proxies:LazyLoading", false)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoTaskEmployee", b =>
                {
                    b.Property<Guid>("DemoTasksID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeesID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DemoTasksID", "EmployeesID");

                    b.HasIndex("EmployeesID");

                    b.ToTable("DemoTaskEmployee");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.FileData", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("FileData");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyActionPermissionObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PermissionPolicyActionPermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyMemberPermissionsObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Criteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Members")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReadState")
                        .HasColumnType("int");

                    b.Property<Guid?>("TypePermissionObjectID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("WriteState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TypePermissionObjectID");

                    b.ToTable("PermissionPolicyMemberPermissionsObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyNavigationPermissionObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NavigateState")
                        .HasColumnType("int");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TargetTypeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PermissionPolicyNavigationPermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyObjectPermissionsObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Criteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeleteState")
                        .HasColumnType("int");

                    b.Property<int?>("NavigateState")
                        .HasColumnType("int");

                    b.Property<int?>("ReadState")
                        .HasColumnType("int");

                    b.Property<Guid?>("TypePermissionObjectID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("WriteState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TypePermissionObjectID");

                    b.ToTable("PermissionPolicyObjectPermissionsObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CanEditModel")
                        .HasColumnType("bit");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(34)
                        .HasColumnType("nvarchar(34)");

                    b.Property<bool>("IsAdministrative")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAllowPermissionPriority")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermissionPolicy")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PermissionPolicyRoleBase");

                    b.HasDiscriminator().HasValue("PermissionPolicyRoleBase");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CreateState")
                        .HasColumnType("int");

                    b.Property<int?>("DeleteState")
                        .HasColumnType("int");

                    b.Property<int?>("NavigateState")
                        .HasColumnType("int");

                    b.Property<int?>("ReadState")
                        .HasColumnType("int");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TargetTypeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WriteState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PermissionPolicyTypePermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyUser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ChangePasswordOnFirstLogon")
                        .HasColumnType("bit");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StoredPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PermissionPolicyUser");

                    b.HasDiscriminator().HasValue("PermissionPolicyUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.ReportDataV2", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DataTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInplaceReport")
                        .HasColumnType("bit");

                    b.Property<string>("ParametersObjectTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PredefinedReportTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ReportData");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipPostal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.ApplicationUserLoginInfo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderUserKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserForeignKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("PermissionPolicyUserLoginInfo");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.DemoTask", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PercentCompleted")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DemoTasks");
                });

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

                    b.Property<Guid?>("AddressID")
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

                    b.Property<Guid?>("ManagerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PositionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TitleOfCourtesy_Int")
                        .HasColumnType("int");

                    b.Property<string>("WebPageAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("ManagerID");

                    b.HasIndex("PositionID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Note", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.PhoneNumber", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("PhoneNumber");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.PortfolioFileData", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<Guid?>("FileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ResumeID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("FileID");

                    b.HasIndex("ResumeID");

                    b.ToTable("FileAttachments");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Position", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Resume", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FileID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("FileID");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Hours")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<double>("USDCourse")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PermissionPolicyRolePermissionPolicyUser", b =>
                {
                    b.Property<Guid>("RolesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesID", "UsersID");

                    b.HasIndex("UsersID");

                    b.ToTable("PermissionPolicyRolePermissionPolicyUser");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRole", b =>
                {
                    b.HasBaseType("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase");

                    b.HasDiscriminator().HasValue("PermissionPolicyRole");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.ApplicationUser", b =>
                {
                    b.HasBaseType("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("DemoTaskEmployee", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.DemoTask", null)
                        .WithMany()
                        .HasForeignKey("DemoTasksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySolution.Module.BusinessObjects.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyActionPermissionObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", "Role")
                        .WithMany("ActionPermissions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyMemberPermissionsObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", "TypePermissionObject")
                        .WithMany("MemberPermissions")
                        .HasForeignKey("TypePermissionObjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("TypePermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyNavigationPermissionObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", "Role")
                        .WithMany("NavigationPermissions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyObjectPermissionsObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", "TypePermissionObject")
                        .WithMany("ObjectPermissions")
                        .HasForeignKey("TypePermissionObjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("TypePermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", "Role")
                        .WithMany("TypePermissions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.ApplicationUserLoginInfo", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.ApplicationUser", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("MySolution.Module.BusinessObjects.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MySolution.Module.BusinessObjects.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID");

                    b.HasOne("MySolution.Module.BusinessObjects.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID");

                    b.Navigation("Address");

                    b.Navigation("Department");

                    b.Navigation("Manager");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.PhoneNumber", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.Employee", "Employee")
                        .WithMany("Phones")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.PortfolioFileData", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.FileData", "File")
                        .WithMany()
                        .HasForeignKey("FileID");

                    b.HasOne("MySolution.Module.BusinessObjects.Resume", "Resume")
                        .WithMany("Portfolio")
                        .HasForeignKey("ResumeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("File");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Resume", b =>
                {
                    b.HasOne("MySolution.Module.BusinessObjects.Employee", "Employee")
                        .WithMany("Resumes")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.FileData", "File")
                        .WithMany()
                        .HasForeignKey("FileID");

                    b.Navigation("Employee");

                    b.Navigation("File");
                });

            modelBuilder.Entity("PermissionPolicyRolePermissionPolicyUser", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRole", null)
                        .WithMany()
                        .HasForeignKey("RolesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyUser", null)
                        .WithMany()
                        .HasForeignKey("UsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", b =>
                {
                    b.Navigation("ActionPermissions");

                    b.Navigation("NavigationPermissions");

                    b.Navigation("TypePermissions");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", b =>
                {
                    b.Navigation("MemberPermissions");

                    b.Navigation("ObjectPermissions");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Employee", b =>
                {
                    b.Navigation("Phones");

                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.Resume", b =>
                {
                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("MySolution.Module.BusinessObjects.ApplicationUser", b =>
                {
                    b.Navigation("UserLogins");
                });
#pragma warning restore 612, 618
        }
    }
}
