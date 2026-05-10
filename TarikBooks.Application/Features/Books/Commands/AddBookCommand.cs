using MediatR;
using TarikBooks.Application.Features.Books.Dtos;

namespace TarikBooks.Application.Features.Books.Commands;

public record AddBookCommand(string Title, int AuthorId, int LanguageId) : IRequest<BookDto>;