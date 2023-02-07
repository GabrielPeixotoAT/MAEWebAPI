using MAEWebAPI.Services.Subjects;
using MAEWebAPI.Services.Subjects.Interface;

namespace MAEWebAPI.DIP
{
    public class DIP
    {
        public DIP(IServiceCollection services) 
        {
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<ISchoolDayService, SchoolDayService>();
            services.AddScoped<IClassSheduleService, ClassSheduleService>();
        }
    }
}
