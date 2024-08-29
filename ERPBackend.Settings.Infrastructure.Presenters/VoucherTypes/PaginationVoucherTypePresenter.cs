namespace ERPBackend.Settings.Infrastructure.Presenters.VoucherTypes;

internal sealed class PaginationVoucherTypePresenter : IPaginationVoucherTypeOutputPort
{
    public PaginationVoucherTypeResponseDto PaginationResponse { get; private set; }

    public void Handle(PaginatedList<VoucherType> paginatedVoucherTypes)
    {
        var dtos = paginatedVoucherTypes.Items
            .Select(x => new VoucherTypeDto(Id: x.Id.Value, Name: x.Name, Code: x.Code, Description: x.Description,
                Status: x.Status)).ToList();

        PaginationResponse = new PaginationVoucherTypeResponseDto(Data: dtos,
            PageIndex: paginatedVoucherTypes.PageIndex, TotalPages: paginatedVoucherTypes.TotalPages,
            HasPreviousPage: paginatedVoucherTypes.HasPreviousPage, HasNextPage: paginatedVoucherTypes.HasNextPage);
    }
}