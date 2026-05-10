using Microsoft.EntityFrameworkCore;
using TarikBooks.Application.Contracts.Data;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Dal.Repositories;

public class BookRepository(TarikBooksDbContext dbContext) : IBookRepository
{
    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await dbContext.Books.ToListAsync();
    }

    public async Task<Book?> GetBookById(int id)
    {
        return await dbContext.Books.FirstOrDefaultAsync(s => s.Id == id);
    }

    public void AddBook(Book bookToAdd)
    {
        dbContext.Books.Add(bookToAdd);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync() > 0;
    }
}
