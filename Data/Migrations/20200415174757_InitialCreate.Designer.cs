﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieAPI.Data;

namespace MovieAPI.Data.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20200415174757_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieAPI.Models.Director", b =>
                {
                    b.Property<string>("DirID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirName");

                    b.Property<string>("MovieMovID");

                    b.HasKey("DirID");

                    b.HasIndex("MovieMovID");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MovieAPI.Models.Genre", b =>
                {
                    b.Property<string>("GenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreType");

                    b.Property<string>("MovieMovID");

                    b.HasKey("GenreID");

                    b.HasIndex("MovieMovID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieAPI.Models.Movie", b =>
                {
                    b.Property<string>("MovID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MovTitle");

                    b.Property<string>("ReleaseYear");

                    b.HasKey("MovID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieAPI.Models.Director", b =>
                {
                    b.HasOne("MovieAPI.Models.Movie")
                        .WithMany("Directors")
                        .HasForeignKey("MovieMovID");
                });

            modelBuilder.Entity("MovieAPI.Models.Genre", b =>
                {
                    b.HasOne("MovieAPI.Models.Movie")
                        .WithMany("Genres")
                        .HasForeignKey("MovieMovID");
                });
#pragma warning restore 612, 618
        }
    }
}
