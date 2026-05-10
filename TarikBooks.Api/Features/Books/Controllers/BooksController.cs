using MediatR;
using Microsoft.AspNetCore.Mvc;
using TarikBooks.Application.Features.Books.Commands;
using TarikBooks.Application.Features.Books.Queries;

namespace TarikBooks.Api.Features.Books.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllBooks()
    {
        var result = await mediator.Send(new GetAllBooksQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(AddBookCommand addBookCommand)
    {
        var result = await mediator.Send(addBookCommand);
        return Ok(result);
    }
}
