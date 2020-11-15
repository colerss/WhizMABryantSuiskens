﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhizMA.Data;

namespace WhizMA.Migrations
{
    [DbContext(typeof(WhizMAContext))]
    [Migration("20201114191439_LEsinhoudaanpassen")]
    partial class LEsinhoudaanpassen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WhizMA.Areas.Identity.Data.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WhizMA.Models.AccountCatalogus", b =>
                {
                    b.Property<int>("CatalogusItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CursusID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerloopTijd")
                        .HasColumnType("datetime2");

                    b.Property<int>("Voortgang")
                        .HasColumnType("int");

                    b.HasKey("CatalogusItemID");

                    b.HasIndex("AccountId");

                    b.HasIndex("CursusID");

                    b.ToTable("AccountCatalogus");
                });

            modelBuilder.Entity("WhizMA.Models.Bundel", b =>
                {
                    b.Property<int>("BundelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afbeelding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BundelBeschrijvingID")
                        .HasColumnType("int");

                    b.Property<decimal>("HuidigePrijs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StandaardPrijs")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BundelID");

                    b.HasIndex("BundelBeschrijvingID")
                        .IsUnique();

                    b.ToTable("Bundels");
                });

            modelBuilder.Entity("WhizMA.Models.BundelBeschrijving", b =>
                {
                    b.Property<int>("BundelBeschrijvingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BundelInhoudsBeschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BundelBeschrijvingID");

                    b.ToTable("BundelBeschrijving");
                });

            modelBuilder.Entity("WhizMA.Models.BundelInhoud", b =>
                {
                    b.Property<int>("BundelInhoudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BundelID")
                        .HasColumnType("int");

                    b.Property<int>("CursusID")
                        .HasColumnType("int");

                    b.HasKey("BundelInhoudID");

                    b.HasIndex("BundelID");

                    b.HasIndex("CursusID");

                    b.ToTable("BundelInhoud");
                });

            modelBuilder.Entity("WhizMA.Models.Cursus", b =>
                {
                    b.Property<int>("CursusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afbeelding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BeschikbaarheidInMaanden")
                        .HasColumnType("int");

                    b.Property<int>("CursusBeschrijvingID")
                        .HasColumnType("int");

                    b.Property<int>("DocentID")
                        .HasColumnType("int");

                    b.Property<bool>("Gecertificieerd")
                        .HasColumnType("bit");

                    b.Property<decimal>("HuidigePrijs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StandaardPrijs")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CursusID");

                    b.HasIndex("CursusBeschrijvingID")
                        .IsUnique();

                    b.HasIndex("DocentID");

                    b.ToTable("Cursussen");
                });

            modelBuilder.Entity("WhizMA.Models.CursusBeschrijving", b =>
                {
                    b.Property<int>("CursusBeschrijvingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificaatBeschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InhoudBeschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CursusBeschrijvingID");

                    b.ToTable("CursusBeschrijving");
                });

            modelBuilder.Entity("WhizMA.Models.CursusInhoud", b =>
                {
                    b.Property<int>("CursusInhoudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursusID")
                        .HasColumnType("int");

                    b.Property<int>("LesID")
                        .HasColumnType("int");

                    b.Property<int>("LesIntervalWeken")
                        .HasColumnType("int");

                    b.Property<int>("Positie")
                        .HasColumnType("int");

                    b.HasKey("CursusInhoudID");

                    b.HasIndex("CursusID");

                    b.HasIndex("LesID");

                    b.ToTable("CursusInhoud");
                });

            modelBuilder.Entity("WhizMA.Models.Docent", b =>
                {
                    b.Property<int>("DocentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocentAfbeeldingURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocentBio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocentFB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocentIG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocentNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocentPin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocentTitel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocentID");

                    b.ToTable("Docenten");
                });

            modelBuilder.Entity("WhizMA.Models.InfoNode", b =>
                {
                    b.Property<int>("InfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursusBeschrijvingID")
                        .HasColumnType("int");

                    b.Property<string>("Subtitel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("afbeelding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InfoID");

                    b.HasIndex("CursusBeschrijvingID");

                    b.ToTable("InfoNodes");
                });

            modelBuilder.Entity("WhizMA.Models.Les", b =>
                {
                    b.Property<int>("LesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LesID");

                    b.ToTable("Lessen");
                });

            modelBuilder.Entity("WhizMA.Models.LesStap", b =>
                {
                    b.Property<int>("LesStapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LesID")
                        .HasColumnType("int");

                    b.Property<int>("LesStapNaam")
                        .HasColumnType("int");

                    b.Property<string>("LesStapText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StapIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StapTimeStamp")
                        .HasColumnType("time");

                    b.Property<string>("VideoAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LesStapID");

                    b.HasIndex("LesID");

                    b.ToTable("LesStap");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WhizMA.Areas.Identity.Data.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WhizMA.Areas.Identity.Data.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WhizMA.Areas.Identity.Data.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WhizMA.Areas.Identity.Data.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.AccountCatalogus", b =>
                {
                    b.HasOne("WhizMA.Areas.Identity.Data.Account", "Account")
                        .WithMany("AccountCatalogus")
                        .HasForeignKey("AccountId");

                    b.HasOne("WhizMA.Models.Cursus", "Cursus")
                        .WithMany("AccountCatalogus")
                        .HasForeignKey("CursusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.Bundel", b =>
                {
                    b.HasOne("WhizMA.Models.BundelBeschrijving", "BundelBeschrijving")
                        .WithOne("Bundel")
                        .HasForeignKey("WhizMA.Models.Bundel", "BundelBeschrijvingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.BundelInhoud", b =>
                {
                    b.HasOne("WhizMA.Models.Bundel", "Bundel")
                        .WithMany("BundelInhoud")
                        .HasForeignKey("BundelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WhizMA.Models.Cursus", "Cursus")
                        .WithMany("BundelInhoud")
                        .HasForeignKey("CursusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.Cursus", b =>
                {
                    b.HasOne("WhizMA.Models.CursusBeschrijving", "CursusBeschrijving")
                        .WithOne("Cursus")
                        .HasForeignKey("WhizMA.Models.Cursus", "CursusBeschrijvingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WhizMA.Models.Docent", "Docent")
                        .WithMany("Cursussen")
                        .HasForeignKey("DocentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.CursusInhoud", b =>
                {
                    b.HasOne("WhizMA.Models.Cursus", "Cursus")
                        .WithMany("CursusInhoud")
                        .HasForeignKey("CursusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WhizMA.Models.Les", "Les")
                        .WithMany("CursusInhouden")
                        .HasForeignKey("LesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.InfoNode", b =>
                {
                    b.HasOne("WhizMA.Models.CursusBeschrijving", "CursusBeschrijving")
                        .WithMany("InfoNodes")
                        .HasForeignKey("CursusBeschrijvingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WhizMA.Models.LesStap", b =>
                {
                    b.HasOne("WhizMA.Models.Les", "Les")
                        .WithMany("LesStappen")
                        .HasForeignKey("LesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
