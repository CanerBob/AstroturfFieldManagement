namespace AstroturfField.Core.Entities;
public class EntityBase: IEntityBase
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; } = true;
}