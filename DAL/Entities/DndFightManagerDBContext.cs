using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore = Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    public partial class DndFightManagerDBContext : IdentityDbContext<User>
    {
        protected readonly IConfiguration _configuration;
        public DndFightManagerDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #region DbSets
        public virtual EFCore.DbSet<Ability> Abilities { get; set; }
        public virtual EFCore.DbSet<DamageType> DamageTypes { get; set; }
        public virtual EFCore.DbSet<DamageTendencyType> DamageTendencyTypes { get; set; }
        public virtual EFCore.DbSet<Skill> Skills { get; set; }
        public virtual EFCore.DbSet<Speed> Speeds { get; set; }
        public virtual EFCore.DbSet<Habitat> Habitats { get; set; }
        public virtual EFCore.DbSet<Size> Sizes { get; set; }
        public virtual EFCore.DbSet<BeastType> BeastTypes { get; set; }
        public virtual EFCore.DbSet<Sense> Senses { get; set; }
        public virtual EFCore.DbSet<Condition> Conditions { get; set; }
        public virtual EFCore.DbSet<ActionResource> ActionResources { get; set; }

        public virtual EFCore.DbSet<SpeedList> SpeedLists { get; set; }
        public virtual EFCore.DbSet<DamageTendency> DamageTendencies { get; set; }
        public virtual EFCore.DbSet<SkillList> SkillLists { get; set; }
        public virtual EFCore.DbSet<AbilityList> AbilityLists { get; set; }
        public virtual EFCore.DbSet<SpellSlot> SpellSlots { get; set; }
        public virtual EFCore.DbSet<HabitatList> HabitatLists { get; set; }
        public virtual EFCore.DbSet<SenseList> SenseLists { get; set; }
        public virtual EFCore.DbSet<ConditionImmunitiesList> ConditionImmunitiesLists { get; set; }

        public virtual EFCore.DbSet<Action> Actions { get; set; }
        public virtual EFCore.DbSet<ActionThrow> ActionThrows { get; set; }
        public virtual EFCore.DbSet<BeastNote> BeastNotes { get; set; }

        public virtual EFCore.DbSet<TemporaryAbilityList> TemporaryAbilityLists { get; set; }
        public virtual EFCore.DbSet<ConditionList> ConditionLists { get; set; }
        public virtual EFCore.DbSet<ActionResourceList> ActionResourceLists { get; set; }
        public virtual EFCore.DbSet<SpellSlotsList> SpellSlotsLists { get; set; }

        public virtual EFCore.DbSet<Setting> Settings { get; set; }
        public virtual EFCore.DbSet<Campaign> Campaigns { get; set; }
        public virtual EFCore.DbSet<Scene> Scenes { get; set; }
        public virtual EFCore.DbSet<SceneSave> SceneSaves { get; set; }
        public virtual EFCore.DbSet<FightTeam> FightTeams { get; set; }
        public virtual EFCore.DbSet<Beast> Beast { get; set; }


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
            catch
            {
                throw new Exception("Db server ins't working");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Hardcode db directories
            modelBuilder.Entity<DamageType>(entity =>
            {
                entity.ToTable("DamageType");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            }); 
            modelBuilder.Entity<DamageTendencyType>(entity =>
            {
                entity.ToTable("DamageTendencyType");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AbilityId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(s => s.Ability).WithMany(a => a.Skills)
                    .HasForeignKey(s => s.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Skill_Ability");
            });
            modelBuilder.Entity<Speed>(entity =>
            {
                entity.ToTable("Speed");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Habitat>(entity =>
            {
                entity.ToTable("Habitat");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });            
            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });            
            modelBuilder.Entity<BeastType>(entity =>
            {
                entity.ToTable("BeastType");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });            
            modelBuilder.Entity<Sense>(entity =>
            {
                entity.ToTable("Sense");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Condition>(entity =>
            {
                entity.ToTable("Condition");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<ActionResource>(entity =>
            {
                entity.ToTable("ActionResource");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<CooldownType>(entity =>
            {
                entity.ToTable("CooldownType");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });            
            modelBuilder.Entity<TimeMeasure>(entity =>
            {
                entity.ToTable("TimeMeasure");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("Ability");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Alignment>(entity =>
            {
                entity.ToTable("Alignment");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            #endregion

            #region Cross-reference tables

            modelBuilder.Entity<SpeedList>(entity =>
            {
                entity.ToTable("SpeedList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SpeedId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Speed).WithMany(a => a.SpeedLists)
                    .HasForeignKey(s => s.SpeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SpeedList_Speed");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.SpeedLists)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SpeedList_BeastNote");
            });
            modelBuilder.Entity<DamageTendency>(entity =>
            {
                entity.ToTable("DamageTendency");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.DamageTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DamageTendencyTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.DamageType).WithMany(a => a.DamageTendencies)
                    .HasForeignKey(s => s.DamageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DamageTendency_DamageType");

                entity.HasOne(s => s.DamageTendencyType).WithMany(a => a.DamageTendencies)
                    .HasForeignKey(s => s.DamageTendencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DamageTendency_DamageTendencyType");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.DamageTendencies)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DamageTendency_BeastNote");
            });
            modelBuilder.Entity<SkillList>(entity =>
            {
                entity.ToTable("SkillList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SkillId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Skill).WithMany(a => a.SkillLists)
                    .HasForeignKey(s => s.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SkillList_Skill");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.SkillLists)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SkillList_BeastNote");
            });
            modelBuilder.Entity<AbilityList>(entity =>
            {
                entity.ToTable("AbilityList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.AbilityId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Ability).WithMany(a => a.AbilityLists)
                    .HasForeignKey(s => s.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_AbilityList_Ability");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.AbilityLists)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_AbilityList_BeastNote");
            });
            modelBuilder.Entity<SpellSlot>(entity =>
            {
                entity.ToTable("SpellSlot");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.BeastNote).WithMany(a => a.SpellSlots)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SpellSlot_BeastNote");
            });
            modelBuilder.Entity<HabitatList>(entity =>
            {
                entity.ToTable("HabitatList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.HabitatId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Habitat).WithMany(a => a.HabitatLists)
                    .HasForeignKey(s => s.HabitatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_HabitatList_Habitat");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.HabitatLists)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_HabitatList_BeastNote");
            });
            modelBuilder.Entity<SenseList>(entity =>
            {
                entity.ToTable("SenseList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SenseId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Sense).WithMany(a => a.SenseLists)
                    .HasForeignKey(s => s.SenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SenseList_Sense");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.SenseLists)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SenseList_BeastNote");
            });
            modelBuilder.Entity<ConditionImmunitiesList>(entity =>
            {
                entity.ToTable("ConditionImmunitiesList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Condition).WithMany(a => a.ConditionImmunitiesLists)
                    .HasForeignKey(s => s.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ConditionImmunitiesList_Condition");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.ConditionImmunitiesLists)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ConditionImmunitiesList_BeastNote");
            });

            modelBuilder.Entity<TemporaryAbilityList>(entity =>
            {
                entity.ToTable("TemporaryAbilityList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BeastId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.AbilityId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(s => s.Beast).WithMany(a => a.TemporaryAbilityLists)
                    .HasForeignKey(s => s.BeastId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_TemporaryAbilityList_Beast");

                entity.HasOne(s => s.Ability).WithMany(a => a.TemporaryAbilityLists)
                    .HasForeignKey(s => s.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_TemporaryAbilityList_Ability");
            });
            modelBuilder.Entity<ConditionList>(entity =>
            {
                entity.ToTable("ConditionList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BeastId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(s => s.Beast).WithMany(a => a.ConditionLists)
                    .HasForeignKey(s => s.BeastId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ConditionLists_Beast");

                entity.HasOne(s => s.Condition).WithMany(a => a.ConditionLists)
                    .HasForeignKey(s => s.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ConditionLists_Condition");
            });
            modelBuilder.Entity<ActionResourceList>(entity =>
            {
                entity.ToTable("ActionResourceList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BeastId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ActionResourceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(s => s.Beast).WithMany(a => a.ActionResourceLists)
                    .HasForeignKey(s => s.BeastId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ActionResourceList_Beast");

                entity.HasOne(s => s.ActionResource).WithMany(a => a.ActionResourceLists)
                    .HasForeignKey(s => s.ActionResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ActionResourceList_ActionResource");
            });
            modelBuilder.Entity<SpellSlotsList>(entity =>
            {
                entity.ToTable("SpellSlotsList");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BeastId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Beast).WithMany(a => a.SpellSlotsLists)
                    .HasForeignKey(s => s.BeastId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SpellSlotsList_Beast");
            });
            #endregion

            modelBuilder.Entity<Action>(entity =>
            {
                entity.ToTable("Action");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reaction_Condition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CooldownTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                
                entity.Property(e => e.ActionResourceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cooldown3_TimeMeasureId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentMultiactionId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BeastNoteId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.CooldownType).WithMany(a => a.Actions)
                    .HasForeignKey(s => s.CooldownTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Action_CooldownType");

                entity.HasOne(s => s.ActionResource).WithMany(a => a.Actions)
                    .HasForeignKey(s => s.ActionResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Action_ActionResource");

                entity.HasOne(s => s.Cooldown3_TimeMeasure).WithMany(a => a.Actions)
                    .HasForeignKey(s => s.Cooldown3_TimeMeasureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Action_Cooldown3TimeMeasure");
                
                entity.HasOne(s => s.ParentMultiaction).WithMany(a => a.ChildActions)
                    .HasForeignKey(s => s.ParentMultiactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Action_ParentMultiaction");

                entity.HasOne(s => s.BeastNote).WithMany(a => a.Actions)
                    .HasForeignKey(s => s.BeastNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Action_BeastNote");
            });
            modelBuilder.Entity<ActionThrow>(entity =>
            {
                entity.ToTable("ActionThrow");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ActionId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                
                entity.Property(e => e.Throw)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(s => s.Action).WithMany(a => a.ActionThrows)
                    .HasForeignKey(s => s.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ActionThrow_Action");
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnType("varchar(450)");
            });
            modelBuilder.Entity<BeastNote>(entity =>
            {
                entity.ToTable("BeastNote");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.HitPointsDice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AlignmentId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SizeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeastTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ModeratorId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SpellAbilityId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(s => s.Alignment).WithMany(a => a.BeastNotes)
                    .HasForeignKey(s => s.AlignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_BeastNote_Alignment");

                entity.HasOne(s => s.Size).WithMany(a => a.BeastNotes)
                    .HasForeignKey(s => s.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_BeastNote_Size");

                entity.HasOne(s => s.BeastType).WithMany(a => a.BeastNotes)
                    .HasForeignKey(s => s.BeastTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_BeastNote_BeastType");

                entity.HasOne(s => s.Author).WithMany(a => a.CreatedBeastNotes)
                    .HasForeignKey(s => s.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_BeastNote_Author");

                entity.HasOne(s => s.Moderator).WithMany(a => a.ModeratedBeastNotes)
                    .HasForeignKey(s => s.ModeratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_BeastNote_Moderator");

                entity.HasOne(s => s.SpellAbility).WithMany(a => a.BeastNotes)
                    .HasForeignKey(s => s.SpellAbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_BeastNote_SpellAbility");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.ToTable("Campaign");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Author).WithMany(a => a.Campaigns)
                    .HasForeignKey(s => s.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Campaign_Author");

            });
            modelBuilder.Entity<Scene>(entity =>
            {
                entity.ToTable("Scene");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SettingId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.Campaign).WithMany(a => a.Scenes)
                    .HasForeignKey(s => s.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Scene_Campaign");

                entity.HasOne(s => s.Setting).WithMany(a => a.Scenes)
                    .HasForeignKey(s => s.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Scene_Setting");

            });
            modelBuilder.Entity<SceneSave>(entity =>
            {
                entity.ToTable("SceneSave");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SceneId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentBeastInitiative)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(s => s.Scene).WithMany(a => a.SceneSaves)
                    .HasForeignKey(s => s.SceneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_SceneSave_Scene");

            });
            modelBuilder.Entity<FightTeam>(entity =>
            {
                entity.ToTable("FightTeam");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SceneSaveId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(s => s.SceneSave).WithMany(a => a.FightTeams)
                    .HasForeignKey(s => s.SceneSaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_FightTeam_SceneSave");
            });
            modelBuilder.Entity<Beast>(entity =>
            {
                entity.ToTable("Beast");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SceneSaveId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.FightTeamId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentInitiative)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(s => s.SceneSave).WithMany(a => a.Beasts)
                    .HasForeignKey(s => s.SceneSaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Beast_SceneSave");

                entity.HasOne(s => s.FightTeam).WithMany(a => a.Beasts)
                    .HasForeignKey(s => s.FightTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Beast_FightTeam");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
