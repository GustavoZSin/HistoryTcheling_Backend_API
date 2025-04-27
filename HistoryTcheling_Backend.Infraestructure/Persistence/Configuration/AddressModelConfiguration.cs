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
    public class AddressModelConfiguration : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Address");

            builder.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");
            builder.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");
            builder.Property(e => e.Neighborhood)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            builder.Property(e => e.Street)
                    .HasMaxLength(100)
                    .IsUnicode(false);

            builder.HasOne(d => d.IdCityNavigation).WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_City");
        }
    }
}
