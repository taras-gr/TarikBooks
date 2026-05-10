namespace TarikBooks.Domain.Entities;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int LanguageId { get; set; }

    public Language? Language { get; set; }

    public int AuthorId { get; set; }

    public Author? Author { get; set; }
}