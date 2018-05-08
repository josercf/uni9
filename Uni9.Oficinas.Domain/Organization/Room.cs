using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.Organization
{
    public class Room
    {
        public Guid Id { get; set; }
        public Guid IdBuilding { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public bool FutureRoom { get; set; }

        public virtual Building Building { get; set; }
    }
}
