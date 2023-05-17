﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using crud_api.Data;

#nullable disable

namespace crud_api.Migrations
{
    [DbContext(typeof(PersonApiDbContext))]
    [Migration("20230517093914_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("crud_api.Model.Device", b =>
                {
                    b.Property<int>("device_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("device_Id"));

                    b.Property<string>("device_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("device_Id");

                    b.ToTable("tbl_Device");
                });

            modelBuilder.Entity("crud_api.Model.Person", b =>
                {
                    b.Property<Guid>("person_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("device_Id")
                        .HasColumnType("integer");

                    b.Property<int>("device_Id1")
                        .HasColumnType("integer");

                    b.Property<string>("person_Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("person_Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("person_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("person_Phone")
                        .HasColumnType("bigint");

                    b.HasKey("person_Id");

                    b.HasIndex("device_Id1");

                    b.ToTable("tbl_Person");
                });

            modelBuilder.Entity("crud_api.Model.Person", b =>
                {
                    b.HasOne("crud_api.Model.Device", "Device")
                        .WithMany()
                        .HasForeignKey("device_Id1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });
#pragma warning restore 612, 618
        }
    }
}
