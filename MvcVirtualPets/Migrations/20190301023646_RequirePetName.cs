using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcVirtualPets.Migrations
{
    public partial class RequirePetName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pets",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
