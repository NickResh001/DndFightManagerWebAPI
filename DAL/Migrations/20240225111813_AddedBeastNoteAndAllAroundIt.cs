using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedBeastNoteAndAllAroundIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionResource",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionResource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alignment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Law = table.Column<int>(type: "int", nullable: false),
                    Goodness = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BeastType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeastType", x => x.Id);
                });

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
                name: "CooldownType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooldownType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageTendencyType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTendencyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habitat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitat", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speed",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeMeasure",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeMeasure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AbilityId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Skill_Ability",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "varchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeastNote",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    AlignmentId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SizeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastTypeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AuthorId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ModeratorId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    SpellAbilityId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    HitPointsDice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    InitiativeBonus = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    SpecialBonus = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SpellSaveThrowDifficulty = table.Column<int>(type: "int", nullable: true),
                    SpellAttackBonus = table.Column<int>(type: "int", nullable: true),
                    ChallengeRating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllUses = table.Column<int>(type: "int", nullable: false),
                    UniqueUses = table.Column<int>(type: "int", nullable: false),
                    UserRating = table.Column<double>(type: "float", nullable: false),
                    IsBeingModerated = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeastNote", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_BeastNote_Alignment",
                        column: x => x.AlignmentId,
                        principalTable: "Alignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_BeastNote_Author",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_BeastNote_BeastType",
                        column: x => x.BeastTypeId,
                        principalTable: "BeastType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_BeastNote_Moderator",
                        column: x => x.ModeratorId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_BeastNote_Size",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_BeastNote_SpellAbility",
                        column: x => x.SpellAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AbilityList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    AbilityId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    SavingThrowProficiency = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_AbilityList_Ability",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_AbilityList_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    CooldownTypeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ActionResourceId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Cooldown3_TimeMeasureId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ParentMultiactionId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Cooldown1_SpellSlotLevel = table.Column<int>(type: "int", nullable: true),
                    Cooldown2_LowerRangeLimit = table.Column<int>(type: "int", nullable: true),
                    Cooldown2_UpperRangeLimit = table.Column<int>(type: "int", nullable: true),
                    Cooldown2_DiceSize = table.Column<int>(type: "int", nullable: true),
                    Cooldown3_HowManyTimes = table.Column<int>(type: "int", nullable: true),
                    Cooldown3_MeasureMultiply = table.Column<int>(type: "int", nullable: true),
                    Reaction_Condition = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Lair_InitiativeBonus = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    IsTemplate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Action_ActionResource",
                        column: x => x.ActionResourceId,
                        principalTable: "ActionResource",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Action_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Action_Cooldown3TimeMeasure",
                        column: x => x.Cooldown3_TimeMeasureId,
                        principalTable: "TimeMeasure",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Action_CooldownType",
                        column: x => x.CooldownTypeId,
                        principalTable: "CooldownType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Action_ParentMultiaction",
                        column: x => x.ParentMultiactionId,
                        principalTable: "Action",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConditionImmunitiesList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ConditionId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionImmunitiesList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_ConditionImmunitiesList_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_ConditionImmunitiesList_Condition",
                        column: x => x.ConditionId,
                        principalTable: "Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DamageTendency",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    DamageTypeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DamageTendencyTypeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Magical = table.Column<bool>(type: "bit", nullable: false),
                    NonMagical = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTendency", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_DamageTendency_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_DamageTendency_DamageTendencyType",
                        column: x => x.DamageTendencyTypeId,
                        principalTable: "DamageTendencyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_DamageTendency_DamageType",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HabitatList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    HabitatId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitatList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_HabitatList_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_HabitatList_Habitat",
                        column: x => x.HabitatId,
                        principalTable: "Habitat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SenseList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SenseId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    DistanceInFeet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenseList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_SenseList_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_SenseList_Sense",
                        column: x => x.SenseId,
                        principalTable: "Sense",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SkillList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SkillId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Proficiency = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillList", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_SkillList_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_SkillList_Skill",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpeedList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "SpellSlot",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    BeastNoteId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSlot", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_SpellSlot_BeastNote",
                        column: x => x.BeastNoteId,
                        principalTable: "BeastNote",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActionThrow",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ActionId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Throw = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionThrow", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_ActionThrow_Action",
                        column: x => x.ActionId,
                        principalTable: "Action",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityList_AbilityId",
                table: "AbilityList",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityList_BeastNoteId",
                table: "AbilityList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Action_ActionResourceId",
                table: "Action",
                column: "ActionResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Action_BeastNoteId",
                table: "Action",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Action_Cooldown3_TimeMeasureId",
                table: "Action",
                column: "Cooldown3_TimeMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Action_CooldownTypeId",
                table: "Action",
                column: "CooldownTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Action_ParentMultiactionId",
                table: "Action",
                column: "ParentMultiactionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionThrow_ActionId",
                table: "ActionThrow",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_AlignmentId",
                table: "BeastNote",
                column: "AlignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_AuthorId",
                table: "BeastNote",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_BeastTypeId",
                table: "BeastNote",
                column: "BeastTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_ModeratorId",
                table: "BeastNote",
                column: "ModeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_SizeId",
                table: "BeastNote",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_SpellAbilityId",
                table: "BeastNote",
                column: "SpellAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionImmunitiesList_BeastNoteId",
                table: "ConditionImmunitiesList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionImmunitiesList_ConditionId",
                table: "ConditionImmunitiesList",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTendency_BeastNoteId",
                table: "DamageTendency",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTendency_DamageTendencyTypeId",
                table: "DamageTendency",
                column: "DamageTendencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTendency_DamageTypeId",
                table: "DamageTendency",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatList_BeastNoteId",
                table: "HabitatList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatList_HabitatId",
                table: "HabitatList",
                column: "HabitatId");

            migrationBuilder.CreateIndex(
                name: "IX_SenseList_BeastNoteId",
                table: "SenseList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SenseList_SenseId",
                table: "SenseList",
                column: "SenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_AbilityId",
                table: "Skill",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillList_BeastNoteId",
                table: "SkillList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillList_SkillId",
                table: "SkillList",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedList_BeastNoteId",
                table: "SpeedList",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedList_SpeedId",
                table: "SpeedList",
                column: "SpeedId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSlot_BeastNoteId",
                table: "SpellSlot",
                column: "BeastNoteId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityList");

            migrationBuilder.DropTable(
                name: "ActionThrow");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConditionImmunitiesList");

            migrationBuilder.DropTable(
                name: "DamageTendency");

            migrationBuilder.DropTable(
                name: "HabitatList");

            migrationBuilder.DropTable(
                name: "SenseList");

            migrationBuilder.DropTable(
                name: "SkillList");

            migrationBuilder.DropTable(
                name: "SpeedList");

            migrationBuilder.DropTable(
                name: "SpellSlot");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropTable(
                name: "DamageTendencyType");

            migrationBuilder.DropTable(
                name: "DamageType");

            migrationBuilder.DropTable(
                name: "Habitat");

            migrationBuilder.DropTable(
                name: "Sense");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Speed");

            migrationBuilder.DropTable(
                name: "ActionResource");

            migrationBuilder.DropTable(
                name: "BeastNote");

            migrationBuilder.DropTable(
                name: "TimeMeasure");

            migrationBuilder.DropTable(
                name: "CooldownType");

            migrationBuilder.DropTable(
                name: "Alignment");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BeastType");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Ability");
        }
    }
}
