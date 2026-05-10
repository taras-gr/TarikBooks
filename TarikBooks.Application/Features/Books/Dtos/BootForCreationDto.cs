namespace TarikBooks.Application.Features.Books.Dtos;

public record BookForCreationDto(string Title, int AuthorId, int LanguageId);