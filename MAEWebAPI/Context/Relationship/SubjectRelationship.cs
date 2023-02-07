using MAEWebAPI.Data.Models.Abstences;
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

            builder.Entity<Abstence>()
                .HasOne(abstence => abstence.Subject)
                .WithMany(subject => subject.Abstences)
                .HasForeignKey(abstence=> abstence.SubjectIDFK);

            builder.Entity<Abstence>()
                .HasOne(abstence => abstence.ClassSchedule)
                .WithMany(classShedule => classShedule.Abstences)
                .HasForeignKey(asbtence=> asbtence.ClassSheduleIDFK);

            builder.Entity<SubjectAbstences>()
                .HasOne(subjectAbestences => subjectAbestences.Subject)
                .WithMany(subject => subject.SubjectAbstences)
                .HasForeignKey(subjectAbstences => subjectAbstences.SubjectIDFK);
        }

        public void DefaultValues(ModelBuilder builder)
        {

        }
    }
}
