using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.HumanResources
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Enable { get; set; }
    }
}
