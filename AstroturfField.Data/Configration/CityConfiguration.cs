namespace AstroturfField.Data.Configration;
public class CityConfiguration : IEntityTypeConfiguration<City>
{
	public void Configure(EntityTypeBuilder<City> builder)
	{
		builder.HasData(new City()
		{
			Id = Guid.Parse("C3D8A7F4-5137-4BD3-A52E-4DB8ED951FD8"),
			Name = "Bilecik",
			ArtificialTurfFieldId = Guid.Parse("164D108A-CBB3-4E5E-9B47-A43738D2C5B1")
		}, new City()
		{
			Id = Guid.Parse("AFB580E1-AB0D-40D1-A26E-8FB443DDAC76"),
			Name = "Eskişehir",
			ArtificialTurfFieldId = Guid.Parse("4B90104A-5D36-44C6-8261-9C59B1653FF4")
		});
	}
}