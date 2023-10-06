using PersonDatabaseApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabaseApp.Models
{
    public class Person
    {
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public int AddressId { get; set; }

        public override string ToString()
        {
            //return $"{PersonId} | {Name} | {Surname} | {Birthday.ToString()} | {AddressId}";
            return $"{Name} {Surname}";
        }
    }
}
