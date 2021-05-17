using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo.Class
{
    public class ModAppEstablishment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int CurrentCapacity { get; set; }
        public int MaximumCapacity { get; set; }
        public int PeopleNew { get; set; }



        public bool AddPeople()
        {
            if (!Fit())
                return false;
            CurrentCapacity += PeopleNew;
            return true;
        }

        public bool Fit()
        {
            return CurrentCapacity + PeopleNew <= MaximumCapacity;
        }
    }
}
