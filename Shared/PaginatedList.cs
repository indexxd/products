namespace Shared;

public record PaginatedList<T>(List<T> Items, int Page, int Total);