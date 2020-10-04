using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 4, 17, 10, 11, 319, DateTimeKind.Local).AddTicks(7576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 4, 16, 41, 25, 553, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("7b2dd774-2cda-43d9-ad93-c08d760b8a82"), "a4cb332f-574c-4386-b148-316ef686c340", "Administration role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("85b63719-0fe1-4359-b479-1d19cf2963d0"), new Guid("7b2dd774-2cda-43d9-ad93-c08d760b8a82") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("85b63719-0fe1-4359-b479-1d19cf2963d0"), 0, "22937a45-6c79-45a3-baf9-170bad44cb5b", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "some-admin-email@nonce.fake", true, "Trung", "Nguyen", false, null, "some-admin-email@nonce.fake", "admin", "AQAAAAEAACcQAAAAEEB/xg5XCuYCKSX6EOe6ow0W3diq0BRhybB5JfF9gazezvCFaWNhibDmF+Dh5k3uig==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 4, 17, 10, 11, 335, DateTimeKind.Local).AddTicks(6258));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b2dd774-2cda-43d9-ad93-c08d760b8a82"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("85b63719-0fe1-4359-b479-1d19cf2963d0"), new Guid("7b2dd774-2cda-43d9-ad93-c08d760b8a82") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("85b63719-0fe1-4359-b479-1d19cf2963d0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 10, 4, 16, 41, 25, 553, DateTimeKind.Local).AddTicks(391),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 10, 4, 17, 10, 11, 319, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 4, 16, 41, 25, 568, DateTimeKind.Local).AddTicks(4413));
        }
    }
}
