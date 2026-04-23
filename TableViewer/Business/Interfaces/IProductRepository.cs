using TableViewer.DbLayer;

namespace TableViewer.Business.Interfaces
{
    public interface IProductRepository
    {
        Task<List<DbProduct>> GetAllAsync();
        
        Task CreateAsync(DbProduct product);
    }
}