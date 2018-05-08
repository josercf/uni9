using System;
using System.Collections.Generic;
using System.Text;
using Uni9.Oficinas.Domain.HumanResources;

namespace Uni9.Oficinas.Domain.Organization
{
    public class ClassPeriod
    {
        public Guid Id { get; set; }
        public Guid IdRotation { get; set; }
        public string Description { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool Enabled { get; set; }

        public virtual Rotation Rotation { get; set; }
    }
}
