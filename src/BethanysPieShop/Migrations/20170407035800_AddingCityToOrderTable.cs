using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class AddingCityToOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Orders",
                maxLength: 10,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                maxLength: 25,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Orders",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                maxLength: 100,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                nullable: true);
        }
    }
}
