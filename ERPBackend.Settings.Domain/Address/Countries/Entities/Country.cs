namespace ERPBackend.Settings.Domain.Address.Countries.Entities;

public sealed class Country : BaseEntity<CountryId>
{
    public string Name { get; private set; }
    public string? Code { get; private set; }
    public bool Status { get; private set; }

    private Country(CountryId id, string name, string? code, bool status)
    {
        Id = id;
        Name = name;
        Code = code;
        Status = status;
    }
    
    public static Country Create(string name, string? code)
    {
        var id = new CountryId(Guid.NewGuid());
        return new Country(id, name, code, true);
    }

    public void Update(string name, string? code)
    {
        Name = name;
        Code = code;
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