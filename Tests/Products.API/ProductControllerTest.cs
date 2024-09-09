using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using v1 = ProductsAPI.Controllers.v1;
using v2 = ProductsAPI.Controllers.v2;
using ProductsAPI.Database;
using ProductsAPI.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Tests.ProductsAPI;

public class ProductControllerTest : IDisposable
{
    private ProductsDbContext _dbContext;
    private const int PRODUCTS_COUNT = 100;

    public ProductControllerTest()
    {
        var options = new DbContextOptionsBuilder<ProductsDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;

        _dbContext = new ProductsDbContext(options);
        _dbContext.Products.AddRange(GenerateProducts());
        _dbContext.SaveChanges();
    }

    [Fact]
    public async Task Patch_UpdatesDesc()
    {
        var id = 10;
        var newDesc = "new description";
        var input = new JsonPatchDocument<Product>();

        input.Operations.Add(new()
        {
            op = "add",
            path = "/description",
            value = newDesc
        });

        var controller = new v1.ProductController(_dbContext, new());
        var res = (await controller.Patch(id, input)).Result as OkObjectResult;
        var editedProduct = _dbContext.Products.FirstOrDefault(a => a.Id == id);

        Assert.Equal(newDesc, editedProduct?.Description);
    }

    [Fact]
    public async Task Get_ReturnsOneProduct()
    {
        var id = 10;

        var controller = new v1.ProductController(_dbContext, new());
        var res = (await controller.Get(id)).Result as OkObjectResult;

        var product = res?.Value as Product;

        Assert.Equal(id, product?.Id);
    }

    [Fact]
    public async Task GetPaginated_ReturnsCorrect()
    {
        var page = 3;
        var perPage = 7;

        var controller = new v2.ProductController(_dbContext);

        var res = await controller.GetPaginated(page, perPage);

        Assert.Equal(perPage, res.Items.Count());
        Assert.Equal(PRODUCTS_COUNT, res.Total);
        Assert.Equal((page - 1) * perPage + 1, res.Items[0].Id);
    }


    private static IEnumerable<Product> GenerateProducts()
    {
        for (int i = 1; i <= PRODUCTS_COUNT; i++)
        {
            yield return new Product
            {
                Id = i,
                Name = $"Product {i}",
                ImageUri = $"https://example.com/images/product{i}.jpg",
                Price = 10000,
                Description = $"This is the description for Product {i}."
            };
        }
    }

    public void Dispose()
    {
        _dbContext.DisposeAsync();
    }
}