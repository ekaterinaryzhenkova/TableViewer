using TableViewer.DbLayer;

namespace TableViewer.Business.Interfaces
{
    public interface IProductService
    {
        Task<List<DbProduct>> GetAllAsync();
        
        Task AddAsync(DbProduct product);
    }
}