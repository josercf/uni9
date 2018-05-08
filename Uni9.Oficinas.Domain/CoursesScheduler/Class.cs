using System;
using Uni9.Oficinas.Domain.Organization;

namespace Uni9.Oficinas.Domain.CoursesScheduler
{
    public class Class
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public string Serie { get; set; }
        public Guid IdCoordinator { get; set; }
        public string Half { get; set; } 
        public Guid IdRoom {get;set;}
        public Room Room { get; set; }
        public bool Enabled { get; set; }
        public Guid IdUserInserted { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
