using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcVirtualPets.Migrations
{
    public partial class AddedDescriptionProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Roscoe is a lazy old dog who loves to snuggle");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Biggs is BIG because he eats whatever he finds");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Sweet Bella is so loyal and loving");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pets");
        }
    }
}
