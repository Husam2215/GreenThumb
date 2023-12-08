using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tomato" },
                    { 2, "Carrot" },
                    { 3, "Blueberry" },
                    { 4, "Peach" },
                    { 5, "Lemon" },
                    { 6, "Coconut" },
                    { 7, "Watermelon" },
                    { 8, "Pear" },
                    { 9, "Grape" },
                    { 10, "Orange" }
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
