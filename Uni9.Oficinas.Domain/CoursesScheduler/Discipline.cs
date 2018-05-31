using System;

namespace Uni9.Oficinas.Domain.CoursesScheduler
{
    public class Discipline
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfLessons { get; set; } 
        public string Enabled { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
