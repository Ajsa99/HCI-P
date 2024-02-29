﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using junBackend;

#nullable disable

namespace junBackend.Migrations
{
    [DbContext(typeof(DbC))]
    [Migration("20230815134302_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("junBackend.Model.Aktivnost", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("datum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prioritet")
                        .HasColumnType("int");

                    b.Property<string>("tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vreme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("aktivnost");
                });

            modelBuilder.Entity("junBackend.Model.Korisnik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("korisnik");
                });
#pragma warning restore 612, 618
        }
    }
}
