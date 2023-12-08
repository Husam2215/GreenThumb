﻿// <auto-generated />
using GreenThumb.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenThumb.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenThumb.Models.Instructions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("instructions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Instruction = "Need Sunight",
                            PlantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Instruction = "Need Sunlight",
                            PlantId = 3
                        },
                        new
                        {
                            Id = 3,
                            Instruction = "Need Sunlight",
                            PlantId = 4
                        },
                        new
                        {
                            Id = 4,
                            Instruction = "Need Sunlight",
                            PlantId = 5
                        },
                        new
                        {
                            Id = 5,
                            Instruction = "Need Sunlight",
                            PlantId = 6
                        },
                        new
                        {
                            Id = 6,
                            Instruction = "Need Sunlight",
                            PlantId = 7
                        },
                        new
                        {
                            Id = 7,
                            Instruction = "Need Sunlight",
                            PlantId = 9
                        },
                        new
                        {
                            Id = 8,
                            Instruction = "Need Sunlight",
                            PlantId = 10
                        },
                        new
                        {
                            Id = 9,
                            Instruction = "Need Water",
                            PlantId = 1
                        },
                        new
                        {
                            Id = 10,
                            Instruction = "Need Water",
                            PlantId = 2
                        },
                        new
                        {
                            Id = 11,
                            Instruction = "Need Water",
                            PlantId = 3
                        },
                        new
                        {
                            Id = 12,
                            Instruction = "Need Water",
                            PlantId = 4
                        },
                        new
                        {
                            Id = 13,
                            Instruction = "Need Water",
                            PlantId = 5
                        },
                        new
                        {
                            Id = 14,
                            Instruction = "Need Water",
                            PlantId = 6
                        },
                        new
                        {
                            Id = 15,
                            Instruction = "Need Water",
                            PlantId = 7
                        },
                        new
                        {
                            Id = 16,
                            Instruction = "Need Water",
                            PlantId = 8
                        },
                        new
                        {
                            Id = 17,
                            Instruction = "Need Water",
                            PlantId = 9
                        },
                        new
                        {
                            Id = 18,
                            Instruction = "Need Water",
                            PlantId = 10
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.Plants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("plants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tomato"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Carrot"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blueberry"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Peach"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Lemon"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Coconut"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Watermelon"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Pear"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Grape"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Orange"
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.Instructions", b =>
                {
                    b.HasOne("GreenThumb.Models.Plants", "Plant")
                        .WithMany("instructions")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumb.Models.Plants", b =>
                {
                    b.Navigation("instructions");
                });
#pragma warning restore 612, 618
        }
    }
}
