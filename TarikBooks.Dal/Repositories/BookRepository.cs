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
}
