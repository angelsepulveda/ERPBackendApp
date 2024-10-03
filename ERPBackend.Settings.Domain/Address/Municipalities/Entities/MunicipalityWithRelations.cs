namespace ERPBackend.Settings.Domain.Address.Municipalities.Entities;

public class MunicipalityWithRelations(
    MunicipalityId id,
    string name,
    string code,
    bool status,
    CountryId countryId,
    string country,
    RegionId regionId,
    string region)
{
    public MunicipalityId Id => id;
    public string Name => name;
    public string? Code => code;
    public bool Status => status;
    public CountryId CountryId => countryId;
    public string Country => country;
    public RegionId RegionId => regionId;
    public string Region => region;
}