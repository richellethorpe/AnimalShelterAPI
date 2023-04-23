﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AnimalBreed")
                        .HasColumnType("longtext");

                    b.Property<string>("AnimalName")
                        .HasColumnType("longtext");

                    b.Property<string>("AnimalType")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 3,
                            AnimalBreed = "Gold Retriever",
                            AnimalName = "Cosmo",
                            AnimalType = "Dog",
                            City = "Portland"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 5,
                            AnimalBreed = "Catahoula",
                            AnimalName = "Pepper",
                            AnimalType = "Dog",
                            City = "Portland"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            AnimalBreed = "Garter",
                            AnimalName = "Scales",
                            AnimalType = "Snake",
                            City = "Fairbanks"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 12,
                            AnimalBreed = "Goldfish",
                            AnimalName = "Blinky",
                            AnimalType = "Fish",
                            City = "Faibanks"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 11,
                            AnimalBreed = "Chocolate Lab",
                            AnimalName = "Sonny",
                            AnimalType = "Dog",
                            City = "Portland"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}