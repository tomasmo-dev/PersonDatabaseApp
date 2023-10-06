using PersonDatabaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabaseApp.Services
{
    public class PersonService
    {
        private readonly DatabaseService _databaseService;
        private readonly AddressService _addressService;

        private readonly List<Person> _people;

        public int PersonCount => _people.Count;

        public DateTime LastUpdate { get; private set; }

        public PersonService(DatabaseService service)
        {
            _databaseService = service;
            _addressService = new AddressService(_databaseService);

            _people = new List<Person>();
        }

        public void Refresh()
        {
            _people.Clear();

            _addressService.Refresh();

            var persons = _databaseService.Persons();

            if (persons != null)
            {
                _people.AddRange(persons);

                LastUpdate = DateTime.Now;
            }
        }

        public IEnumerable<Person> People(bool refresh = false)
        {
            if (refresh || _people.Count == 0) Refresh();

            return _people;
        }

        public Person GetPersonById(string id)
        {
            return _people.FirstOrDefault(p => p.PersonId == id);
        }

        public Address GetAddressByPersonId(string personId)
        {
            var address_id = GetPersonById(personId).AddressId;

            return _addressService.GetAddressById(address_id);
        }


    }
}
