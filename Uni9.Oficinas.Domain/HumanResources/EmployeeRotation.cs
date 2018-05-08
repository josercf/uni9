using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.HumanResources
{
    public class EmployeeRotation
    {
        public Guid IdEmployee { get; set; }
        public Guid IdRotation { get; set; }
        public Guid BranchId { get; set; }
    }
}
