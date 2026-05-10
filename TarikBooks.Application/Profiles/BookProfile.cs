using AutoMapper;
using TarikBooks.Application.Features.Books.Dtos;
using TarikBooks.Domain.Entities;

namespace TarikBooks.Application.Profiles;

internal class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<Book, BookDto>();
    }
}
