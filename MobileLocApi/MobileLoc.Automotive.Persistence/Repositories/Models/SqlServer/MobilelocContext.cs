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

        public virtual DbSet<CarMake> CarMake { get; set; }
        public virtual DbSet<CarModel> CarModel { get; set; }
        public virtual DbSet<CarYear> CarYear { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LocalHost;Initial Catalog=MobileLoc;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}