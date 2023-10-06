using PersonDatabaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabaseApp.Services
{
    public class AddressService
    {
        private readonly DatabaseService _service;
        private readonly List<Address> addresses;


        public int AddressCount => addresses.Count;

        public DateTime LastUpdate { get; private set; }


        public AddressService(DatabaseService service)
        {
            _service = service;

            addresses = new List<Address>();

            Refresh();
        }

        public void Refresh()
        {
            addresses.Clear();

            var address = _service.Addresses();

            if (address != null)
            {
                addresses.AddRange(address);

                LastUpdate = DateTime.Now;
            }
        }

        public IEnumerable<Address> Addresses(bool refresh = false)
        {
            if (refresh || addresses.Count == 0) Refresh();

            return addresses;
        }

        public Address GetAddressById(int address_id)
        {
            if (AddressCount == 0) Refresh();

            var addr = addresses.FirstOrDefault(a => a.AddressId == address_id);

            if (addr == null)
            {
                return new Address()
                {
                    AddressId = -1,
                    City = "null",
                    Country = "null",
                    Street = "null",
                    Zip = "null"
                };
            }

            return addr;
        }
    }
}
