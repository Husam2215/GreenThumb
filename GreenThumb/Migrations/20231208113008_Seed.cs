using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructions_plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "plants",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Tomatoes: Versatile, juicy fruits rich in vitamins. Used in salads, sauces, and various dishes worldwide for their sweet-tangy flavor and vibrant colors.", "Tomato" },
                    { 2, "Carrot is a biennial, belonging to the family Apiaceae, and is an important vegetable for its fleshy edible, colorful roots", "Carrot" },
                    { 3, "Blueberris,Small, sweet, and purple. Packed with antioxidants, vitamins C and K. Good for the heart and brain. Used in baking and smoothies.", "Blueberry" },
                    { 4, "Juicy, sweet, with fuzzy skin. Rich in vitamins A and C. Great fresh or in desserts.", "Peach" },
                    { 5, "Lemons: Tangy citrus fruits rich in vitamin C. Used in cooking, baking, and beverages for a refreshing flavor", "Lemon" },
                    { 6, "Coconuts: Large brown fruits with sweet water and creamy flesh. Used in cooking, desserts, and beverages. Rich in nutrients and versatile in various cuisines", "Coconut" },
                    { 7, "Watermelon: Juicy, sweet fruit with red flesh and high water content. Refreshing and hydrating summer treat. Rich in vitamins and antioxidants. Enjoyed fresh or in beverages and salads", "Watermelon" },
                    { 8, "Pears: Sweet, juicy fruits with a soft texture. Available in various colors. Rich in fiber, vitamins, and antioxidants. Enjoy fresh or in diverse recipes", "Pear" },
                    { 9, "Grapes: Small, sweet fruits in various colors. Juicy and packed with vitamins and antioxidants. Eaten fresh, used in salads, or made into wine and raisins", "Grape" },
                    { 10, "Oranges: Tangy-sweet citrus fruits, rich in vitamin C and antioxidants. Enjoy fresh, juiced, or in cooking for a refreshing taste and health benefits", "Orange" }
                });

            migrationBuilder.InsertData(
                table: "instructions",
                columns: new[] { "Id", "Instruction", "PlantId" },
                values: new object[,]
                {
                    { 1, "Need Sunight", 1 },
                    { 2, "Need Sunlight", 3 },
                    { 3, "Need Sunlight", 4 },
                    { 4, "Need Sunlight", 5 },
                    { 5, "Need Sunlight", 6 },
                    { 6, "Need Sunlight", 7 },
                    { 7, "Need Sunlight", 9 },
                    { 8, "Need Sunlight", 10 },
                    { 9, "Need Water", 1 },
                    { 10, "Need Water", 2 },
                    { 11, "Need Water", 3 },
                    { 12, "Need Water", 4 },
                    { 13, "Need Water", 5 },
                    { 14, "Need Water", 6 },
                    { 15, "Need Water", 7 },
                    { 16, "Need Water", 8 },
                    { 17, "Need Water", 9 },
                    { 18, "Need Water", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_instructions_PlantId",
                table: "instructions",
                column: "PlantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "instructions");

            migrationBuilder.DropTable(
                name: "plants");
        }
    }
}
