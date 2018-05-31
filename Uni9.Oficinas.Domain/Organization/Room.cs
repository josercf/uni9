using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.Organization
{
    public class Room
    {
        public Room()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid IdBuilding { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public bool FutureRoom { get; set; }
        public bool IsLab { get; set; }
        public bool IsAvailable { get; set; }

        public virtual BuildingUniversity Building { get; set; }
    }
}
