using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.Requests.Abstences;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Abstences.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MAEWebAPI.Controllers.Abstences
{
    [ApiController]
    [Route("[controller]")]
    public class AbstenceController : ControllerBase
    {
        IAbstenceService abstenceService;

        public AbstenceController(IAbstenceService abstenceService)
        {
            this.abstenceService = abstenceService;
        }

        [HttpPost]
        public IActionResult InsertAbstence([FromBody] AbstenceRequest request)
        {
            Result<CreateAbstenceDTO> result = abstenceService.InsertAbstence(request);

            if (result.success)
                return Ok(result);

            return StatusCode(400, result.message);
        }

        [HttpGet]
        public IEnumerable<ReadAbstenceDTO> GetAbstences()
        {
            return abstenceService.GetAbstences();
        }
    }
}
