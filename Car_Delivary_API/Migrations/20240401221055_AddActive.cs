using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Delivary_API.Migrations
{
    /// <inheritdoc />
    public partial class AddActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

            migrationBuilder.RenameColumn(
                name: "CustomerRating",
                schema: "API",
                table: "Trip",
                newName: "UserRating");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                schema: "API",
                table: "Trip",
                newName: "UserId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "API",
                table: "Payment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "API",
                table: "Location",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "API",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "API",
                table: "Location");

            migrationBuilder.RenameColumn(
                name: "UserRating",
                schema: "API",
                table: "Trip",
                newName: "CustomerRating");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "API",
                table: "Trip",
                newName: "CustomerID");

           
        }
    }
}
