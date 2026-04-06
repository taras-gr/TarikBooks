namespace TarikBooks.Domain.Entities;

public class Country
{
    public int Id { get; set; }

    public required string Code { get; set; }

    public required string Title { get; set; }
}
