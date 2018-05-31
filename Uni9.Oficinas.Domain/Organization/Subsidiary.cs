using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace Uni9.Oficinas.Domain.Organization
{
    /// <summary>
    /// This class represents a subsidiary of Uninove. e.g. Vila Maria, Vergueiro, etc. 
    /// </summary>
    public class Subsidiary : Notifiable, IValidatable
    {
        public Subsidiary()
        {
            Id = Guid.NewGuid();
        }

        //public Subsidiary(string name, string description)
        //{
        //    Id = Guid.NewGuid();
        //    Name = name;
        //    Description = description;
        //}

        //public Subsidiary(Guid id, string name, string description)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //}

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BuildingUniversity> Buildings { get; set; }

        public void SetParentIds()
        {
            foreach (var building in Buildings)
            {
                building.IdSubsidiary = Id;

                foreach (var room in building.Rooms)
                    room.IdBuilding = building.Id;
            }
        }

        public void Validate()
        {
            AddNotifications(new Contract()
                .HasMinLen(Name, 5, nameof(Name), "Nome da filial precisa ter pelo menos 5 caracteres")
                .HasMinLen(Description, 5, nameof(Description), "Descrição da filial precisa ter pelo menos 5 caracteres")
            );
        }
    }
}
