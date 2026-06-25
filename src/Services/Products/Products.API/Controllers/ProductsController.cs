using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Features.Products.Commands;
using Products.Application.Features.Products.Queries;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateProductCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result =
                await _mediator.Send(
                    new GetProductByIdQuery(id));

            return Ok(result);
        }
    }
}
