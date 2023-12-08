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

        public DbSet<Instructions> instructions { get; set; }

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


            modelBuilder.Entity<Instructions>().HasData(
            new Instructions
            {
                Id = 1,
                Instruction = "Need Sunight",
                PlantId = 1,
            },
            new Instructions
            {
                Id = 2,
                Instruction = "Need Sunlight",
                PlantId = 3,
            },
            new Instructions
            {
                Id = 3,
                Instruction = "Need Sunlight",
                PlantId = 4,
            },
            new Instructions
            {
                Id = 4,
                Instruction = "Need Sunlight",
                PlantId = 5,
            },
            new Instructions
            {
                Id = 5,
                Instruction = "Need Sunlight",
                PlantId = 6,
            },
            new Instructions
            {
                Id = 6,
                Instruction = "Need Sunlight",
                PlantId = 7,
            },
            new Instructions
            {
                Id = 7,
                Instruction = "Need Sunlight",
                PlantId = 9,
            },
            new Instructions
            {
                Id = 8,
                Instruction = "Need Sunlight",
                PlantId = 10,
            },
            new Instructions
            {
                Id = 9,
                Instruction = "Need Water",
                PlantId = 1,
            },
            new Instructions
            {
                Id = 10,
                Instruction = "Need Water",
                PlantId = 2,
            },
            new Instructions
            {
                Id = 11,
                Instruction = "Need Water",
                PlantId = 3,
            },
            new Instructions
            {
                Id = 12,
                Instruction = "Need Water",
                PlantId = 4,
            },
            new Instructions
            {
                Id = 13,
                Instruction = "Need Water",
                PlantId = 5,
            },
            new Instructions
            {
                Id = 14,
                Instruction = "Need Water",
                PlantId = 6,
            },
            new Instructions
            {
                Id = 15,
                Instruction = "Need Water",
                PlantId = 7,
            },
            new Instructions
            {
                Id = 16,
                Instruction = "Need Water",
                PlantId = 8,
            },
            new Instructions
            {
                Id = 17,
                Instruction = "Need Water",
                PlantId = 9,
            },
            new Instructions
            {
                Id = 18,
                Instruction = "Need Water",
                PlantId = 10,
            });



        }
    }
}
