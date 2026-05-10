using MediatR;
using TarikBooks.Application.Features.Books.Dtos;

namespace TarikBooks.Application.Features.Books.Queries;

public record GetAllBooksQuery : IRequest<IEnumerable<BookDto>>;