using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Services.Subjects.Interface;
using Microsoft.AspNetCore.Mvc;
using MAEWebAPI.Data.DTOs.ClassShedule;
using MAEWebAPI.Data.Result;
using System.Collections;

namespace MAEWebAPI.Controllers.Subjects
{
    [ApiController]
    [Route("[controller]")]
    public class ClassSheduleController : ControllerBase
    {
        IClassSheduleService classSheduleService;
        ISubjectService subjectService;

        public ClassSheduleController(IClassSheduleService classSheduleService, ISubjectService subjectService)
        {
            this.classSheduleService = classSheduleService;
            this.subjectService = subjectService;
        }

        [HttpPost]
        public IActionResult InsertClassShedule([FromBody] ClassSheduleRequest request)
        {
            var result = classSheduleService.InsertClassShedule(request);
            if (result.success)
                return Ok(result);

            return StatusCode(400, result.message);
        }

        [HttpPost("multi")]
        public IActionResult InsertMultiClassShedules([FromBody] List<ClassSheduleRequest> request)
        {
            var result = classSheduleService.InsetMultiClassShedules(request);
            if (result.success)
                return Ok(result);

            return StatusCode(400, result.message);
        }

        [HttpGet]
        public IEnumerable GetClassShedule()
        {
            IEnumerable<ReadClassSheduleDTO> result = classSheduleService.GetClassShedules();

            List<ClassSheduleResponse> response = new List<ClassSheduleResponse>();

            foreach (ReadClassSheduleDTO classShedule in result)
            {
                response.Add(new ClassSheduleResponse
                {
                    Shedules = classShedule.Shedules,
                    SchoolDayIDFK = classShedule.SchoolDayIDFK,
                    SubjectCode = subjectService.GetSubjectByID(classShedule.SubjectIDFK).Code
                });
            }

            return response;
        }

        [HttpGet("{id}")]
        public IActionResult GetClassSheduleByID(int id)
        {
            Result<ReadClassSheduleDTO> result = classSheduleService.GetClassSheduleByID(id);

            if(result.success)
                return Ok(result.result);
            
            return StatusCode(400, result.message);
        }
    }
}
