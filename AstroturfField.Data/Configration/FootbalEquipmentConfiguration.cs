namespace AstroturfField.Data.Configration;
public class FootbalEquipmentConfiguration : IEntityTypeConfiguration<FootbalEquipment>
{
	public void Configure(EntityTypeBuilder<FootbalEquipment> builder)
	{
		builder.HasData(new FootbalEquipment() 
		{
			Id = Guid.Parse("5E8F0707-A9FC-4E1F-A4D9-7966AD1D74BD"),
			IsActive = true,
			Name = "Krampon"
		}, new FootbalEquipment() 
		{
			Id = Guid.Parse("7FBDFA79-100F-4B0C-88D6-1CA94BBC139B"),
			IsActive = true,
			Name = "Kaleci Eldiveni"
		});
	}
}