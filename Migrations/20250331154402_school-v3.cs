//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace ASPNETCORE_WEB.Migrations
//{
//    /// <inheritdoc />
//    public partial class schoolv3 : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Role",
//                columns: table => new
//                {
//                    RoleId = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    RoleJigar = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    RoleDescription = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Role", x => x.RoleId);
//                });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Role");
//        }
//    }
//}
