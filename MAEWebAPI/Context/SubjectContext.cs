using MAEWebAPI.Context.Relationship;
using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Models.Subjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MAEWebAPI.Context
{
    public class SubjectContext : DbContext
    {
        IEnumerable<IRelationship> relationships;

        public SubjectContext(DbContextOptions<SubjectContext> opts, IEnumerable<IRelationship> relationships) : base(opts)
        {
            this.relationships = relationships;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (IRelationship relationship in relationships)
            {
                relationship.CreateRelationship(builder);
                relationship.DefaultValues(builder);
            }

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<SchoolDay> SchoolDays { get; set; }
        public DbSet<Abstence> Abstences { get; set; }
        public DbSet<SubjectAbstences> SubjectsAbstences { get; set; }
    }
}
