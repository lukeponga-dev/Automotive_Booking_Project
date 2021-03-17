﻿// <auto-generated />
using System;
using Automotive_Booking_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Automotive_Booking_Project.Migrations
{
    [DbContext(typeof(Automotive_Booking_ProjectContext))]
    [Migration("20210317205742_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Automotive_Booking_Project.Models.BookingReason", b =>
                {
                    b.Property<int>("BookingReason_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingReason_Id");

                    b.ToTable("BookingReason");
                });

            modelBuilder.Entity("Automotive_Booking_Project.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Automotive_Booking_Project.Models.Users", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Automotive_Booking_Project.Models.bookings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingReason_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BookingReason_Id1")
                        .HasColumnType("int");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUser_Id")
                        .HasColumnType("int");

                    b.Property<int>("staff_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingReason_Id1");

                    b.HasIndex("StaffId");

                    b.HasIndex("UsersUser_Id");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("Automotive_Booking_Project.Models.bookings", b =>
                {
                    b.HasOne("Automotive_Booking_Project.Models.BookingReason", "BookingReason")
                        .WithMany()
                        .HasForeignKey("BookingReason_Id1");

                    b.HasOne("Automotive_Booking_Project.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");

                    b.HasOne("Automotive_Booking_Project.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersUser_Id");
                });
#pragma warning restore 612, 618
        }
    }
}