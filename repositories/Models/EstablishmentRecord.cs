using Appforo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo.repositories.Models
{
    public static class EstablishmentRecord
    {

        public static ModAppEstablishment ToModel(int id, string name, int currentCapacity, int maximumCapacity, string city)
        {
            return new ModAppEstablishment
            {
                Id = id,
                Name = name,
                CurrentCapacity = currentCapacity,
                MaximumCapacity = maximumCapacity,
                City = city
            };
        }
    }
}
