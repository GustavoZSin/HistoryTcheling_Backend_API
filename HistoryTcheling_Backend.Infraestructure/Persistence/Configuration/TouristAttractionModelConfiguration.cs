using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Configuration
{
    public class TouristAttractionModelConfiguration : IEntityTypeConfiguration<TouristAttractionModel>
    {
        public void Configure(EntityTypeBuilder<TouristAttractionModel> builder)
        {
            builder.ToTable("TouristAttraction");

            builder.Property(e => e.Description).IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.Address).WithMany(p => p.TouristAttractions)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_TouristAttraction_Address");

            builder.HasOne(d => d.BackgroundImage).WithMany(p => p.TouristAttractionBackgroundImages)
                .HasForeignKey(d => d.BackgroundImageId)
                .HasConstraintName("FK_Background_TouristAttraction_Image");

            builder.HasOne(d => d.Category).WithMany(p => p.TouristAttractions)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_TouristAttraction_Category");

            builder.HasOne(d => d.Icon).WithMany(p => p.TouristAttractionIcons)
                .HasForeignKey(d => d.IconId)
                .HasConstraintName("FK_Icon_TouristAttraction_Image");
        }
    }
}
