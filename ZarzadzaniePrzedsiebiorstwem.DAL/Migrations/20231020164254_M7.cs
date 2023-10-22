using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inwestycje",
                table: "RachunekZyskowIStrat",
                newName: "Dotacje");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dotacje",
                table: "RachunekZyskowIStrat",
                newName: "Inwestycje");
        }
    }
}
