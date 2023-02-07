using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.DTOs.SubjectAbstences;
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
        ISubjectAbstencesService subjectAbstencesService;

        public AbstenceController(IAbstenceService abstenceService, ISubjectAbstencesService subjectAbstencesService)
        {
            this.abstenceService = abstenceService;
            this.subjectAbstencesService = subjectAbstencesService;
        }

        [HttpPost]
        public IActionResult InsertAbstence([FromBody] AbstenceRequest request)
        {
            Result<CreateAbstenceDTO> result = abstenceService.InsertAbstence(request);

            if (result.success)
                return Ok(result);

            return StatusCode(400, result.message);
        }

        [HttpPost("day")]
        public IActionResult InsertAbstenceDay([FromBody] AbstenceRequest request)
        {
            Result<CreateAbstenceDTO> result = abstenceService.InsertAbstenceDay(request);

            if (result.success)
                return Ok(result);

            return StatusCode(400, result.message);
        }

        [HttpGet]
        public IEnumerable<ReadAbstenceDTO> GetAbstences()
        {
            return abstenceService.GetAbstences();
        }

        [HttpGet("subjects")]
        public IEnumerable<ReadSubjectAbstencesDTO> GetSubjectAbstences()
        {
            return subjectAbstencesService.GetSubjectAbstences();
        }

        [HttpGet("percent")]
        public IActionResult GetAbstencesBySubject(string subjectName)
        {
            SubjectAbstenceRequest? request = subjectAbstencesService.GetSubjectAbstencesBySubjectName(subjectName);

            if (request != null)
                return Ok(request);

            return StatusCode(404, "The Subject was not found");
        }
    }
}
