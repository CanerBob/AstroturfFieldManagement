namespace AstroturfField.Data.Configration;
public class AstroturfFieldOwnerConfiguration : IEntityTypeConfiguration<AstroturfFieldOwner>
{
	public void Configure(EntityTypeBuilder<AstroturfFieldOwner> builder)
	{
		builder.HasData(new AstroturfFieldOwner()
		{
			Id = Guid.Parse("58B71AA4-80ED-4D76-A062-8CEE2BBE4928"),
			FullName = "Caner Bayraktar",
			PhoneNumber = "1234567890",
			ArtificialTurfId = Guid.Parse("164D108A-CBB3-4E5E-9B47-A43738D2C5B1")
		},new AstroturfFieldOwner()
		{
			Id = Guid.Parse("829820ED-D1FF-4995-B7BF-3AD6983FF0CD"),
			FullName = "Ferdi Kadı",
			PhoneNumber = "1234567890",
			ArtificialTurfId = Guid.Parse("D7209B6C-1B0A-49F4-B181-FC155585A948")
		});
	}
}