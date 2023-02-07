using MAEWebAPI.Data.Models.Subjects;
using Microsoft.EntityFrameworkCore;

namespace MAEWebAPI.Context.Relationship
{
    public class SubjectRelationship : IRelationship
    {
        public void CreateRelationship(ModelBuilder builder)
        {
            builder.Entity<ClassSchedule>()
                .HasOne(classSchedule => classSchedule.SchoolDay)
                .WithMany(schoolDay => schoolDay.ClassSchedule)
                .HasForeignKey(classShedule => classShedule.SchoolDayIDFK);

            builder.Entity<ClassSchedule>()
                .HasOne(classSchedule => classSchedule.Subject)
                .WithMany(subject => subject.ClassSchedules)
                .HasForeignKey(classSchedule => classSchedule.SubjectIDFK);
        }

        public void DefaultValues(ModelBuilder builder)
        {

        }
    }
}
