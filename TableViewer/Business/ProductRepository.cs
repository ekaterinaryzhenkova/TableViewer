using Microsoft.EntityFrameworkCore;
using TableViewer.Business.Interfaces;
using TableViewer.DbLayer;

namespace TableViewer.Business
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task<List<DbProduct>> GetAllAsync()
        {
            return await context.Products.ToListAsync();
        }

        public async Task CreateAsync(DbProduct product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }
    }
}