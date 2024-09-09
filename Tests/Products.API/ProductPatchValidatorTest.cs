using Microsoft.AspNetCore.JsonPatch;
using ProductsAPI.Entities;
using ProductsAPI.Validators;

namespace Tests.ProductsAPI;

public class ProductPatchValidatorTest
{
    [Fact]
    public void PriceOp_IsInvalid()
    {
        ProductPatchValidator validator = new();

        var input = new JsonPatchDocument<Product>();

        input.Operations.Add(new()
        {
            op = "add",
            path = "/price",
            value = "100.00"
        });

        var value = validator.Validate(input);

        Assert.False(value.Success);
    }

    [Fact]
    public void DescOp_IsValid()
    {
        ProductPatchValidator validator = new();

        var input = new JsonPatchDocument<Product>();

        input.Operations.Add(new()
        {
            op = "add",
            path = "/description",
            value = "new description"
        });

        var value = validator.Validate(input);

        Assert.True(value.Success);
    }
}