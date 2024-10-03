namespace ERPBackend.Settings.Domain.Address.Municipalities.Entities;

public class Municipality : BaseEntity<MunicipalityId>
{
    public string Name { get; private set; }
    public string? Code { get; private set; }
    public CountryId CountryId { get; private set; }
    public RegionId RegionId { get; private set; }
    public bool Status { get; private set; }
    
    public virtual Region Region { get; set; }
    public virtual Country Country { get; set; }

    private Municipality(MunicipalityId id, string name, string? code, CountryId countryId, RegionId regionId,
        bool status)
    {
        Id = id;
        Name = name;
        Code = code;
        CountryId = countryId;
        RegionId = regionId;
        Status = status;
    }

    public static Municipality Create(string name, string? code, CountryId countryId, RegionId regionId)
    {
        var id = new MunicipalityId(Guid.NewGuid());

        return new Municipality(id, name, code, countryId, regionId, true);
    }

    public void Update(string name, string? code, CountryId countryId, RegionId regionId)
    {
        Name = name;
        Code = code;
        CountryId = countryId;
        RegionId = regionId;
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