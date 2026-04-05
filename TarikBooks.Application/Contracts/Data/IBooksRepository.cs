using TarikBooks.Domain.Entities;

namespace TarikBooks.Application.Contracts.Data;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllBooks();
}