using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyWeb.Data.Migrations
{
    public partial class addNewtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dUser",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(7809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dRecuitment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dQnA",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(6945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dProduct",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(6654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dPost",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(6248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dEmployee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(5594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 231, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.CreateTable(
                name: "dFeedback",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDProduct = table.Column<int>(type: "int", nullable: true),
                    Star = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dFeedback", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "dUser",
                columns: new[] { "ID", "Avatar", "CreatedDate", "Name", "Password", "Status", "Username" },
                values: new object[] { 1, null, new DateTime(2023, 12, 21, 20, 40, 3, 598, DateTimeKind.Local).AddTicks(6553), "Quản trị viên", "123$%^", (byte)1, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dFeedback");

            migrationBuilder.DeleteData(
                table: "dUser",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dRecuitment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dQnA",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dProduct",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dPost",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(6),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "dEmployee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 11, 22, 3, 24, 231, DateTimeKind.Local).AddTicks(9714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 21, 20, 40, 3, 597, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.InsertData(
                table: "dUser",
                columns: new[] { "ID", "Avatar", "CreatedDate", "Name", "Password", "Status", "Username" },
                values: new object[] { 1, null, new DateTime(2023, 12, 11, 22, 3, 24, 232, DateTimeKind.Local).AddTicks(8437), "Quản trị viên", "123$%^", (byte)1, "admin" });
        }
    }
}
