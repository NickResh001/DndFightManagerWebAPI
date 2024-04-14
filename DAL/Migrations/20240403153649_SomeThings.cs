using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class SomeThings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Availeable",
                table: "ActionResourceList",
                newName: "Available");

            migrationBuilder.AddColumn<string>(
                name: "BeastNoteId",
                table: "Beast",
                type: "varchar(450)",
                unicode: false,
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "StartThing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    BeastId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartThing", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Thing_Beast",
                        column: x => x.BeastId,
                        principalTable: "Beast",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Thing_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beast_BeastNoteId",
                table: "Beast",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_StartThing_BeastId",
                table: "StartThing",
                column: "BeastId");

            migrationBuilder.CreateIndex(
                name: "IX_StartThing_BeastNoteId",
                table: "StartThing",
                column: "BeastNoteId");

            migrationBuilder.AddForeignKey(
                name: "Fk_Beast_BeastNote",
                table: "Beast",
                column: "BeastNoteId",
                principalTable: "BeastNote",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Beast_BeastNote",
                table: "Beast");

            migrationBuilder.DropTable(
                name: "StartThing");

            migrationBuilder.DropIndex(
                name: "IX_Beast_BeastNoteId",
                table: "Beast");

            migrationBuilder.DropColumn(
                name: "BeastNoteId",
                table: "Beast");

            migrationBuilder.RenameColumn(
                name: "Available",
                table: "ActionResourceList",
                newName: "Availeable");
        }
    }
}
