using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Migrations
{
    public partial class ChangeDataProductColorSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 864, DateTimeKind.Local).AddTicks(2269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 279, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(8962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(3219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(6759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(5368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 862, DateTimeKind.Local).AddTicks(9193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 277, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 862, DateTimeKind.Local).AddTicks(7549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 277, DateTimeKind.Local).AddTicks(6912));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 279, DateTimeKind.Local).AddTicks(150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 864, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(7120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(1828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(5046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(3836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 278, DateTimeKind.Local).AddTicks(6299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 863, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 277, DateTimeKind.Local).AddTicks(8083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 862, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 22, 20, 51, 27, 277, DateTimeKind.Local).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 22, 21, 23, 50, 862, DateTimeKind.Local).AddTicks(7549));
        }
    }
}
