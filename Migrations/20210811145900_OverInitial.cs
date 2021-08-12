using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Migrations
{
    public partial class OverInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d43e2df0-6129-46de-97d2-6468fc35b49a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1f975be-d4fd-4596-be8f-ae9de0056d11", "f1f975be-d4fd-4596-be8f-ae9de0056d11", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1f975be-d4fd-4596-be8f-ae9de0056d11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d43e2df0-6129-46de-97d2-6468fc35b49a", "d43e2df0-6129-46de-97d2-6468fc35b49a", "Admin", "ADMIN" });
        }
    }
}
