using Appforo.Class;
using System.Collections.Generic;

namespace Appforo.repositories
{
    public interface IEstablishmentRepository
    {
        void NewEstablishment(ModAppEstablishment establishment);
        void AddPeople(ModAppEstablishment establishment);
        List<ModAppEstablishment> LoadEstablishments();
        List<ModAppEstablishment> LoadEstablishmentByCity(string city);
    }
}