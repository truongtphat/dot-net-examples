using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ttp.Web.EfCoreInMemory.Application.Command;
using Ttp.Web.EfCoreInMemory.Application.Models;
using Ttp.Web.EfCoreInMemory.Application.Queries;

namespace Ttp.Web.EfCoreInMemory.Controllers
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
            return await _mediator.Send(new GetProductQuery());
        }

        [Route("")]
        [HttpPost]
        public async Task<ProductModel> Add([FromBody]AddProductCommand request)
        {
            return await _mediator.Send(request);
        }
    }
}
