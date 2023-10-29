using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataKoncowa",
                table: "RachunekZyskowIStrat");

            migrationBuilder.RenameColumn(
                name: "DataPoczatkowa",
                table: "RachunekZyskowIStrat",
                newName: "OkresRozliczeniowy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OkresRozliczeniowy",
                table: "RachunekZyskowIStrat",
                newName: "DataPoczatkowa");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataKoncowa",
                table: "RachunekZyskowIStrat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
