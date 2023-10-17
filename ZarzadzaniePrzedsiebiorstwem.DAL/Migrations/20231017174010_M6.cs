using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RachunekZyskowIStrat_User_UserId",
                table: "RachunekZyskowIStrat");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "RachunekZyskowIStrat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RachunekZyskowIStrat_User_UserId",
                table: "RachunekZyskowIStrat",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RachunekZyskowIStrat_User_UserId",
                table: "RachunekZyskowIStrat");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "RachunekZyskowIStrat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RachunekZyskowIStrat_User_UserId",
                table: "RachunekZyskowIStrat",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
