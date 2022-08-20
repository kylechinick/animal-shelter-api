using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Animals",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Bio",
                value: "Albert likes long walks on the beach. He also likes long walks absolutely everywhere else too.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "Bio",
                value: "Bob is a very friendly dog but has a strange coat for a dog and is unusually large. Big fan of bamboo though.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "Bio",
                value: "Charlie's hobbies include sleeping, eating, asking for head-pats and promptly walking away when you offer them.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "Bio",
                value: "Wanted by several international policing agencies for arson. Do no allow near matches unsupervised. Likes Cheese Puffs.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "Bio",
                value: "Despite Greggory's unique appearance he makes fast friends and loves playing fetch. Very difficult to sneak up on though so hide-and-seek is probably out of the question.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "Bio",
                value: "Pure speed.");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "Bio",
                value: "Tried out for the Globo Gym Purple Cobras and made the team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Animals");
        }
    }
}
