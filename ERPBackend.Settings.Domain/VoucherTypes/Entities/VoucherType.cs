namespace ERPBackend.Settings.Domain.VoucherTypes.Entities;

public sealed class VoucherType : BaseEntity<VoucherTypeId>
{
    public string Name { get; private set; }
    public string? Code { get; private set; }
    public string? Description { get; private set; }
    public bool Status { get; private set; }

    private VoucherType(VoucherTypeId id, string name, string? code, string? description, bool status)
    {
        Id = id;
        Name = name;
        Code = code;
        Description = description;
        Status = status;
    }

    public static VoucherType Create(string name, string? code, string? description)
    {
        var voucherTypeId = new VoucherTypeId(Guid.NewGuid());
        const bool status = true;
        return new VoucherType(voucherTypeId, name, code, description, status);
    }

    public void Update(string name, string? code, string? description)
    {
        Name = name;
        Code = code;
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