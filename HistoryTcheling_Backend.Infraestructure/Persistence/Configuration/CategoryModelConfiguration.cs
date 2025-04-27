using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Configuration
{
    public class CategoryModelConfiguration : IEntityTypeConfiguration<CategoryModel>
    {
        public void Configure(EntityTypeBuilder<CategoryModel> builder)
        {
            builder.ToTable("Category");

            builder.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
        }
    }
}
