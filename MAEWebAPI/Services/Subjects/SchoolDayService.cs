using AutoMapper;
using MAEWebAPI.Context;
using MAEWebAPI.Data.DTOs.SchoolDay;
using MAEWebAPI.Data.Models.Subjects;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Subjects.Interface;

namespace MAEWebAPI.Services.Subjects
{
    public class SchoolDayService : ISchoolDayService
    {
        SubjectContext context;
        IMapper mapper;

        public SchoolDayService(
            SubjectContext context, 
            IMapper mapper
        ) {
            this.context = context;
            this.mapper = mapper;
        }

        public Result<CreateSchoolDayDTO> InsertSchoolDay(SchoolDayRequest request)
        {
            CreateSchoolDayDTO schoolDay = mapper.Map<CreateSchoolDayDTO>(request);

            ReadSchoolDayDTO? readSchoolDay = GetSchoolDayByDate(schoolDay.Description);

            if (readSchoolDay != null )
                return new ResultError<CreateSchoolDayDTO>("This Day is already registered");

            context.SchoolDays.Add(mapper.Map<SchoolDay>(schoolDay));
            context.SaveChanges();

            return new ResultSuccess<CreateSchoolDayDTO>(schoolDay, "Success");
        }

        public Result InsertMultiSchoolDays(List<SchoolDayRequest> requests)
        {
            foreach (SchoolDayRequest request in requests)
            {
                var result = InsertSchoolDay(request);

                if (result.hasError)
                    return new ResultError(result.message);
            }

            return new ResultSuccess("Success");
        }

        public IEnumerable<ReadSchoolDayDTO> GetSchoolDays()
        {
            return mapper.Map<List<ReadSchoolDayDTO>>(context.SchoolDays.ToList());
        }

        public ReadSchoolDayDTO GetSchoolDayByID(int id)
        {
            return mapper.Map<ReadSchoolDayDTO>(context.SchoolDays.FirstOrDefault(sd => sd.SchoolDayID == id));
        }

        public ReadSchoolDayDTO GetSchoolDayByDate(DateTime date)
        {
            return mapper.Map<ReadSchoolDayDTO>(context.SchoolDays.FirstOrDefault(sd => sd.Description == date));
        }
    }
}
