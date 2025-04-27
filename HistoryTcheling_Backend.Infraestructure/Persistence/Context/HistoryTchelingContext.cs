using HistoryTcheling_Backend.Infraestructure.Persistence.Configuration;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Context;

public partial class HistoryTchelingContext : DbContext
{
    public HistoryTchelingContext()
    {
    }

    public HistoryTchelingContext(DbContextOptions<HistoryTchelingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressModel> Addresses { get; set; }
    public virtual DbSet<CategoryModel> Categories { get; set; }
    public virtual DbSet<CityModel> Cities { get; set; }
    public virtual DbSet<CountryModel> Countries { get; set; }
    public virtual DbSet<ImageModel> Images { get; set; }
    public virtual DbSet<StateModel> States { get; set; }
    public virtual DbSet<TouristAttractionModel> TouristAttractions { get; set; }
    public virtual DbSet<UserModel> Users { get; set; }
    public virtual DbSet<UserVisitedAttractionModel> UserVisitedAttractions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=history-tcheling;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AddressModelConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryModelConfiguration());
        modelBuilder.ApplyConfiguration(new CityModelConfiguration());
        modelBuilder.ApplyConfiguration(new CountryModelConfiguration());
        modelBuilder.ApplyConfiguration(new ImageModelConfiguration());
        modelBuilder.ApplyConfiguration(new StateModelConfiguration());
        modelBuilder.ApplyConfiguration(new TouristAttractionModelConfiguration());
        modelBuilder.ApplyConfiguration(new UserModelConfiguration());
        modelBuilder.ApplyConfiguration(new UserVisitedAttractionModelConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
