namespace AstroturfField.Data.Configration;
public class ArtificialTurfConfiguration : IEntityTypeConfiguration<ArtificialTurf>
{
	public void Configure(EntityTypeBuilder<ArtificialTurf> builder)
	{
		builder.HasData(new ArtificialTurf() 
		{
			Id = Guid.Parse("164D108A-CBB3-4E5E-9B47-A43738D2C5B1"),
			Adress = "Sanayinin Girişi",
			District = "Merkez",
			CreatedDate = DateTime.UtcNow,
			Name = "Gökkaya",
			AstroturfFieldOwnerId = Guid.Parse("58B71AA4-80ED-4D76-A062-8CEE2BBE4928"),
			CityId = Guid.Parse("C3D8A7F4-5137-4BD3-A52E-4DB8ED951FD8")
		},new ArtificialTurf() 
		{
			Id = Guid.Parse("D7209B6C-1B0A-49F4-B181-FC155585A948"),
			Adress = "Sanayinin Sonu",
			District = "Merkez",
			CreatedDate = DateTime.UtcNow,
			Name = "Kardeşler",
			AstroturfFieldOwnerId = Guid.Parse("829820ED-D1FF-4995-B7BF-3AD6983FF0CD"),
			CityId = Guid.Parse("AFB580E1-AB0D-40D1-A26E-8FB443DDAC76")
		});
	}
}