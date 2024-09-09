using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Database;
using ProductsAPI.Entities;
using ProductsAPI.Validators;

namespace ProductsAPI.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductController(ProductsDbContext db, ProductPatchValidator patchValidator) : ControllerBase
{
    [HttpPatch("{id}")]
    public async Task<ActionResult<Product>> Patch(int id, [FromBody] JsonPatchDocument<Product> doc)
    {
        var product = await db.Products.FirstOrDefaultAsync(a => a.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        var validationResult = patchValidator.Validate(doc);
        if (!validationResult.Success)
        {
            return BadRequest(validationResult);
        }

        doc.ApplyTo(product, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await db.SaveChangesAsync();

        return Ok(product);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> Get(int id)
    {
        var product = await db.Products.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpGet]
    public async Task<List<Product>> GetAll()
    {
        return await db.Products.AsNoTracking().ToListAsync();
    }

}
