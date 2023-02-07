using MAEWebAPI.Data.DTOs.SchoolDay;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Subjects.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MAEWebAPI.Controllers.Subjects
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolDayController : ControllerBase
    {
        ISchoolDayService schoolDayService;

        public SchoolDayController(ISchoolDayService schoolDayService)
        {
            this.schoolDayService = schoolDayService;
        }

        [HttpPost]
        public IActionResult InsertSchoolDay([FromBody] SchoolDayRequest request)
        {
            Result<CreateSchoolDayDTO> result = schoolDayService.InsertSchoolDay(request);

            if (result.success)
                return Ok(result.message);

            return StatusCode(400, result.message);
        }

        [HttpGet]
        public IActionResult GetSchoolDays()
        {
            IEnumerable<ReadSchoolDayDTO> result = schoolDayService.GetSchoolDays();

            return Ok(result);
        }
    }
}
