using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoiPool_Project.Migrations
{
    /// <inheritdoc />
    public partial class Requests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestDate",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Requests",
                newName: "ServiceType");

            migrationBuilder.RenameColumn(
                name: "RequestType",
                table: "Requests",
                newName: "RequestContent");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Requests",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Requests",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "GardenArea",
                table: "Requests",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "GardenArea",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "ServiceType",
                table: "Requests",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "RequestContent",
                table: "Requests",
                newName: "RequestType");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Requests",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Requests",
                newName: "CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestDate",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "RequestId");
        }
    }
}
