using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Models.Subjects;
using Microsoft.EntityFrameworkCore;

namespace MAEWebAPI.Context
{
    public class SubjectContext : DbContext
    {
        public SubjectContext(DbContextOptions<SubjectContext> opts) : base(opts)
        {
        
        }
            
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<SchoolDay> SchoolDays { get; set; }
        public DbSet<Abstence> Abstences { get; set; }
        public DbSet<SubjectAbstences> SubjectsAbstences { get; set; }
    }
}
