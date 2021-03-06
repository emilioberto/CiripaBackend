﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Ciripa.Business.Commands;
using Ciripa.Business.Queries.Presences;
using Ciripa.Domain.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ciripa.Web.Controllers
{
    [Route("api/presences")]
    public class PresencesController : Controller
    {
        private readonly IMediator _mediator;
        
        public PresencesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("list/kid/{kidId}")]
        public Task<PresencesSummaryDto> GetKidPresencesByMonth(int kidId, [FromBody] ByDateDto model)
        {
            return _mediator.Send(new GetMonthlyPresencesByKidQuery(kidId, model.Date));
        }
        
        [HttpPost("list")]
        public async Task<List<PresenceDto>> GetPresencesByDate([FromBody] ByDateDto model)
        {
            return await _mediator.Send(new CreateMissingPresencesCommand(model.Date));
        }
        
        [HttpPut()]
        public Task<int> UpsertPresences([FromBody] List<PresenceDto> presences)
        {
            return _mediator.Send(new UpsertPresencesCommand(presences));
        }
    }
}