using MediatR;
using TarikBooks.Application.Contracts.Data;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Application.Books.Queries;

public class GetAllBooksQueryHandler(IBookRepository bookRepository) : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
{
    public Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var result = bookRepository.GetAllBooks();
        return result;
    }
}
