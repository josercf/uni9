using System;
using System.Collections.Generic;
using System.Text;
using Uni9.Oficinas.Domain.Organization;

namespace Uni9.Oficinas.Domain.CoursesScheduler
{
    public class ClassroomAllocation
    {
        public Guid Id { get; set; }
        public Guid IdClassroomGrid { get; set; }

        public DateTime Date { get; set; }
        public Guid IdProfessor { get; set; }
        public int LessonNumber { get; set; }
        public int StudentsNumber { get; set; }
        public Guid IdLab { get; set; }
        public string Note { get; set; }
        public int Star { get; set; }


        public virtual ClassroomGrid Planned {get;set;}
        public virtual Lab Lab { get; set; }
    }
}
