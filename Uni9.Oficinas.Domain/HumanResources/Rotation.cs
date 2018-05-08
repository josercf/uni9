using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.HumanResources
{
    public class Rotation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool Enable { get; set; }
    }
}
