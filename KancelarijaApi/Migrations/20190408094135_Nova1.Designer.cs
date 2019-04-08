﻿// <auto-generated />
using System;
using KancelarijaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KancelarijaApi.Migrations
{
    [DbContext(typeof(KancelarijApiContext))]
    [Migration("20190408094135_Nova1")]
    partial class Nova1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KancelarijaApi.Kancelarija", b =>
                {
                    b.Property<long>("KancelarijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis");

                    b.HasKey("KancelarijaId");

                    b.ToTable("Kancelarije");
                });

            modelBuilder.Entity("KancelarijaApi.Models.Osoba", b =>
                {
                    b.Property<long>("OsobaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime");

                    b.Property<long>("KancelarijaId");

                    b.Property<string>("Prezime");

                    b.HasKey("OsobaId");

                    b.HasIndex("KancelarijaId");

                    b.ToTable("Osobe");
                });

            modelBuilder.Entity("KancelarijaApi.Models.OsobaUredjaj", b =>
                {
                    b.Property<long>("OsobaUredjajId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("OsobaId");

                    b.Property<long>("UredjajId");

                    b.Property<DateTime?>("VrijemeDo");

                    b.Property<DateTime>("VrijemeOd");

                    b.HasKey("OsobaUredjajId");

                    b.HasIndex("OsobaId");

                    b.HasIndex("UredjajId");

                    b.ToTable("OsobeUredjaji");
                });

            modelBuilder.Entity("KancelarijaApi.Models.Uredjaj", b =>
                {
                    b.Property<long>("UredjajId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("OsobaId");

                    b.Property<string>("UredjajIme");

                    b.HasKey("UredjajId");

                    b.HasIndex("OsobaId");

                    b.ToTable("Uredjaji");
                });

            modelBuilder.Entity("KancelarijaApi.Models.Osoba", b =>
                {
                    b.HasOne("KancelarijaApi.Kancelarija", "Kancelarija")
                        .WithMany("ListaOsobe")
                        .HasForeignKey("KancelarijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KancelarijaApi.Models.OsobaUredjaj", b =>
                {
                    b.HasOne("KancelarijaApi.Models.Osoba", "Osoba")
                        .WithMany("ListaKoriscenje")
                        .HasForeignKey("OsobaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KancelarijaApi.Models.Uredjaj", "Uredjaj")
                        .WithMany("ListaKoriscenje")
                        .HasForeignKey("UredjajId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KancelarijaApi.Models.Uredjaj", b =>
                {
                    b.HasOne("KancelarijaApi.Models.Osoba", "Osoba")
                        .WithMany("ListaUredjaji")
                        .HasForeignKey("OsobaId");
                });
#pragma warning restore 612, 618
        }
    }
}
