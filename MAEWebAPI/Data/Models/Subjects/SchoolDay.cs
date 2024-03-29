﻿using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Models.Subjects
{
    public class SchoolDay
    {
        [Key]
        [Required]
        public int SchoolDayID { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual List<ClassSchedule> ClassSchedule { get; set; }
    }
}
