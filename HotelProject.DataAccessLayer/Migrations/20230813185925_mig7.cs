using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckInDate",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "CheckOutDate",
                table: "BookRooms");

            migrationBuilder.RenameColumn(
                name: "BookRoomId",
                table: "BookRooms",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "RoomCount",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ChildCount",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AdultCount",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIn",
                table: "BookRooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOut",
                table: "BookRooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialRequest",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "BookRooms",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "City",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "SpecialRequest",
                table: "BookRooms");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BookRooms");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookRooms",
                newName: "BookRoomId");

            migrationBuilder.AlterColumn<int>(
                name: "RoomCount",
                table: "BookRooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChildCount",
                table: "BookRooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdultCount",
                table: "BookRooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckInDate",
                table: "BookRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOutDate",
                table: "BookRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
