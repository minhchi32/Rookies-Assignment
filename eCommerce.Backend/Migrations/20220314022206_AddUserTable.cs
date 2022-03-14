using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Migrations
{
    public partial class AddUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(8787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 827, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(4559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Rates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 589, DateTimeKind.Local).AddTicks(7414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(1791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(25),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 589, DateTimeKind.Local).AddTicks(2373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 589, DateTimeKind.Local).AddTicks(838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "customer" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Dob", "Email", "Name", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { 1, new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "admin", "admin", "0123456789", 1, "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Dob", "Email", "Name", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { 2, new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer@customer.com", "customer", "customer", "0123456789", 2, "customer" });

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 1,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 3,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 4,
                column: "UserID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Rates_UserID",
                table: "Rates",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_RoleId",
                table: "AppUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AppUsers_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "AppUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_AppUsers_UserID",
                table: "Rates",
                column: "UserID",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AppUsers_UserID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_AppUsers_UserID",
                table: "Rates");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropIndex(
                name: "IX_Rates_UserID",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Rates");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 827, DateTimeKind.Local).AddTicks(347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(3597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 589, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(6882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 590, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(1521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 589, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 14, 9, 22, 5, 589, DateTimeKind.Local).AddTicks(838));
        }
    }
}
