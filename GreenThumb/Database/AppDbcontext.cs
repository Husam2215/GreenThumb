using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb.Database
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext()
        {

        }

        public DbSet<Plants> plants { get; set; }

        public DbSet<Instruction> instructions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GreenThumbSocialDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Seeda data

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Plants>().HasData(
                new Plants
                {
                    Id = 1,
                    Name = "Tomato",
                    Description = "Tomatoes: Versatile, juicy fruits rich in vitamins. Used in salads, sauces, and various dishes worldwide for their sweet-tangy flavor and vibrant colors."
                },
               new Plants
               {
                   Id = 2,
                   Name = "Carrot",
                   Description = "Carrot is a biennial, belonging to the family Apiaceae, and is an important vegetable for its fleshy edible, colorful roots"
               },
               new Plants
               {
                   Id = 3,
                   Name = "Blueberry",
                   Description = "Blueberris,Small, sweet, and purple. Packed with antioxidants, vitamins C and K. Good for the heart and brain. Used in baking and smoothies."
               },
               new Plants
               {
                   Id = 4,
                   Name = "Peach",
                   Description = "Juicy, sweet, with fuzzy skin. Rich in vitamins A and C. Great fresh or in desserts."
               },
               new Plants
               {
                   Id = 5,
                   Name = "Lemon",
                   Description = "Lemons: Tangy citrus fruits rich in vitamin C. Used in cooking, baking, and beverages for a refreshing flavor"
               },
               new Plants
               {
                   Id = 6,
                   Name = "Coconut",
                   Description = "Coconuts: Large brown fruits with sweet water and creamy flesh. Used in cooking, desserts, and beverages. Rich in nutrients and versatile in various cuisines"
               },
               new Plants
               {
                   Id = 7,
                   Name = "Watermelon",
                   Description = "Watermelon: Juicy, sweet fruit with red flesh and high water content. Refreshing and hydrating summer treat. Rich in vitamins and antioxidants. Enjoyed fresh or in beverages and salads"
               },
               new Plants
               {
                   Id = 8,
                   Name = "Pear",
                   Description = "Pears: Sweet, juicy fruits with a soft texture. Available in various colors. Rich in fiber, vitamins, and antioxidants. Enjoy fresh or in diverse recipes"
               },
               new Plants
               {
                   Id = 9,
                   Name = "Grape",
                   Description = "Grapes: Small, sweet fruits in various colors. Juicy and packed with vitamins and antioxidants. Eaten fresh, used in salads, or made into wine and raisins"
               },
               new Plants
               {
                   Id = 10,
                   Name = "Orange",
                   Description = "Oranges: Tangy-sweet citrus fruits, rich in vitamin C and antioxidants. Enjoy fresh, juiced, or in cooking for a refreshing taste and health benefits"
               });


            modelBuilder.Entity<Instruction>().HasData(
            new Instruction
            {
                Id = 1,
                Instrtuction = "Need Sunight",
                PlantId = 1,
            },
            new Instruction
            {
                Id = 2,
                Instrtuction = "Need Sunlight",
                PlantId = 3,
            },
            new Instruction
            {
                Id = 3,
                Instrtuction = "Need Sunlight",
                PlantId = 4,
            },
            new Instruction
            {
                Id = 4,
                Instrtuction = "Need Sunlight",
                PlantId = 5,
            },
            new Instruction
            {
                Id = 5,
                Instrtuction = "Need Sunlight",
                PlantId = 6,
            },
            new Instruction
            {
                Id = 6,
                Instrtuction = "Need Sunlight",
                PlantId = 7,
            },
            new Instruction
            {
                Id = 7,
                Instrtuction = "Need Sunlight",
                PlantId = 9,
            },
            new Instruction
            {
                Id = 8,
                Instrtuction = "Need Sunlight",
                PlantId = 10,
            },
            new Instruction
            {
                Id = 9,
                Instrtuction = "Need Water",
                PlantId = 1,
            },
            new Instruction
            {
                Id = 10,
                Instrtuction = "Need Water",
                PlantId = 2,
            },
            new Instruction
            {
                Id = 11,
                Instrtuction = "Need Water",
                PlantId = 3,
            },
            new Instruction
            {
                Id = 12,
                Instrtuction = "Need Water",
                PlantId = 4,
            },
            new Instruction
            {
                Id = 13,
                Instrtuction = "Need Water",
                PlantId = 5,
            },
            new Instruction
            {
                Id = 14,
                Instrtuction = "Need Water",
                PlantId = 6,
            },
            new Instruction
            {
                Id = 15,
                Instrtuction = "Need Water",
                PlantId = 7,
            },
            new Instruction
            {
                Id = 16,
                Instrtuction = "Need Water",
                PlantId = 8,
            },
            new Instruction
            {
                Id = 17,
                Instrtuction = "Need Water",
                PlantId = 9,
            },
            new Instruction
            {
                Id = 18,
                Instrtuction = "Need Water",
                PlantId = 10,
            });



        }
    }
}
