using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.Organization
{
    public class Building
    {
        public Guid Id { get; set; }
        public Guid IdBranch { get; set; }
        public string Name { get; set; } 
        public virtual Branch Branch{get;set;}

        public IList<Room> Rooms { get; set; }
    }
}
