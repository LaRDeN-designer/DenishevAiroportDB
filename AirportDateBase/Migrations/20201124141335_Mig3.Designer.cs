﻿// <auto-generated />
using System;
using AirportDateBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirportDateBase.Migrations
{
    [DbContext(typeof(AirportDateBaseContext))]
    [Migration("20201124141335_Mig3")]
    partial class Mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AirportDateBase.Models.Crew", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("Employee_1ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Employee_2ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Employee_3ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("FlightID")
                        .HasColumnType("bigint");

                    b.Property<int>("Hours_flown")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FlightID");

                    b.ToTable("Crew");
                });

            modelBuilder.Entity("AirportDateBase.Models.Employee", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("CrewID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CrewID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("CrewID2")
                        .HasColumnType("bigint");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasport_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PlaneID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Posts_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CrewID");

                    b.HasIndex("CrewID1");

                    b.HasIndex("CrewID2");

                    b.HasIndex("PlaneID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("AirportDateBase.Models.Flight", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Arrival")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Crew_ID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Departure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Plane_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TicketsID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Time_flight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TicketsID");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("AirportDateBase.Models.Plane", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_last_repair")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Employee_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("FlightID")
                        .HasColumnType("bigint");

                    b.Property<string>("Hours_flown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Technical_parameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tonnage")
                        .HasColumnType("int");

                    b.Property<long?>("Type_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("FlightID");

                    b.ToTable("Plane");
                });

            modelBuilder.Entity("AirportDateBase.Models.Posts", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Charge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EmployeeID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name_Post")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Request")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("AirportDateBase.Models.Tickets", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("Flight_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name_passenger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasport_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("AirportDateBase.Models.Type_plane", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Limit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_plane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PlaneID")
                        .HasColumnType("bigint");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PlaneID");

                    b.ToTable("Type_plane");
                });

            modelBuilder.Entity("AirportDateBase.Models.Crew", b =>
                {
                    b.HasOne("AirportDateBase.Models.Flight", null)
                        .WithMany("Crews")
                        .HasForeignKey("FlightID");
                });

            modelBuilder.Entity("AirportDateBase.Models.Employee", b =>
                {
                    b.HasOne("AirportDateBase.Models.Crew", null)
                        .WithMany("Employees_1ID")
                        .HasForeignKey("CrewID");

                    b.HasOne("AirportDateBase.Models.Crew", null)
                        .WithMany("Employees_2ID")
                        .HasForeignKey("CrewID1");

                    b.HasOne("AirportDateBase.Models.Crew", null)
                        .WithMany("ID_Employees_3")
                        .HasForeignKey("CrewID2");

                    b.HasOne("AirportDateBase.Models.Plane", null)
                        .WithMany("Employees")
                        .HasForeignKey("PlaneID");
                });

            modelBuilder.Entity("AirportDateBase.Models.Flight", b =>
                {
                    b.HasOne("AirportDateBase.Models.Tickets", null)
                        .WithMany("Flights")
                        .HasForeignKey("TicketsID");
                });

            modelBuilder.Entity("AirportDateBase.Models.Plane", b =>
                {
                    b.HasOne("AirportDateBase.Models.Flight", null)
                        .WithMany("Planes")
                        .HasForeignKey("FlightID");
                });

            modelBuilder.Entity("AirportDateBase.Models.Posts", b =>
                {
                    b.HasOne("AirportDateBase.Models.Employee", null)
                        .WithMany("Posts")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("AirportDateBase.Models.Type_plane", b =>
                {
                    b.HasOne("AirportDateBase.Models.Plane", null)
                        .WithMany("Types")
                        .HasForeignKey("PlaneID");
                });

            modelBuilder.Entity("AirportDateBase.Models.Crew", b =>
                {
                    b.Navigation("Employees_1ID");

                    b.Navigation("Employees_2ID");

                    b.Navigation("ID_Employees_3");
                });

            modelBuilder.Entity("AirportDateBase.Models.Employee", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("AirportDateBase.Models.Flight", b =>
                {
                    b.Navigation("Crews");

                    b.Navigation("Planes");
                });

            modelBuilder.Entity("AirportDateBase.Models.Plane", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("AirportDateBase.Models.Tickets", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
