using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class SomeRenaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StartThing",
                table: "StartThing");

            migrationBuilder.RenameTable(
                name: "StartThing",
                newName: "Thing");

            migrationBuilder.RenameIndex(
                name: "IX_StartThing_BeastNoteId",
                table: "Thing",
                newName: "IX_Thing_BeastNoteId");

            migrationBuilder.RenameIndex(
                name: "IX_StartThing_BeastId",
                table: "Thing",
                newName: "IX_Thing_BeastId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thing",
                table: "Thing",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Thing",
                table: "Thing");

            migrationBuilder.RenameTable(
                name: "Thing",
                newName: "StartThing");

            migrationBuilder.RenameIndex(
                name: "IX_Thing_BeastNoteId",
                table: "StartThing",
                newName: "IX_StartThing_BeastNoteId");

            migrationBuilder.RenameIndex(
                name: "IX_Thing_BeastId",
                table: "StartThing",
                newName: "IX_StartThing_BeastId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StartThing",
                table: "StartThing",
                column: "Id");
        }
    }
}
