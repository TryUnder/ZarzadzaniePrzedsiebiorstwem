using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilans",
                columns: table => new
                {
                    BilansId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KwotaDebet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KwotaKredyt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilans", x => x.BilansId);
                    table.ForeignKey(
                        name: "FK_Bilans_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konto",
                columns: table => new
                {
                    KontoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumerKonta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazwaKonta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KwotaDebet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KwotaKredyt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BilansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konto", x => x.KontoId);
                    table.ForeignKey(
                        name: "FK_Konto_Bilans_BilansId",
                        column: x => x.BilansId,
                        principalTable: "Bilans",
                        principalColumn: "BilansId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilans_UserId",
                table: "Bilans",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Konto_BilansId",
                table: "Konto",
                column: "BilansId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konto");

            migrationBuilder.DropTable(
                name: "Bilans");
        }
    }
}
