using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EghaamatYaar.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class upTbl1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "area",
                table: "Places",
                newName: "county");

            migrationBuilder.AddColumn<DateTime>(
                name: "creatDateTime",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "lastUpdateTime",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "nationalCode",
                table: "Admins",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "phoeneNumber",
                table: "Admins",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "creatDateTime",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "lastUpdateTime",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "nationalCode",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "phoeneNumber",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "county",
                table: "Places",
                newName: "area");
        }
    }
}
