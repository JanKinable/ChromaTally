using ChromaTally.Site.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChromaTally.Site.Data
{
    public class ChromaTallyDbContext : DbContext
    {
        public ChromaTallyDbContext (DbContextOptions<ChromaTallyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Nutrition> Nutrition { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nutrition>()
                .Property(e => e.Color)
                .HasConversion(new EnumToStringConverter<CategoryColor>())
                .HasColumnType("nvarchar(50)"); ;

            modelBuilder.Entity<Nutrition>()
                .Property(e => e.SubCategory)
                .HasConversion(new EnumToStringConverter<SubCategoryType>())
                .HasColumnType("nvarchar(50)"); ;

            modelBuilder.Entity<Nutrition>()
                .Property(e => e.Unit)
                .HasConversion(new EnumToStringConverter<UnitType>())
                .HasColumnType("nvarchar(50)"); ;

            modelBuilder.Entity<Nutrition>()
                .Property(e => e.BCMPortionUnit)
                .HasConversion(new EnumToStringConverter<BCMUnitType>())
                .HasColumnType("nvarchar(50)"); ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
