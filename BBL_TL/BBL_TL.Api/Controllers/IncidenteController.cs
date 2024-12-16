using BBL_TL.Core.Interfaces;
using BBL_TL.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BBL_TL.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidenteController : ControllerBase
    {
        private readonly IIncidenteRepo _incidenteRepo;

        public IncidenteController(IIncidenteRepo incidenteRepo)
        {
            _incidenteRepo = incidenteRepo;
        }

        [HttpGet("GetAllIncidentes")]
        public async Task<ActionResult<IEnumerable<Incidente>>> GetAllIncidentes()
        {
            var incidentes = await _incidenteRepo.GetAllIncidentes();

            return Ok(incidentes);
        }

        [HttpPost("InsertIncidente")]
        public async Task<ActionResult<int>> InsertIncidente(Incidente incidente)
        { 
            var insert = await _incidenteRepo.InsertIncidente(incidente);

            return Ok(insert);
        }

        [HttpPut("UpdateIncidente")]
        public async Task<ActionResult<int>> UpdateIncidente(Guid incidenteId, Incidente incidente)
        {
            var update = await _incidenteRepo.UpdateIncidente(incidenteId, incidente);

            return Ok(update);
        }

    }
}
