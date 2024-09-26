namespace ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Interfaces;

public interface IPaginationCountryInputPort
{
    Task HandleAsync(PaginationCountryPaylaodDto paylaodDto);
}