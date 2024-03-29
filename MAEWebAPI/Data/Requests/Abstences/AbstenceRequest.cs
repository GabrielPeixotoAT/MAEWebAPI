﻿using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Abstences
{
    public class AbstenceRequest
    {
        public string? Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int ClassSheduleIDFK { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }
        [Required]
        public int ClassCount { get; set; }
    }
}
