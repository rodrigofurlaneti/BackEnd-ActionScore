using FSI.ActionScore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FSI.ActionScore.Infrastructure.Persistence
{
    public sealed class ActionScoreDbContext : DbContext
    {
        public ActionScoreDbContext(DbContextOptions<ActionScoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<ImpactType> ImpactTypes => Set<ImpactType>();
        public DbSet<UserAccount> UserAccounts => Set<UserAccount>();
        public DbSet<ActionModel> ActionModels => Set<ActionModel>();
        public DbSet<ActionRecord> ActionRecords => Set<ActionRecord>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ImpactType
            modelBuilder.Entity<ImpactType>(entity =>
            {
                entity.ToTable("impact_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("impact_id");
                entity.Property(e => e.Name).HasColumnName("impact_name").HasMaxLength(50).IsRequired();
                entity.Property(e => e.Description).HasColumnName("impact_description").HasMaxLength(300);
                entity.Property(e => e.Score).HasColumnName("impact_score").IsRequired();
            });

            // UserAccount
            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.ToTable("user_account");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("user_id");
                entity.Property(e => e.Name).HasColumnName("user_name").HasMaxLength(150).IsRequired();
                entity.Property(e => e.Email).HasColumnName("user_email").HasMaxLength(150).IsRequired();
                entity.Property(e => e.CreatedAt).HasColumnName("user_created_at");
                entity.Property(e => e.IsActive).HasColumnName("user_is_active");
            });

            // ActionModel
            modelBuilder.Entity<ActionModel>(entity =>
            {
                entity.ToTable("action_model");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("model_id");
                entity.Property(e => e.ImpactTypeId).HasColumnName("impact_id");
                entity.Property(e => e.Title).HasColumnName("model_title").HasMaxLength(150).IsRequired();
                entity.Property(e => e.Description).HasColumnName("model_description").HasMaxLength(500);
                entity.Property(e => e.Score).HasColumnName("model_score").IsRequired();
                entity.Property(e => e.IsActive).HasColumnName("model_is_active");

                entity.HasOne(e => e.ImpactType)
                    .WithMany(i => i.ActionModels)
                    .HasForeignKey(e => e.ImpactTypeId);
            });

            // ActionRecord
            modelBuilder.Entity<ActionRecord>(entity =>
            {
                entity.ToTable("action_record");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("record_id");
                entity.Property(e => e.UserAccountId).HasColumnName("user_id");
                entity.Property(e => e.ActionModelId).HasColumnName("model_id");
                entity.Property(e => e.ImpactTypeId).HasColumnName("impact_id");
                entity.Property(e => e.Title).HasColumnName("record_title").HasMaxLength(150);
                entity.Property(e => e.Description).HasColumnName("record_description").HasMaxLength(500);
                entity.Property(e => e.Score).HasColumnName("record_score");
                entity.Property(e => e.CreatedAt).HasColumnName("record_created_at");

                entity.HasOne(e => e.UserAccount)
                    .WithMany(u => u.ActionRecords)
                    .HasForeignKey(e => e.UserAccountId);

                entity.HasOne(e => e.ActionModel)
                    .WithMany(m => m.ActionRecords)
                    .HasForeignKey(e => e.ActionModelId);

                entity.HasOne(e => e.ImpactType)
                    .WithMany(i => i.ActionRecords)
                    .HasForeignKey(e => e.ImpactTypeId);
            });
        }
    }
}