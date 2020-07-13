﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200713172201_InitialTablesData")]
    partial class InitialTablesData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entity.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Gender");

                    b.Property<int>("ManagerId");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Role");

                    b.Property<int>("VacationDaysAllowedYearly");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1994, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "Admin@gmail.com",
                            Gender = "Male",
                            ManagerId = 1,
                            MobileNumber = "055555",
                            Name = "abdullah salem",
                            Role = "Admin",
                            VacationDaysAllowedYearly = 30
                        });
                });

            modelBuilder.Entity("Core.Entity.Holiday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("HolidayEndDate")
                        .HasColumnType("date");

                    b.Property<string>("HolidayReason");

                    b.Property<DateTime>("HolidayStartDate")
                        .HasColumnType("date");

                    b.Property<string>("HolidayStatus");

                    b.HasKey("Id");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("Core.Entity.Login", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Password");

                    b.HasKey("EmployeeId");

                    b.ToTable("Logins");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            EmailAddress = "Admin@gmail.com",
                            Password = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}