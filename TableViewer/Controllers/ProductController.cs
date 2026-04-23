using Microsoft.AspNetCore.Mvc;
using TableViewer.Business.Interfaces;
using TableViewer.DbLayer;

namespace TableViewer.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<DbProduct>> Get(
            [FromServices] IProductService service)
        {
            return await service.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [FromServices] IProductService service,
            [FromBody] DbProduct product)
        {
            await service.AddAsync(product);
            return Ok(product);
        }
    }
}