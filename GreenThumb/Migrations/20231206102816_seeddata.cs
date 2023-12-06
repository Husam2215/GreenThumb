using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
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
                    Instrtuction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructions_plants_PlantsId",
                        column: x => x.PlantsId,
                        principalTable: "plants",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "instructions",
                columns: new[] { "Id", "Instrtuction", "PlantsId" },
                values: new object[,]
                {
                    { 1, "To care for tomatoes, plant them in a sunny spot with well-draining soil, water regularly without wetting the leaves, provide support as they grow, fertilize as needed, prune for airflow, mulch to retain moisture, watch for pests and diseases, and harvest ripe fruits gently", null },
                    { 2, "To take care of carrots, plant them in loose, well-draining soil, water consistently, thin seedlings, mulch for moisture retention, ensure proper spacing, and harvest when they reach the desired size, typically around 1 to 1.5 inches in diameter", null },
                    { 3, "To care for blueberries, plant them in acidic, well-draining soil, ensure they receive full sun, water consistently to keep the soil moist, prune annually to encourage growth, use mulch for moisture retention and weed control, watch for pests, and harvest when the berries are fully ripe", null },
                    { 4, "To care for peaches, plant them in a sunny location with well-draining soil, water deeply and regularly, provide adequate airflow, prune in late winter or early spring, use mulch to retain moisture and prevent weeds, watch for pests and diseases, and harvest when fruits reach their full, ripe color and slightly yield to gentle pressure", null },
                    { 5, "To care for lemons, plant them in a sunny area with well-draining soil, water consistently but avoid overwatering, fertilize regularly with citrus-specific fertilizer, prune to maintain shape and airflow, mulch to retain moisture and deter weeds, monitor for pests and diseases, and harvest when the lemons reach full color and firmness.", null },
                    { 6, "To care for coconuts, plant them in a warm, tropical climate with well-draining soil, ensure they receive plenty of sunlight, water regularly to maintain soil moisture, provide ample space for growth, protect from strong winds, fertilize occasionally, watch for pests or diseases, and wait patiently as coconuts take several months to mature before harvesting", null },
                    { 7, "To care for watermelons, plant them in a sunny spot with well-drained soil, water consistently to keep the soil evenly moist, provide space for vines to spread, mulch to retain moisture and prevent weeds, support the growing fruit with slings if needed, watch for pests and diseases, and harvest when the bottom side turns creamy yellow and the tendrils near the stem dry out", null },
                    { 8, "To care for pears, plant them in well-draining soil with good sunlight, water consistently during dry periods, prune annually for shape and airflow, mulch to retain moisture and deter weeds, watch for pests and diseases, and harvest when the fruits reach mature size and firmness, typically picking before they fully ripen on the tree", null },
                    { 9, "To care for grapes, plant them in well-draining soil with plenty of sun, prune regularly for proper growth and fruit production, provide support for vines to climb, water deeply but infrequently, mulch to retain moisture and control weeds, watch for pests and diseases, and harvest when the grapes reach desired sweetness and color", null },
                    { 10, "To care for oranges, plant them in a sunny location with well-draining soil, water consistently without overwatering, fertilize regularly with citrus-specific nutrients, prune for shape and airflow, mulch to retain moisture and deter weeds, monitor for pests and diseases, and harvest when the fruits achieve their full color and firmness", null }
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

            migrationBuilder.CreateIndex(
                name: "IX_instructions_PlantsId",
                table: "instructions",
                column: "PlantsId");
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
