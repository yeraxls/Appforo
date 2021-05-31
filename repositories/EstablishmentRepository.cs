using Appforo.Class;
using Appforo.repositories.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo.repositories
{
    public class EstablishmentRepository : IEstablishmentRepository
    {
        private string database = "server=(localdb)\\Prueba;database=appforo;Integrated Security= true";
        public EstablishmentRepository()
        {

        }

        public void NewEstablishment(ModAppEstablishment establishment)
        {
            var query = $"INSERT INTO Establishment (Name, CurrentCapacity, MaximumCapacity, City) VALUES('{establishment.Name}', 0, {establishment.MaximumCapacity}, '{establishment.City}');";
            using (SqlConnection connection = new SqlConnection(database))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.ExecuteReader();
            }
        }

        public void AddPeople(ModAppEstablishment establishment)
        {
            var query = $"update Establishment set CurrentCapacity = {establishment.CurrentCapacity} where Id = {establishment.Id}";
            using (SqlConnection connection = new SqlConnection(database))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var data = command.ExecuteReader();
            }
        }

        public List<ModAppEstablishment> LoadEstablishments()
        {
            var result = new List<ModAppEstablishment>();
            var query = $"SELECT * FROM Establishment";
            using (SqlConnection connection = new SqlConnection(database))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var data = command.ExecuteReader();
                while (data.Read())
                {
                    result.Add(EstablishmentRecord.ToModel(
                        (int)data["Id"], 
                        data["Name"].ToString(), 
                        (int)data["CurrentCapacity"], 
                        (int)data["MaximumCapacity"],
                        data["City"].ToString()));
                }
            }

            return result;
        }

        public List<ModAppEstablishment> LoadEstablishmentByCity(string city)
        {
            var result = new List<ModAppEstablishment>();
            var query = $"SELECT * FROM Establishment where UPPER(City) = UPPER('{city}')";
            using (SqlConnection connection = new SqlConnection(database))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                var data = command.ExecuteReader();
                while (data.Read())
                {
                    result.Add(EstablishmentRecord.ToModel(
                        (int)data["Id"],
                        data["Name"].ToString(),
                        (int)data["CurrentCapacity"],
                        (int)data["MaximumCapacity"],
                        data["City"].ToString()));
                }
            }

            return result;
        }
    }
}
