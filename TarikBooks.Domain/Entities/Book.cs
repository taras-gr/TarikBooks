namespace TarikBooks.Domain.Entities;

public class Book
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public int LanguageId { get; set; }

    public required Language Language { get; set; }
}