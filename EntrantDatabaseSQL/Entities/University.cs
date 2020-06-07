using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrantDatabaseSQL
{
    class University
    {
        public University(string name, int id, string address)
        {
            Name = name;
            Id = id;
            Address = address;
        }

        public University(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public University(int id)
        {
            Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Speciality> Specialities { get; set; }
    }
}
