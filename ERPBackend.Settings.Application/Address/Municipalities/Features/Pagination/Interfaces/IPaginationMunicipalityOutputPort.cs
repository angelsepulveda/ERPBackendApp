namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Interfaces;

public interface IPaginationMunicipalityOutputPort
{
    PaginationMunicipalityResponseDto Response { get; }
    void Handle(PaginatedList<MunicipalityWithRelations> paginatedList);
}