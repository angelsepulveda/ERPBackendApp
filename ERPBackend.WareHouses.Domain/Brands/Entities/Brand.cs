namespace ERPBackend.WareHouses.Domain.Brands.Entities;

public sealed class Brand : BaseEntity<BrandId>
{ 
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public bool Status { get; private set; }

    private Brand(BrandId id, string name, string? description, bool status)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = status;
    }

    public static Brand Create(string name, string? description)
    {
       var id = new BrandId(Guid.NewGuid());    
       
       return new Brand(id, name, description, true);
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