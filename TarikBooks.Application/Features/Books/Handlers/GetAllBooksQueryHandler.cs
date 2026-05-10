using AutoMapper;
using MediatR;
using TarikBooks.Application.Contracts.Data;
using TarikBooks.Application.Features.Books.Dtos;
using TarikBooks.Application.Features.Books.Queries;

namespace TarikBooks.Application.Features.Books.Handlers;

public class GetAllBooksQueryHandler(IBookRepository bookRepository, IMapper mapper) : IRequestHandler<GetAllBooksQuery, IEnumerable<BookDto>>
{
    public async Task<IEnumerable<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await bookRepository.GetAllBooks();
        var result =  mapper.Map<IEnumerable<BookDto>>(books);
        return result;
    }
}
