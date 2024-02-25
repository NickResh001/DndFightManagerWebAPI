using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public DndFightManagerDBContext()
        {
        }
        public DndFightManagerDBContext(DbContextOptions<DndFightManagerDBContext> options)
            : base(options)
        {
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


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=DESKTOP-67A5RQ1;Database=DndFightManager;Trusted_Connection=True;Encrypt=False;");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
