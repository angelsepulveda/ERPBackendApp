namespace ERPBackend.Settings.Domain.Address.Regions.Entities;

public class RegionWithRelation(RegionId id, string name, string code, bool status, CountryId countryId, string country)
{
    public RegionId Id => id;
    public string Name => name;
    public string? Code => code;
    public bool Status => status;
    public CountryId CountryId => countryId;
    public string Country => country;
}