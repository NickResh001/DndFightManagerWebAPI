using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSenseAndCondition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sense",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sense", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropTable(
                name: "Sense");
        }
    }
}
