using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    AuthorId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Campaign_Author",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scene",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CampaignId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SettingId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scene", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Scene_Campaign",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Scene_Setting",
                        column: x => x.SettingId,
                        principalTable: "Setting",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SceneSave",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SceneId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    LastEditingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CurrentBeastInitiative = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RoundNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneSave", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_SceneSave_Scene",
                        column: x => x.SceneId,
                        principalTable: "Scene",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FightTeam",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SceneSaveId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightTeam", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_FightTeam_SceneSave",
                        column: x => x.SceneSaveId,
                        principalTable: "SceneSave",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Beast",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SceneSaveId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    FightTeamId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CurrentInitiative = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CurrentArmorClass = table.Column<int>(type: "int", nullable: false),
                    MaxHitPoints = table.Column<int>(type: "int", nullable: false),
                    CurrentHitPoints = table.Column<int>(type: "int", nullable: false),
                    TemporaryHitPoints = table.Column<int>(type: "int", nullable: false),
                    IsSuprised = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beast", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Beast_FightTeam",
                        column: x => x.FightTeamId,
                        principalTable: "FightTeam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Beast_SceneSave",
                        column: x => x.SceneSaveId,
                        principalTable: "SceneSave",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActionResourceList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    BeastId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ActionResourceId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Availeable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionResourceList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_ActionResourceList_ActionResource",
                        column: x => x.ActionResourceId,
                        principalTable: "ActionResource",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_ActionResourceList_Beast",
                        column: x => x.BeastId,
                        principalTable: "Beast",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConditionList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    BeastId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ConditionId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RoundCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_ConditionLists_Beast",
                        column: x => x.BeastId,
                        principalTable: "Beast",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_ConditionLists_Condition",
                        column: x => x.ConditionId,
                        principalTable: "Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpellSlotsList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    BeastId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CountAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSlotsList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_SpellSlotsList_Beast",
                        column: x => x.BeastId,
                        principalTable: "Beast",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TemporaryAbilityList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    BeastId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    AbilityId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    SavingThrowProficiency = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryAbilityList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_TemporaryAbilityList_Ability",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_TemporaryAbilityList_Beast",
                        column: x => x.BeastId,
                        principalTable: "Beast",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionResourceList_ActionResourceId",
                table: "ActionResourceList",
                column: "ActionResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionResourceList_BeastId",
                table: "ActionResourceList",
                column: "BeastId");

            migrationBuilder.CreateIndex(
                name: "IX_Beast_FightTeamId",
                table: "Beast",
                column: "FightTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Beast_SceneSaveId",
                table: "Beast",
                column: "SceneSaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_AuthorId",
                table: "Campaign",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionList_BeastId",
                table: "ConditionList",
                column: "BeastId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionList_ConditionId",
                table: "ConditionList",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FightTeam_SceneSaveId",
                table: "FightTeam",
                column: "SceneSaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_CampaignId",
                table: "Scene",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_SettingId",
                table: "Scene",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneSave_SceneId",
                table: "SceneSave",
                column: "SceneId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSlotsList_BeastId",
                table: "SpellSlotsList",
                column: "BeastId");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryAbilityList_AbilityId",
                table: "TemporaryAbilityList",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryAbilityList_BeastId",
                table: "TemporaryAbilityList",
                column: "BeastId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionResourceList");

            migrationBuilder.DropTable(
                name: "ConditionList");

            migrationBuilder.DropTable(
                name: "SpellSlotsList");

            migrationBuilder.DropTable(
                name: "TemporaryAbilityList");

            migrationBuilder.DropTable(
                name: "Beast");

            migrationBuilder.DropTable(
                name: "FightTeam");

            migrationBuilder.DropTable(
                name: "SceneSave");

            migrationBuilder.DropTable(
                name: "Scene");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "Setting");
        }
    }
}
