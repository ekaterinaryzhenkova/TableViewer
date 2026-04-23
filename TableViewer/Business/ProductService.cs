using TableViewer.Business.Interfaces;
using TableViewer.DbLayer;

namespace TableViewer.Business
{
    public class ProductService(IProductRepository repository) : IProductService
    {
        public Task<List<DbProduct>> GetAllAsync()
        {
            return repository.GetAllAsync();
        }

        public Task AddAsync(DbProduct product)
        {
            return repository.CreateAsync(product);
        }
    }
}