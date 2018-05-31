using System;
using System.Collections.Generic;

namespace Uni9.Oficinas.Domain.Organization
{
    public class BuildingUniversity
    {
        public BuildingUniversity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid IdSubsidiary { get; set; }
        public string Name { get; set; } 
        public virtual Subsidiary Subsidiary {get;set;}

        public IList<Room> Rooms { get; set; }
    }
}
