using Microsoft.EntityFrameworkCore;
using TableViewer.DbLayer;

namespace TableViewer
{
    public class AppDbContext(
        DbContextOptions<AppDbContext> options)
        : DbContext(options)
    {
        public DbSet<DbProduct> Products { get; init; }
    }
}