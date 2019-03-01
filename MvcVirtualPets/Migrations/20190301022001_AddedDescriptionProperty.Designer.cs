﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcVirtualPets;

namespace MvcVirtualPets.Migrations
{
    [DbContext(typeof(PetContext))]
    [Migration("20190301022001_AddedDescriptionProperty")]
    partial class AddedDescriptionProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcVirtualPets.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Pets");

                    b.HasData(
                        new { Id = 1, Description = "Roscoe is a lazy old dog who loves to snuggle", Name = "Roscoe" },
                        new { Id = 2, Description = "Biggs is BIG because he eats whatever he finds", Name = "Biggs" },
                        new { Id = 3, Description = "Sweet Bella is so loyal and loving", Name = "Bella" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}