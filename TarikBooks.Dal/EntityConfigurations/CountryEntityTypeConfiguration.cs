using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Dal.EntityConfigurations;

internal class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Code)
            .HasMaxLength(2)
            .IsRequired();

        builder.Property(c => c.Title)
            .HasMaxLength(100)
            .IsRequired();
    }
}