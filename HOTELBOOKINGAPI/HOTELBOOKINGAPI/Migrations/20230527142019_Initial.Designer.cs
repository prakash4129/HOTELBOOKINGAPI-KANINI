﻿using HOTELBOOKINGAPI.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;


{
    public class _20230527142019_Initial
    {
    }
}


﻿// <auto-generated />
using System;
using HOTELBOOKINGAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HOTELBOOKINGAPI.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230527142019_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HOTELBOOKINGAPI.Models.Hotels", b =>
            {
                b.Property<int>("HotelId")
                    .HasColumnType("int");

                b.Property<string>("HotelName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Phone")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Place")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("HotelId");

                b.ToTable("hotels");
            });

            modelBuilder.Entity("HOTELBOOKINGAPI.Models.Rooms", b =>
            {
                b.Property<int>("RoomId")
                    .HasColumnType("int");

                b.Property<int>("HotelId")
                    .HasColumnType("int");

                b.Property<int?>("HotelsHotelId")
                    .HasColumnType("int");

                b.Property<string>("RoomPricePerNight")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoomStatus")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoomType")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("RoomId");

                b.HasIndex("HotelsHotelId");

                b.ToTable("rooms");
            });

            modelBuilder.Entity("HOTELBOOKINGAPI.Models.User", b =>
            {
                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Roles")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserEmail")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId");

                b.ToTable("users");
            });

            modelBuilder.Entity(HOTELBOOKINGAPI.Models.Rooms", b =>
            {
                b.HasOne("HOTELBOOKINGAPI.Models.Hotels", null)
                    .WithMany("rooms")
                    .HasForeignKey("HotelsHotelId");
            });

            modelBuilder.Entity("HOTELBOOKINGAPI.Models.Hotels", b =>
            {
                b.Navigation("rooms");
            });
#pragma warning restore 612, 618
        }
    }
}