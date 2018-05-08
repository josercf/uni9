using System;
using System.Collections.Generic;
using System.Text;
using Uni9.Oficinas.Domain.HumanResources;
using Uni9.Oficinas.Domain.Organization;

namespace Uni9.Oficinas.Domain.CoursesScheduler
{
    public class ClassroomGrid
    {
        public Guid Id { get; set; }

        public Guid IdCollegeSemester { get; set; }
        public Guid IdDiscipline { get; set; }
        public Guid IdProfessor { get; set; }
        public Guid IdClassPeriod { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool Enabled { get; set; }

        public DateTime InsertedDate { get; set; }
        public Guid IdUserInserted { get; set; }

        public CollegeSemester CollegeSemester { get; set; }
        public Discipline Discipline { get; set; }
        public Employee Professor { get; set; }
        public ClassPeriod ClassPeriod{get;set;}
    }
}
