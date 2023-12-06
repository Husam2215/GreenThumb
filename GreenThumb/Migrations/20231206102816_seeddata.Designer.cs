﻿// <auto-generated />
using System;
using GreenThumb.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenThumb.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20231206102816_seeddata")]
    partial class seeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenThumb.Models.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Instrtuction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantsId");

                    b.ToTable("instructions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Instrtuction = "To care for tomatoes, plant them in a sunny spot with well-draining soil, water regularly without wetting the leaves, provide support as they grow, fertilize as needed, prune for airflow, mulch to retain moisture, watch for pests and diseases, and harvest ripe fruits gently"
                        },
                        new
                        {
                            Id = 2,
                            Instrtuction = "To take care of carrots, plant them in loose, well-draining soil, water consistently, thin seedlings, mulch for moisture retention, ensure proper spacing, and harvest when they reach the desired size, typically around 1 to 1.5 inches in diameter"
                        },
                        new
                        {
                            Id = 3,
                            Instrtuction = "To care for blueberries, plant them in acidic, well-draining soil, ensure they receive full sun, water consistently to keep the soil moist, prune annually to encourage growth, use mulch for moisture retention and weed control, watch for pests, and harvest when the berries are fully ripe"
                        },
                        new
                        {
                            Id = 4,
                            Instrtuction = "To care for peaches, plant them in a sunny location with well-draining soil, water deeply and regularly, provide adequate airflow, prune in late winter or early spring, use mulch to retain moisture and prevent weeds, watch for pests and diseases, and harvest when fruits reach their full, ripe color and slightly yield to gentle pressure"
                        },
                        new
                        {
                            Id = 5,
                            Instrtuction = "To care for lemons, plant them in a sunny area with well-draining soil, water consistently but avoid overwatering, fertilize regularly with citrus-specific fertilizer, prune to maintain shape and airflow, mulch to retain moisture and deter weeds, monitor for pests and diseases, and harvest when the lemons reach full color and firmness."
                        },
                        new
                        {
                            Id = 6,
                            Instrtuction = "To care for coconuts, plant them in a warm, tropical climate with well-draining soil, ensure they receive plenty of sunlight, water regularly to maintain soil moisture, provide ample space for growth, protect from strong winds, fertilize occasionally, watch for pests or diseases, and wait patiently as coconuts take several months to mature before harvesting"
                        },
                        new
                        {
                            Id = 7,
                            Instrtuction = "To care for watermelons, plant them in a sunny spot with well-drained soil, water consistently to keep the soil evenly moist, provide space for vines to spread, mulch to retain moisture and prevent weeds, support the growing fruit with slings if needed, watch for pests and diseases, and harvest when the bottom side turns creamy yellow and the tendrils near the stem dry out"
                        },
                        new
                        {
                            Id = 8,
                            Instrtuction = "To care for pears, plant them in well-draining soil with good sunlight, water consistently during dry periods, prune annually for shape and airflow, mulch to retain moisture and deter weeds, watch for pests and diseases, and harvest when the fruits reach mature size and firmness, typically picking before they fully ripen on the tree"
                        },
                        new
                        {
                            Id = 9,
                            Instrtuction = "To care for grapes, plant them in well-draining soil with plenty of sun, prune regularly for proper growth and fruit production, provide support for vines to climb, water deeply but infrequently, mulch to retain moisture and control weeds, watch for pests and diseases, and harvest when the grapes reach desired sweetness and color"
                        },
                        new
                        {
                            Id = 10,
                            Instrtuction = "To care for oranges, plant them in a sunny location with well-draining soil, water consistently without overwatering, fertilize regularly with citrus-specific nutrients, prune for shape and airflow, mulch to retain moisture and deter weeds, monitor for pests and diseases, and harvest when the fruits achieve their full color and firmness"
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.Plants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("plants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Tomatoes: Versatile, juicy fruits rich in vitamins. Used in salads, sauces, and various dishes worldwide for their sweet-tangy flavor and vibrant colors.",
                            Name = "Tomato"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Carrot is a biennial, belonging to the family Apiaceae, and is an important vegetable for its fleshy edible, colorful roots",
                            Name = "Carrot"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Blueberris,Small, sweet, and purple. Packed with antioxidants, vitamins C and K. Good for the heart and brain. Used in baking and smoothies.",
                            Name = "Blueberry"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Juicy, sweet, with fuzzy skin. Rich in vitamins A and C. Great fresh or in desserts.",
                            Name = "Peach"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Lemons: Tangy citrus fruits rich in vitamin C. Used in cooking, baking, and beverages for a refreshing flavor",
                            Name = "Lemon"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Coconuts: Large brown fruits with sweet water and creamy flesh. Used in cooking, desserts, and beverages. Rich in nutrients and versatile in various cuisines",
                            Name = "Coconut"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Watermelon: Juicy, sweet fruit with red flesh and high water content. Refreshing and hydrating summer treat. Rich in vitamins and antioxidants. Enjoyed fresh or in beverages and salads",
                            Name = "Watermelon"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Pears: Sweet, juicy fruits with a soft texture. Available in various colors. Rich in fiber, vitamins, and antioxidants. Enjoy fresh or in diverse recipes",
                            Name = "Pear"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Grapes: Small, sweet fruits in various colors. Juicy and packed with vitamins and antioxidants. Eaten fresh, used in salads, or made into wine and raisins",
                            Name = "Grape"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Oranges: Tangy-sweet citrus fruits, rich in vitamin C and antioxidants. Enjoy fresh, juiced, or in cooking for a refreshing taste and health benefits",
                            Name = "Orange"
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.Instruction", b =>
                {
                    b.HasOne("GreenThumb.Models.Plants", null)
                        .WithMany("instructions")
                        .HasForeignKey("PlantsId");
                });

            modelBuilder.Entity("GreenThumb.Models.Plants", b =>
                {
                    b.Navigation("instructions");
                });
#pragma warning restore 612, 618
        }
    }
}
