namespace AstroturfField.Entity.Entities;
public class Reservation: EntityBase
{
	public Guid ArtificialTurfId { get; set; }
    public ArtificialTurf ArtificialTurf { get; set; }
	public Guid FootbalEquipmentId { get; set; }
	public ICollection<FootbalEquipment>? FootbalEquipment { get; set; }
    public DateTime MatchTime  { get; set; }
    public DateTime TimeRange  { get; set; }
}