namespace AstroturfField.Entity.Entities;
public class AstroturfFieldOwner: EntityBase
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public Guid ArtificialTurfId { get; set; }
    public ICollection<ArtificialTurf> ArtificialTurves { get; set; }
}