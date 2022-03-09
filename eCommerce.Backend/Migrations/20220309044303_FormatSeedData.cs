using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Migrations
{
    public partial class FormatSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 61, DateTimeKind.Local).AddTicks(374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(3959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(7022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(2135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 858, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(1048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 858, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 8,
                column: "ProductID",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(9559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 61, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(8147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(1791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(6017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(4662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 859, DateTimeKind.Local).AddTicks(7358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 858, DateTimeKind.Local).AddTicks(9781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 41, 6, 858, DateTimeKind.Local).AddTicks(8511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 8,
                column: "ProductID",
                value: 1);
        }
    }
}
