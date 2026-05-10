using TarikBooks.Domain.Entities;

namespace TarikBooks.Application.Contracts.Data;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllBooks();

    Task<Book?> GetBookById(int id);

    void AddBook(Book bookToAdd);

    Task<bool> SaveChangesAsync();
}