using System;
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
    [Route("trackingActivity")]
    public class TrackingActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrackingActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("")]
        [HttpPost]
        public async Task Tracking([FromBody] TrackingActivityCommand request)
        {
            await _mediator.Send(request);
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<List<TrackingActivityModel>> GetByUserId(Guid userId)
        {
            return await _mediator.Send(new TrackingActivityQuery
            {
                UserId = userId
            });
        }
    }
}
