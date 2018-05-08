using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.CoursesScheduler
{
    public class CollegeSemester
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public int Half { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
