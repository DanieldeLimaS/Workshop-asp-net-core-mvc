using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SalesWebMvc.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartamentId",
                table: "Seller");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
