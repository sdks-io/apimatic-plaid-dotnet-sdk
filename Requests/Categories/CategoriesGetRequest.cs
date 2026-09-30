namespace ThePlaidApi.Requests.Categories;

/// <summary>
/// The inputs of the CategoriesGet operation.
/// </summary>
public sealed record CategoriesGetRequest
{
    public required object Body { get; init; }
}
