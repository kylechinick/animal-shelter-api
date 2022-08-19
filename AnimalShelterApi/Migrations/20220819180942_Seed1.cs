using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Gender", "Name", "Species" },
                values: new object[] { "Male", "Al", "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Gender", "Name", "Species" },
                values: new object[] { "Unknown", "Bob", "Panda" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Name", "Species" },
                values: new object[] { "Charlie", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Gender", "Name", "Species" },
                values: new object[] { "Female", "Diana", "Capybara" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Name", "Species" },
                values: new object[] { "Turbo", "Narwhal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Gender", "Name", "Species" },
                values: new object[] { "Female", "Matilda", "Woolly Mammoth" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Gender", "Name", "Species" },
                values: new object[] { "Female", "Rexie", "Dinosaur" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Name", "Species" },
                values: new object[] { "Matilda", "Dinosaur" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Gender", "Name", "Species" },
                values: new object[] { "Male", "Pip", "Shark" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Name", "Species" },
                values: new object[] { "Bartholomew", "Dinosaur" });
        }
    }
}
