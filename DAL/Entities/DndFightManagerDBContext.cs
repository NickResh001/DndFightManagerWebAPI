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

        public virtual EFCore.DbSet<SpeedList> SpeedLists { get; set; }

        public virtual EFCore.DbSet<BeastNote> BeastNote { get; set; }


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
                    .HasMaxLength(100)
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

            #endregion

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });
            modelBuilder.Entity<BeastNote>(entity =>
            {
                entity.ToTable("BeastNote");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
