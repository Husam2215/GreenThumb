using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    /// <inheritdoc />
    public partial class seednewdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructions_plants_PlantsId",
                table: "instructions");

            migrationBuilder.DropIndex(
                name: "IX_instructions_PlantsId",
                table: "instructions");

            migrationBuilder.DropColumn(
                name: "PlantsId",
                table: "instructions");

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "instructions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlantId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PlantId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PlantId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PlantId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PlantId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlantId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "PlantId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "PlantId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "PlantId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlantId",
                value: 10);

            migrationBuilder.CreateIndex(
                name: "IX_instructions_PlantId",
                table: "instructions",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructions_plants_PlantId",
                table: "instructions",
                column: "PlantId",
                principalTable: "plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructions_plants_PlantId",
                table: "instructions");

            migrationBuilder.DropIndex(
                name: "IX_instructions_PlantId",
                table: "instructions");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "instructions");

            migrationBuilder.AddColumn<int>(
                name: "PlantsId",
                table: "instructions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "PlantsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlantsId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_instructions_PlantsId",
                table: "instructions",
                column: "PlantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructions_plants_PlantsId",
                table: "instructions",
                column: "PlantsId",
                principalTable: "plants",
                principalColumn: "Id");
        }
    }
}
