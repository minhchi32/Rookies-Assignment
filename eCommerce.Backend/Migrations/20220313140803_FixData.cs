using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Migrations
{
    public partial class FixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 827, DateTimeKind.Local).AddTicks(347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 61, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(3597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(6882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(1521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 7,
                column: "ProductColorID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 8,
                column: "ProductColorID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 9,
                column: "ProductColorID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 10,
                column: "ProductColorID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 11,
                column: "ProductColorID",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 61, DateTimeKind.Local).AddTicks(374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 827, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(3959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(7022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(8238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(2135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 11, 43, 3, 60, DateTimeKind.Local).AddTicks(1048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 13, 21, 8, 2, 826, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 7,
                column: "ProductColorID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 8,
                column: "ProductColorID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 9,
                column: "ProductColorID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 10,
                column: "ProductColorID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 11,
                column: "ProductColorID",
                value: 1);
        }
    }
}
