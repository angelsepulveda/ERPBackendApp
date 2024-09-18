namespace ERPBackend.WareHouses.Domain.Core.Interfaces;

public interface IWareHouseUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}