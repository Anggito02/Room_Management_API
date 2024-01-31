﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Room_Management_API.Infrastructure.RoomsInfrastructure;

#nullable disable

namespace Room_Management_API.Infrastructure.Migrations
{
    [DbContext(typeof(RoomsDbContext))]
    partial class RoomsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomFacilities", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ROOM_FACILITIES");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomFacility", b =>
                {
                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomFacilitiesId")
                        .HasColumnType("uuid");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RoomsId")
                        .HasColumnType("uuid");

                    b.HasKey("RoomId", "RoomFacilitiesId");

                    b.HasIndex("RoomFacilitiesId");

                    b.HasIndex("RoomsId");

                    b.ToTable("ROOM_FACILITY");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomMedia", b =>
                {
                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomMediasId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.HasKey("RoomId", "RoomMediasId");

                    b.HasIndex("RoomMediasId");

                    b.ToTable("ROOM_MEDIA");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomMedias", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AltText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeletedAt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ROOM_MEDIAS");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ROOM_STATUS");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ROOM_TYPE");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.Rooms", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<decimal>("RoomArea")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RoomStatusId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomTypeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoomStatusId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("ROOMS");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomFacility", b =>
                {
                    b.HasOne("Room_Management_API.Domain.Rooms.RoomFacilities", null)
                        .WithMany("RoomFacility")
                        .HasForeignKey("RoomFacilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Room_Management_API.Domain.Rooms.Rooms", null)
                        .WithMany("RoomFacility")
                        .HasForeignKey("RoomsId");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomMedia", b =>
                {
                    b.HasOne("Room_Management_API.Domain.Rooms.Rooms", "Room")
                        .WithMany("RoomMedia")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Room_Management_API.Domain.Rooms.RoomMedias", "RoomMedias")
                        .WithMany("RoomMedia")
                        .HasForeignKey("RoomMediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("RoomMedias");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.Rooms", b =>
                {
                    b.HasOne("Room_Management_API.Domain.Rooms.RoomStatus", "RoomStatus")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Room_Management_API.Domain.Rooms.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomStatus");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomFacilities", b =>
                {
                    b.Navigation("RoomFacility");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomMedias", b =>
                {
                    b.Navigation("RoomMedia");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomStatus", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Room_Management_API.Domain.Rooms.Rooms", b =>
                {
                    b.Navigation("RoomFacility");

                    b.Navigation("RoomMedia");
                });
#pragma warning restore 612, 618
        }
    }
}