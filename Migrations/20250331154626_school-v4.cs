using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNETCORE_WEB.Migrations
{
    /// <inheritdoc />
    public partial class schoolv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleJigar",
                table: "Role",
                newName: "Role");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Role",
                newName: "RoleJigar");
        }
    }


    // EF Core
    // Automapper
    // Swagger
    // Dependacy (Monoli)
    // Middleware
    // JWT

}
