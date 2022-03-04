using Microsoft.EntityFrameworkCore;

#nullable disable

namespace XUnitTestNet5.Web.Models
{
    public partial class XUnitTestNet5Context : DbContext
    {
        public XUnitTestNet5Context()
        {
        }

        public XUnitTestNet5Context(DbContextOptions<XUnitTestNet5Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
