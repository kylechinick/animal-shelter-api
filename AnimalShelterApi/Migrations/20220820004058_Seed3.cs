using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "Bio",
                value: "Bob is very friendly but has a strange coat for a dog and is unusually large. Big fan of bamboo though.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "Bio",
                value: "Wanted by several international policing agencies for arson. Do not allow near matches unsupervised. Likes Cheese Puffs.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "Bio",
                value: "Pure speed. Ka-chow.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "Bio",
                value: "Bob is a very friendly dog but has a strange coat for a dog and is unusually large. Big fan of bamboo though.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "Bio",
                value: "Wanted by several international policing agencies for arson. Do no allow near matches unsupervised. Likes Cheese Puffs.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "Bio",
                value: "Pure speed.");
        }
    }
}
