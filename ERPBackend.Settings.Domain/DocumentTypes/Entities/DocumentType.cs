namespace ERPBackend.Settings.Domain.DocumentTypes.Entities;

public sealed class DocumentType : BaseEntity<DocumentTypeId>
{
    public string Name { get; private set; }
    public string? Code { get; private set; }
    public string? Description { get; private set; }
    public bool Status { get; private set; }

    private DocumentType(DocumentTypeId id, string name, string? code, string? description, bool status)
    {
        Id = id;
        Name = name;
        Code = code;
        Description = description;
        Status = status;
    }

    public static DocumentType Create(string name, string? code, string? description)
    { 
        var id = new DocumentTypeId(Guid.NewGuid());
        const bool status = true;
        return new DocumentType(id, name, code, description, status);
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