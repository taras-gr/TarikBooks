using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Dal.EntityConfigurations;

internal class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(b => b.Language)
            .WithMany()
            .HasForeignKey(e => e.LanguageId)
            .IsRequired();

        builder.HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(e => e.AuthorId)
            .IsRequired();
    }
}