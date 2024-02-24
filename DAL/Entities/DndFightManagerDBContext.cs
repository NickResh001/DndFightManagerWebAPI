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

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=DESKTOP-67A5RQ1;Database=DndFightManager;Trusted_Connection=True;Encrypt=False;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ability>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

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

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
