using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Entities;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public string ImageUri { get; set; } = null!;

    public string? Description { get; set; }
}