using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantitySale",
                table: "ProductColorSizes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 474, DateTimeKind.Local).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(9420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 472, DateTimeKind.Local).AddTicks(4713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.AddColumn<int>(
                name: "QuantitySale",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(4001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(7354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.AddColumn<string>(
                name: "PathImage",
                table: "ProductColorImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 471, DateTimeKind.Local).AddTicks(9998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 471, DateTimeKind.Local).AddTicks(6868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 503, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "DeletedAt", "Description", "ModifiedAt", "Name", "ParentId", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, null, "", null, "Áo", null, null, "ao" },
                    { 2, null, "", null, "Quần", null, null, "quan" },
                    { 3, null, "", null, "Khác", null, null, "khac" },
                    { 4, null, "", null, "Áo khoác", 1, null, "ao-khoac" },
                    { 5, null, "", null, "Áo dài tay", 1, null, "ao-dai-tay" },
                    { 6, null, "", null, "Áo Polo", 1, null, "ao-polo" },
                    { 7, null, "", null, "Áo T-Shirt", 1, null, "ao-t-shirt" },
                    { 8, null, "", null, "Áo sơ mi", 1, null, "ao-so-mi" },
                    { 9, null, "", null, "Áo thể thao", 1, null, "ao-the-thao" },
                    { 10, null, "", null, "Áo in hình", 1, null, "ao-in-hinh" },
                    { 11, null, "", null, "Quần sọt", 2, null, "quan-sot" },
                    { 12, null, "", null, "Quần dài", 2, null, "quan-dai" },
                    { 13, null, "", null, "Quần lót nam", 2, null, "quan-lot" },
                    { 14, null, "", null, "Tất (vớ)", 3, null, "tat" },
                    { 15, null, "", null, "Phụ kiện", 3, null, "phu-kien" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CountRate", "DecreasedPrice", "DeletedAt", "Description", "ModifiedAt", "Name", "Price", "QuantitySale", "SeoDescription", "SeoTitle", "TotalPointRate" },
                values: new object[] { 1, 4, 26, 399000m, null, "", null, "Áo khoác đa năng cản gió và chống UV", 499000m, 970, "", "ao-khoac-da-nang-kinh-chan-giot-ban-faceshield", 128 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CountRate", "DecreasedPrice", "DeletedAt", "Description", "ModifiedAt", "Name", "Price", "QuantitySale", "SeoDescription", "SeoTitle", "TotalPointRate" },
                values: new object[] { 2, 7, 0, 0m, null, "", null, "Áo thun nam Cotton Compact phiên bản Premium chống nhăn", 259000m, 0, "", "ao-thun-nam-cotton-compact-chong-nhan", 0 });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "ID", "DeletedAt", "ModifiedAt", "Name", "PathImage", "ProductID", "Status" },
                values: new object[,]
                {
                    { 1, null, null, "Đen", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/4-4_(1)_80x80.jpg", 1, 0 },
                    { 2, null, null, "Xanh rêu", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/7-2_80x80.jpg", 1, 0 },
                    { 3, null, null, "Đen", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/1-5avgg2cc_46_80x80.jpg", 2, 0 },
                    { 4, null, null, "Trắng", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/3-7a_80x80.jpg", 2, 0 },
                    { 5, null, null, "Xanh Navy", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/preimum_Tshirt_mau_xanh_navy_3_80x80.jpg", 2, 0 },
                    { 6, null, null, "Xám", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/2-5a23_80x80.jpg", 2, 0 },
                    { 7, null, null, "Xám chì", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/1-4_(2)_80x80.jpg", 2, 0 },
                    { 8, null, null, "Xanh lam", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/6-1_(1)a_80x80.jpg", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ID", "Content", "Point", "ProductID", "Status" },
                values: new object[,]
                {
                    { 1, "Good", 5, 1, 1 },
                    { 2, "Bad", 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ID", "Content", "Point", "ProductID" },
                values: new object[] { 3, "Good", 3, 1 });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ID", "Content", "Point", "ProductID", "Status" },
                values: new object[] { 4, "Good", 4, 1, 3 });

            migrationBuilder.InsertData(
                table: "ProductColorImages",
                columns: new[] { "ID", "DeletedAt", "ModifiedAt", "Name", "PathImage", "ProductColorID", "Status" },
                values: new object[,]
                {
                    { 1, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/den_tich_hop.jpg", 1, 0 },
                    { 2, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_4_nen_.jpg", 1, 0 },
                    { 3, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_2_nen.jpg", 1, 0 },
                    { 4, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/fix.jpg", 1, 0 },
                    { 5, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_5_nen.jpg", 1, 0 },
                    { 6, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_6_nen.jpg", 1, 0 },
                    { 7, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/utich_hssop_FS-2.jpg", 1, 0 },
                    { 8, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/2_87.jpg", 1, 0 },
                    { 9, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1_79.jpg", 1, 0 },
                    { 10, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/face3_73.jpg", 1, 0 },
                    { 11, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/4_6.jpg", 1, 0 },
                    { 12, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6130_91.jpg", 3, 0 },
                    { 13, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/denn3-(2).jpg", 3, 0 },
                    { 14, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/comb2_64.jpg", 3, 0 },
                    { 15, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/MEM_MAI_(11)_(2).jpg", 3, 0 },
                    { 16, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/1-5_39.jpg", 3, 0 },
                    { 17, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/IMG_59801u.jpg", 4, 0 },
                    { 18, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1white.jpg", 4, 0 },
                    { 19, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6043.jpg", 4, 0 },
                    { 20, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6048.jpg", 4, 0 },
                    { 21, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/3-111.jpg", 4, 0 },
                    { 22, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/navy56_74-2_copy.jpg", 5, 0 },
                    { 23, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/blue.jpg", 5, 0 },
                    { 24, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/IMG_5855_74_copy.jpg", 5, 0 },
                    { 25, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/IMG_5878_copy.jpg", 5, 0 },
                    { 26, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/xamkso_13.jpg", 6, 0 },
                    { 27, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1grey.jpg", 6, 0 },
                    { 28, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6248.jpg", 6, 0 },
                    { 29, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6269.jpg", 6, 0 },
                    { 30, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6288.jpg", 6, 0 },
                    { 31, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/2-1_(3)_(1).jpg", 6, 0 },
                    { 32, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/acompax7.jpg", 7, 0 },
                    { 33, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/penc.jpg", 7, 0 },
                    { 34, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/compc2_13.jpg", 7, 0 },
                    { 35, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/compax1.jpg", 8, 0 },
                    { 36, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/bluelam.jpg", 8, 0 },
                    { 37, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/DAI04411u.jpg", 8, 0 },
                    { 38, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/DAI04428_(1).jpg", 8, 0 },
                    { 39, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/6-0_(5)_(1)_86.jpg", 8, 0 },
                    { 40, null, null, "", "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/6-2_(2).jpg", 8, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductColorSizes",
                columns: new[] { "ID", "DeletedAt", "ModifiedAt", "Name", "ProductColorID", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1, null, null, "M", 1, 0, 0 },
                    { 2, null, null, "L", 1, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductColorSizes",
                columns: new[] { "ID", "DeletedAt", "ModifiedAt", "Name", "ProductColorID", "Quantity", "Status" },
                values: new object[,]
                {
                    { 3, null, null, "XL", 1, 100, 0 },
                    { 4, null, null, "2XL", 1, 20, 0 },
                    { 5, null, null, "M", 1, 2, 0 },
                    { 6, null, null, "L", 1, 0, 0 },
                    { 7, null, null, "XL", 1, 1, 0 },
                    { 8, null, null, "2XL", 1, 0, 0 },
                    { 9, null, null, "S", 3, 2, 0 },
                    { 10, null, null, "M", 3, 0, 0 },
                    { 11, null, null, "L", 3, 0, 0 },
                    { 12, null, null, "XL", 3, 100, 0 },
                    { 13, null, null, "2XL", 3, 20, 0 },
                    { 14, null, null, "S", 4, 2, 0 },
                    { 15, null, null, "M", 4, 2, 0 },
                    { 16, null, null, "L", 4, 0, 0 },
                    { 17, null, null, "XL", 4, 1, 0 },
                    { 18, null, null, "2XL", 4, 0, 0 },
                    { 19, null, null, "S", 5, 2, 0 },
                    { 20, null, null, "M", 5, 2, 0 },
                    { 21, null, null, "L", 5, 0, 0 },
                    { 22, null, null, "XL", 5, 1, 0 },
                    { 23, null, null, "2XL", 5, 0, 0 },
                    { 24, null, null, "S", 6, 2, 0 },
                    { 25, null, null, "M", 6, 2, 0 },
                    { 26, null, null, "L", 6, 0, 0 },
                    { 27, null, null, "XL", 6, 1, 0 },
                    { 28, null, null, "2XL", 6, 0, 0 },
                    { 29, null, null, "S", 7, 2, 0 },
                    { 30, null, null, "M", 7, 2, 0 },
                    { 31, null, null, "L", 7, 0, 0 },
                    { 32, null, null, "XL", 7, 1, 0 },
                    { 33, null, null, "2XL", 7, 0, 0 },
                    { 34, null, null, "M", 8, 0, 0 },
                    { 35, null, null, "M", 8, 0, 0 },
                    { 36, null, null, "L", 8, 0, 0 },
                    { 37, null, null, "XL", 8, 0, 0 },
                    { 38, null, null, "2XL", 8, 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductColorImages",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductColorSizes",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "QuantitySale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PathImage",
                table: "ProductColorImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Slides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(8083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 474, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(6794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(1907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 472, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorSizes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(4922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.AddColumn<int>(
                name: "QuantitySale",
                table: "ProductColorSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(3700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColorImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(6073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 473, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 504, DateTimeKind.Local).AddTicks(148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 471, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 22, 4, 503, DateTimeKind.Local).AddTicks(9084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 36, 33, 471, DateTimeKind.Local).AddTicks(6868));
        }
    }
}
