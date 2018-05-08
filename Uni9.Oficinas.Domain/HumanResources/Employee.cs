using System;
using System.Collections.Generic;
using System.Text;

namespace Uni9.Oficinas.Domain.HumanResources
{
    public class Employee
    {
        public Guid Id { get; set; } 
        public string Registration { get; set; } 
        public DateTime HiringDate { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public Guid IdEmployer { get; set; }
        public Guid IdRole { get; set; }
        public bool Enabled { get; set; }
        public DateTime InsertDate { get; set; }
        public Guid UserIdInserted { get; set; }
    }
}
