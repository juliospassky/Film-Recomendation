﻿// <auto-generated />
using System;
using GTSharp.Domain.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GTSharp.Domain.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200327020830_Pack001_Initial")]
    partial class Pack001_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GTSharp.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("IdGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieIdMovie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.HasKey("IdGenre");

                    b.HasIndex("MovieIdMovie");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("GTSharp.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(10,0)");

                    b.Property<string>("OriginalTitle")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<decimal>("Popularity")
                        .HasColumnType("decimal(10,0)");

                    b.Property<string>("PosterPath")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("VoteAverage")
                        .HasColumnType("float");

                    b.Property<double>("VoteCount")
                        .HasColumnType("float");

                    b.HasKey("IdMovie");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("GTSharp.Domain.Entities.Overview", b =>
                {
                    b.Property<int>("IdOverview")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieIdMovie")
                        .HasColumnType("int");

                    b.HasKey("IdOverview");

                    b.HasIndex("MovieIdMovie");

                    b.ToTable("Overview");
                });

            modelBuilder.Entity("GTSharp.Domain.Entities.Genre", b =>
                {
                    b.HasOne("GTSharp.Domain.Entities.Movie", "Movie")
                        .WithMany("Genres")
                        .HasForeignKey("MovieIdMovie");
                });

            modelBuilder.Entity("GTSharp.Domain.Entities.Overview", b =>
                {
                    b.HasOne("GTSharp.Domain.Entities.Movie", "Movie")
                        .WithMany("Overviews")
                        .HasForeignKey("MovieIdMovie");
                });
#pragma warning restore 612, 618
        }
    }
}