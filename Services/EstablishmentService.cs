using Appforo.Class;
using Appforo.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo.Services
{
    public class EstablishmentService : IEstablishmentService
    {
        private readonly IEstablishmentRepository _establishmentRepository;
        public EstablishmentService(IEstablishmentRepository establishmentRepository)
        {
            _establishmentRepository = establishmentRepository;
        }
        public void NewEstablishment(ModAppEstablishment establishment)
        {
            _establishmentRepository.NewEstablishment(establishment);
        }
        public void AddPeople(ModAppEstablishment establishment)
        {
            establishment.AddPeople();
            _establishmentRepository.AddPeople(establishment);

        }
        public List<ModAppEstablishment> LoadEstablishments()
        {
            return _establishmentRepository.LoadEstablishments();
        }
        
        public List<ModAppEstablishment> LoadEstablishmentByCity(string city)
        {
            return _establishmentRepository.LoadEstablishmentByCity(city);
        }
    }
}
