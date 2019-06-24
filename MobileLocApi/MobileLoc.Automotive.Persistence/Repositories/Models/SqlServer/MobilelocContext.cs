using Microsoft.EntityFrameworkCore;

namespace MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer
{
    public partial class MobilelocContext : DbContext
    {
        public MobilelocContext()
        {
        }

        public MobilelocContext(DbContextOptions<MobilelocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarMake> CarMake { get; set; }
        public virtual DbSet<CarModel> CarModel { get; set; }
        public virtual DbSet<CarYear> CarYear { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LocalHost;Initial Catalog=MobileLoc;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car", "lookup");

                entity.HasIndex(e => new { e.CarModelId, e.CarYearId })
                    .HasName("UX_lookup_Car_CarModelId_CarYearId")
                    .IsUnique();

                entity.Property(e => e.InsertDt)
                    .HasColumnName("InsertDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CarMake)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarMakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lookup_Car_lookup_CarMake_CarMakeId");

                entity.HasOne(d => d.CarModel)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lookup_Car_lookup_CarModel_CarModelId");

                entity.HasOne(d => d.CarYear)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lookup_Car_lookup_CarMake_CarYearId");

                entity.HasOne(d => d.InsertByNavigation)
                    .WithMany(p => p.CarInsertByNavigation)
                    .HasForeignKey(d => d.InsertBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lookup_Car_people_SystemUser_InsertBy");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CarUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lookup_Car_people_SystemUser_UpdateBy");
            });

            modelBuilder.Entity<CarMake>(entity =>
            {
                entity.ToTable("CarMake", "lookup");

                entity.HasIndex(e => e.CarMakeName)
                    .HasName("UX_lookup_CarMake_CarMakeName")
                    .IsUnique();

                entity.Property(e => e.CarMakeName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.ToTable("CarModel", "lookup");

                entity.HasIndex(e => new { e.CarModelName, e.CarMakeId })
                    .HasName("UX_lookup_CarModel_CarModelName")
                    .IsUnique();

                entity.Property(e => e.CarModelName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CarMake)
                    .WithMany(p => p.CarModel)
                    .HasForeignKey(d => d.CarMakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_lookup_CarModel_lookup_CarMake_CarMakeId");
            });

            modelBuilder.Entity<CarYear>(entity =>
            {
                entity.ToTable("CarYear", "lookup");

                entity.HasIndex(e => e.CarYear1)
                    .HasName("UX_lookup_CarYear_CarYear")
                    .IsUnique();

                entity.Property(e => e.CarYear1)
                    .IsRequired()
                    .HasColumnName("CarYear")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.ToTable("SystemUser", "people");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SystemUserName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SystemUserType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SystemUserParent)
                    .WithMany(p => p.InverseSystemUserParent)
                    .HasForeignKey(d => d.SystemUserParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_people_SystemUser_people_SystemUser_SystemUserParentId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}