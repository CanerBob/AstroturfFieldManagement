namespace AstroturfField.Data.Context;
public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<ArtificialTurf> ArtificialTurves { get; set; }
    public DbSet<AstroturfFieldOwner> AstroturfFieldOwners { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<FootbalEquipment> FootbalEquipments { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}