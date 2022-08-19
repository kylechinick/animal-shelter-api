﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20220819181231_Seed2")]
    partial class Seed2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Gender = "Male",
                            Name = "Al",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 8,
                            Gender = "Unknown",
                            Name = "Bob",
                            Species = "Panda"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 8,
                            Gender = "Female",
                            Name = "Charlie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 64,
                            Gender = "Female",
                            Name = "Diana",
                            Species = "Capybara"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 506,
                            Gender = "Unknown",
                            Name = "Greggory",
                            Species = "Beholder"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 32,
                            Gender = "Male",
                            Name = "Turbo",
                            Species = "Narwhal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
