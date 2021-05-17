using Appforo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo.Services
{
    public class EstablishmentService : IEstablishmentService
    {
        public void AddPeople(ModAppEstablishment establishment)
        {
            var a = establishment.AddPeople();

        }
    }
}
