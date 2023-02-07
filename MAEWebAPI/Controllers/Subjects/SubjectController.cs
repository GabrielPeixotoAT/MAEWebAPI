using Microsoft.AspNetCore.Mvc;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.DTOs.Subjects;
using MAEWebAPI.Services.Subjects.Interface;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Controllers.Subjects
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {
        ISubjectService subjectService;

        public SubjectController(
            ISubjectService subjectService
        ) {
            this.subjectService = subjectService;
        }

        [HttpPost]
        public IActionResult InsertSubject([FromBody] SubjectRequest subjectRequest)
        {
            Result<ReadSubjectDTO> result = subjectService.InsertSubject(subjectRequest);

            if(result.success)
                return Ok(result.message);
            
            return StatusCode(400, result.message);
        }

        [HttpPost("multi")]
        public IActionResult InsertMultiSubjects([FromBody] List<SubjectRequest> subjectRequests)
        {
            Result result = subjectService.InsertMultiSubjects(subjectRequests);

            if(result.success)
                return Ok(result.message);

            return StatusCode(400, result.message);
        }

        [HttpGet]
        public IEnumerable<ReadSubjectDTO> GetSubjects([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return subjectService.GetSubjects().Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubject(int id)
        {
            ReadSubjectDTO? subject = subjectService.GetSubjectByID(id);
            if (subject == null)
                return NotFound();
            return Ok(subject);
        }
    }
}
