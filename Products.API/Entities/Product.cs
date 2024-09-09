using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Entities;

public class Product
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [MaxLength(2000)]
    public string ImageUri { get; set; } = null!;

    [MaxLength(1000)]
    public string? Description { get; set; }
}