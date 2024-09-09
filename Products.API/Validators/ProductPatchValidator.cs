using Microsoft.AspNetCore.JsonPatch;
using ProductsAPI.Entities;
using Shared;

namespace ProductsAPI.Validators;

public class ProductPatchValidator
{
    private static readonly List<string> AllowedFields = new List<string>
    {
        "/description"
    };

    public ValidationResult Validate(JsonPatchDocument<Product> doc)
    {
        var validation = new ValidationResult();

        foreach (var operation in doc.Operations)
        {
            var path = operation.path.ToLowerInvariant();

            if (!AllowedFields.Contains(path))
            {
                validation.Errors.Add($"'{operation.path}' is not a valid patch field.");
            }
        }

        return validation;
    }
}