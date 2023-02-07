using AutoMapper;
using MAEWebAPI.Context;
using MAEWebAPI.Data.DTOs.ClassShedule;
using MAEWebAPI.Data.Models.Subjects;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Subjects.Interface;

namespace MAEWebAPI.Services.Subjects
{
    public class ClassSheduleService : IClassSheduleService
    {
        SubjectContext subjectContext;
        IMapper mapper;

        public ClassSheduleService(SubjectContext subjectContext, IMapper mapper)
        {
            this.subjectContext = subjectContext;
            this.mapper = mapper;
        }

        public Result InsertClassShedule(ClassSheduleRequest request)
        {
            CreateClassSheduleDTO create = mapper.Map<CreateClassSheduleDTO>(request);

            /*var result = GetClassSheduleByDateTime(create.StartTime, create.EndTime);
            if (result != null)
                return new ResultError("This Class Shedule is already registered");*/

            ClassSchedule classSchedule = mapper.Map<ClassSchedule>(create);

            subjectContext.ClassSchedules.Add(classSchedule);
            subjectContext.SaveChanges();

            return new ResultSuccess("Success");
        }

        public Result InsetMultiClassShedules(List<ClassSheduleRequest> requests)
        {
            foreach (ClassSheduleRequest request in requests)
            {
                var result = InsertClassShedule(request);

                if (result.hasError)
                    return new ResultError(result.message);
            }

            return new ResultSuccess("Success");
        }

        public IEnumerable<ReadClassSheduleDTO> GetClassShedules()
        {
            return mapper.Map<List<ReadClassSheduleDTO>>(subjectContext.ClassSchedules.ToList());
        }

        public Result<ReadClassSheduleDTO> GetClassSheduleByID(int id)
        {
            ClassSchedule? classSchedule = subjectContext.ClassSchedules.FirstOrDefault(cs => cs.ClassScheduleID == id);
            if (classSchedule == null)
                return new ResultError<ReadClassSheduleDTO>("Not found");
            
            ReadClassSheduleDTO read = mapper.Map<ReadClassSheduleDTO>(classSchedule);

            return new ResultSuccess<ReadClassSheduleDTO>(read);
        }

        public Result<ReadClassSheduleDTO> GetClassSheduleByDateTime(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
