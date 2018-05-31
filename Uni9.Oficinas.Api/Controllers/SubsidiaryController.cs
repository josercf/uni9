using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uni9.Oficinas.Domain.Organization;
using Uni9.Oficinas.Domain.Organization.Repositories;

namespace Uni9.Oficinas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/v1.0/subsidiary")]
    public class SubsidiaryController : Controller
    {
        private readonly ISubsidiaryRepository _repository;

        public SubsidiaryController(ISubsidiaryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Post([FromBody] Subsidiary model)
        {
            model.Validate();

            if (model.Invalid)
                return BadRequest(model.Notifications);

            await _repository.Add(model);

            return Ok();
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var model = await _repository.GetAll();
            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var model = await _repository.Get(id);
            return Ok(model);
        }
    }
}