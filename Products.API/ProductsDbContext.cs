using Bogus;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Entities;

namespace ProductsAPI.Database;

public class ProductsDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(SeedProducts());
    }

    private List<Product> SeedProducts()
    {
        int id = 0;

        var faker = new Faker<Product>()
        .RuleFor(a => a.Id, a => ++id)
        .RuleFor(a => a.Name, a => a.Commerce.Product())
        .RuleFor(a => a.ImageUri, a => $"https://example.com/images/product{id}.jpg")
        .RuleFor(a => a.Price, a => decimal.Parse(a.Commerce.Price()))
        .RuleFor(a => a.Description, a => a.Commerce.ProductDescription());


        var products = Enumerable.Range(1, 100)
           .Select((item) => faker.UseSeed(item).Generate())
           .ToList();

        return products;
    }


}