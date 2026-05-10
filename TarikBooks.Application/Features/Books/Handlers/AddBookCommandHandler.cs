using MediatR;
using TarikBooks.Application.Contracts.Data;
using TarikBooks.Application.Features.Books.Commands;
using TarikBooks.Application.Features.Books.Dtos;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Application.Features.Books.Handlers;

internal class AddBookCommandHandler(IBookRepository bookRepository) : IRequestHandler<AddBookCommand, BookDto>
{
    private readonly IBookRepository _bookRepository = bookRepository;

    public async Task<BookDto> Handle(AddBookCommand command, CancellationToken cancellationToken = default)
    {
        var book = new Book
        {
            Title = command.Title,
            AuthorId = command.AuthorId,
            LanguageId = command.LanguageId
        };

        _bookRepository.AddBook(book);
        await _bookRepository.SaveChangesAsync();

        var result = await _bookRepository.GetBookById(book.Id);
        return new BookDto(result!.Id, result.Title, result.AuthorId, result.LanguageId);
    }
}
