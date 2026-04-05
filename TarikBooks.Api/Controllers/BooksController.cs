using MediatR;
using Microsoft.AspNetCore.Mvc;
using TarikBooks.Application.Books.Queries;

namespace TarikBooks.Api.Controllers;

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
}
