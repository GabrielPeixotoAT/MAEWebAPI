using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Services.Subjects.Interface;
using Microsoft.AspNetCore.Mvc;
using MAEWebAPI.Data.DTOs.ClassShedule;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Controllers.Subjects
{
    [ApiController]
    [Route("[controller]")]
    public class ClassSheduleController : ControllerBase
    {
        IClassSheduleService classSheduleService;

        public ClassSheduleController(IClassSheduleService classSheduleService)
        {
            this.classSheduleService = classSheduleService;
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
        public IEnumerable<ReadClassSheduleDTO> GetClassShedule()
        {
            IEnumerable<ReadClassSheduleDTO> result = classSheduleService.GetClassShedules();

            return result;
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
