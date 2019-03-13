using APIIntegrationDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIIntegrationDemo.Context
{
    public partial class DisneyContext : DbContext
    {
        public DisneyContext()
        {
        }

        public DisneyContext(DbContextOptions<DisneyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attraction> Attraction { get; set; }

        // Unable to generate entity type for table 'dbo.Shopping'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=DisneyData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Attraction>(entity =>
            {
                entity.Property(e => e.AttractionId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.NotesTips).HasColumnType("text");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

            });

        }
    }
}
