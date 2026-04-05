using MediatR;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Application.Books.Queries;

public record GetAllBooksQuery : IRequest<IEnumerable<Book>>;