using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Database;
using ProductsAPI.Entities;
using Shared;

namespace ProductsAPI.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductController(ProductsDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<PaginatedList<Product>> GetPaginated(int page = 1, int perPage = 10)
    {
        if (page < 1)
        {
            page = 1;
        }

        var products = await db.Products
            .AsNoTracking()
            .Skip(perPage * (page - 1))
            .Take(perPage)
            .ToListAsync();

        var total = await db.Products.CountAsync();

        return new PaginatedList<Product>(products, page, total);
    }
}
