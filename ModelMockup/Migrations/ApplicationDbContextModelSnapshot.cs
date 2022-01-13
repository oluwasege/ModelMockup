﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelMockup;

namespace ModelMockup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelMockup.BankInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankInformations");
                });

            modelBuilder.Entity("ModelMockup.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ModelMockup.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ModelMockup.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BankInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeOfficeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NextOfKinId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PayrollId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BankInformationId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobId");

                    b.HasIndex("NextOfKinId");

                    b.HasIndex("PayrollId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ModelMockup.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<decimal>("OvertimeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("ModelMockup.JobRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobRoles");
                });

            modelBuilder.Entity("ModelMockup.NextOfKin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Relationship")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NextOfKins");
                });

            modelBuilder.Entity("ModelMockup.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NotificationStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("ModelMockup.Payroll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AmountOfHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AmountOfOvertime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GrossAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NoOfHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NoOfOvertimeHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Payrolls");
                });

            modelBuilder.Entity("ModelMockup.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleTypeId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ModelMockup.RoleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleTypes");
                });

            modelBuilder.Entity("ModelMockup.TimeSheet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ClockIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClockOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("HoursSpent")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<DateTime>("OvertimeHours")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedClockIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedClockOut")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TimeSheets");
                });

            modelBuilder.Entity("ModelMockup.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ModelMockup.Company", b =>
                {
                    b.HasOne("ModelMockup.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ModelMockup.Employee", b =>
                {
                    b.HasOne("ModelMockup.BankInformation", "BankInformation")
                        .WithMany()
                        .HasForeignKey("BankInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelMockup.Company", null)
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("ModelMockup.Job", null)
                        .WithMany("Employees")
                        .HasForeignKey("JobId");

                    b.HasOne("ModelMockup.NextOfKin", "NextOfKin")
                        .WithMany()
                        .HasForeignKey("NextOfKinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelMockup.Payroll", null)
                        .WithMany("Employees")
                        .HasForeignKey("PayrollId");

                    b.HasOne("ModelMockup.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankInformation");

                    b.Navigation("NextOfKin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ModelMockup.Job", b =>
                {
                    b.HasOne("ModelMockup.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ModelMockup.JobRoles", b =>
                {
                    b.HasOne("ModelMockup.Company", null)
                        .WithMany("Jobroles")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("ModelMockup.Role", b =>
                {
                    b.HasOne("ModelMockup.RoleType", "RoleType")
                        .WithMany()
                        .HasForeignKey("RoleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleType");
                });

            modelBuilder.Entity("ModelMockup.TimeSheet", b =>
                {
                    b.HasOne("ModelMockup.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelMockup.Employee", "Employee")
                        .WithMany("TimeSheets")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ModelMockup.User", b =>
                {
                    b.HasOne("ModelMockup.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ModelMockup.Company", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Jobroles");
                });

            modelBuilder.Entity("ModelMockup.Employee", b =>
                {
                    b.Navigation("TimeSheets");
                });

            modelBuilder.Entity("ModelMockup.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ModelMockup.Payroll", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
