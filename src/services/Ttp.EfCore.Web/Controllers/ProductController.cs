using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ttp.EfCore.Web.Application.Command;
using Ttp.EfCore.Web.Application.Models;
using Ttp.EfCore.Web.Application.Queries;

namespace Ttp.EfCore.Web.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("")]
        [HttpGet]
        public async Task<List<ProductModel>> Gets()
        {
            return await _mediator.Send(new GetProductsQuery());
        }

        [Route("")]
        [HttpPost]
        public async Task<ProductModel> Add([FromBody]AddProductCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
