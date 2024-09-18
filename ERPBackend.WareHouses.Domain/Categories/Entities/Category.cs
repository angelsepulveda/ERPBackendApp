namespace ERPBackend.WareHouses.Domain.Categories.Entities;

public sealed class Category : BaseEntity<CategoryId>
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public bool Status { get; private set; }

    private Category(CategoryId id, string name, string? description, bool status)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = status;
    }
    
    public static Category Create(string name, string? description)
    {
        var categoryId = new CategoryId(Guid.NewGuid());
        
        return new Category(categoryId, name, description,true);
    }

    public void Update(string name, string? description)
    {
        Name = name;
        Description = description;
    }
    
    public void Delete()
    {
        Status = false;
    }
    
    public void Restore()
    {
        Status = true;
    }
}