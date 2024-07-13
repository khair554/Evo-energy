using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webdev_consultationPhotovoltaique.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Entreprises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Entreprises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "officiel",
                table: "Entreprises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Entreprises");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Entreprises");

            migrationBuilder.DropColumn(
                name: "officiel",
                table: "Entreprises");
        }
    }
}
