using Microsoft.EntityFrameworkCore;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Dal;

public class TarikBooksDbContext(DbContextOptions<TarikBooksDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }

    public DbSet<Language> Languages { get; set; }

    public DbSet<Country> Countries { get; set; }
}