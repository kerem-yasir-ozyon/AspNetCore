﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelApp.Data;

#nullable disable

namespace OtelApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OtelApp.Data.Entities.Otel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OtelTuruId")
                        .HasColumnType("int");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<int>("Telefon")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.Property<byte>("YildizSayisi")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("OtelTuruId");

                    b.HasIndex("SehirId");

                    b.HasIndex("UlkeId");

                    b.ToTable("Otels");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.OtelKapasite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Kapasite")
                        .HasColumnType("int");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OtelId");

                    b.ToTable("OtelKapasiteler");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.OtelOda", b =>
                {
                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.HasKey("OdaId", "OtelId");

                    b.ToTable("Odalar");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.OtelTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OtelTurus");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.Otel", b =>
                {
                    b.HasOne("OtelApp.Data.Entities.OtelTuru", "OtelTuru")
                        .WithMany()
                        .HasForeignKey("OtelTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelApp.Data.Entities.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelApp.Data.Entities.Ulke", "Ulke")
                        .WithMany()
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OtelTuru");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.OtelKapasite", b =>
                {
                    b.HasOne("OtelApp.Data.Entities.Otel", "Otel")
                        .WithMany("OtelKapasiteler")
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otel");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.Sehir", b =>
                {
                    b.HasOne("OtelApp.Data.Entities.Ulke", "Ulke")
                        .WithMany("Sehirler")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.Otel", b =>
                {
                    b.Navigation("OtelKapasiteler");
                });

            modelBuilder.Entity("OtelApp.Data.Entities.Ulke", b =>
                {
                    b.Navigation("Sehirler");
                });
#pragma warning restore 612, 618
        }
    }
}