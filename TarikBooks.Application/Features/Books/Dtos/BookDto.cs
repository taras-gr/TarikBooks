namespace TarikBooks.Application.Features.Books.Dtos;

public record BookDto(int Id, string Title, int AuthorId, int LanguageId);