using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlannerTag");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Planner",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_PlannerId",
                table: "Tag",
                column: "PlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Planner_TagId",
                table: "Planner",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planner_Tag_TagId",
                table: "Planner",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Planner_PlannerId",
                table: "Tag",
                column: "PlannerId",
                principalTable: "Planner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planner_Tag_TagId",
                table: "Planner");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Planner_PlannerId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_PlannerId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Planner_TagId",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Planner");

            migrationBuilder.CreateTable(
                name: "PlannerTag",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    TasksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannerTag", x => new { x.TagsId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_PlannerTag_Planner_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Planner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannerTag_Tag_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlannerTag_TasksId",
                table: "PlannerTag",
                column: "TasksId");
        }
    }
}
