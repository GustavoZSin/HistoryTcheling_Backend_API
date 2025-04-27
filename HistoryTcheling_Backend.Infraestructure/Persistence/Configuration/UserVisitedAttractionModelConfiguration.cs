using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Configuration
{
    internal class UserVisitedAttractionModelConfiguration : IEntityTypeConfiguration<UserVisitedAttractionModel>
    {
        public void Configure(EntityTypeBuilder<UserVisitedAttractionModel> builder)
        {
            builder.ToTable("UserVisitedAttraction");

            builder.Property(e => e.VisitedDate).HasDefaultValueSql("(sysdatetime())");

            builder.HasOne(d => d.IdTouristAttractionNavigation).WithMany(p => p.UserVisitedAttractions)
                .HasForeignKey(d => d.IdTouristAttraction)
                .HasConstraintName("FK_UserVisitedAttraction_TouristAttraction");

            builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserVisitedAttractions)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_UserVisitedAttraction_User");
        }
    }
}
