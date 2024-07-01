namespace AstroturfField.Entity.Entities;
public class ArtificialTurf: EntityBase
{
    public string Adress { get; set; }
    public string District { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid AstroturfFieldOwnerId { get; set; }
    public AstroturfFieldOwner AstroturfFieldOwner { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
}