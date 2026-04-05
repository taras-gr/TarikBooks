using Microsoft.EntityFrameworkCore;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Dal;

public class TarikBooksDbContext(DbContextOptions<TarikBooksDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
}