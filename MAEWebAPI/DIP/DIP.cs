using MAEWebAPI.Context.Relationship;
using MAEWebAPI.Services.Abstences;
using MAEWebAPI.Services.Abstences.Interface;
using MAEWebAPI.Services.Subjects;
using MAEWebAPI.Services.Subjects.Interface;

namespace MAEWebAPI.DIP
{
    public class DIP
    {
        public DIP(IServiceCollection services) 
        {
            services.AddScoped<IRelationship, SubjectRelationship>();

            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<ISchoolDayService, SchoolDayService>();
            services.AddScoped<IClassSheduleService, ClassSheduleService>();

            services.AddScoped<IAbstenceService, AbstenceService>();
            services.AddScoped<ISubjectAbstencesService, SubjectAbstencesService>();
        }
    }
}
