namespace Shared;

public record ValidationResult
{
    public List<string> Errors { get; set; } = new();
    public bool Success => Errors.Count == 0;
}
