using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstCrossReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeastNote",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeastNote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeedList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SpeedId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    DistanceInFeet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeedList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_SpeedList_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_SpeedList_Speed",
                        column: x => x.SpeedId,
                        principalTable: "Speed",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpeedList_BeastNoteId",
                table: "SpeedList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedList_SpeedId",
                table: "SpeedList",
                column: "SpeedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpeedList");

            migrationBuilder.DropTable(
                name: "BeastNote");
        }
    }
}
