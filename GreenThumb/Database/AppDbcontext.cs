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
                },
               new Plants
               {
                   Id = 2,
                   Name = "Carrot",
               },
               new Plants
               {
                   Id = 3,
                   Name = "Blueberry",
               },
               new Plants
               {
                   Id = 4,
                   Name = "Peach",
               },
               new Plants
               {
                   Id = 5,
                   Name = "Lemon",
               },
               new Plants
               {
                   Id = 6,
                   Name = "Coconut",
               },
               new Plants
               {
                   Id = 7,
                   Name = "Watermelon",
               },
               new Plants
               {
                   Id = 8,
                   Name = "Pear",
               },
               new Plants
               {
                   Id = 9,
                   Name = "Grape",
               },
               new Plants
               {
                   Id = 10,
                   Name = "Orange",
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
