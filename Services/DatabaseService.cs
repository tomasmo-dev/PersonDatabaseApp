using Microsoft.Data.SqlClient;
using PersonDatabaseApp.Enums;
using PersonDatabaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabaseApp.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;
        private readonly SqlConnection _connection;

        public delegate void ErrorDelegate(Exception error);
        public event ErrorDelegate OnDatabaseError;


        public DatabaseService()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "localhost,6661";
            builder.UserID = "SA";
            builder.Password = "Heslo1234.";
            builder.InitialCatalog = "PersonAppDb";

            builder.TrustServerCertificate = true;

            _connectionString = builder.ConnectionString;

            _connection = new SqlConnection(_connectionString);
        }

        public void Connect()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
            }
        }

        public IEnumerable<Person>? Persons(int count = 10)
        {
            var sql = "SELECT TOP (@count) [person_id], [name], [surname], [birthday], [sex], ISNULL([address_id], -1) FROM [Person]";

            try
            {
                using (var command = new SqlCommand(sql, _connection))
                {
                    command.Parameters.AddWithValue("@count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        var persons = new List<Person>();

                        while (reader.Read())
                        {
                            var person = new Person();

                            person.PersonId = reader.GetString(0);
                            person.Name = reader.GetString(1);
                            person.Surname = reader.GetString(2);
                            person.Birthday = reader.GetDateTime(3);
                            person.Sex = (Sex)reader.GetInt32(4);
                            person.AddressId = reader.GetInt32(5);

                            persons.Add(person);
                        }

                        return persons;
                    }
                }
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return null;
            }
        }

        public IEnumerable<Address> Addresses(int count = 10)
        {
            var sql = "SELECT TOP (@count) [address_id], [street], [city], [zip], [country] FROM [Address]";

            try
            {
                using (var command = new SqlCommand(sql, _connection))
                {
                    command.Parameters.AddWithValue("@count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        var addresses = new List<Address>();

                        while (reader.Read())
                        {
                            Address address = new Address();

                            address.AddressId = reader.GetInt32(0);
                            address.Street = reader.GetString(1);
                            address.City = reader.GetString(2);
                            address.Zip = reader.GetString(3);
                            address.Country = reader.GetString(4);

                            addresses.Add(address);
                        }

                        return addresses;
                    }
                }
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return null;
            }
        }

        public bool InsertPerson(Person person) 
        {
            var sql = "INSERT INTO [Person] ([person_id], [name], [surname], [birthday], [sex]) VALUES ((@person_id), (@name), (@surname), (@birthday), (@sex));";

            try
            {
                using (SqlCommand command = new(sql, _connection))
                {
                    command.Parameters.AddWithValue("@person_id", person.PersonId);
                    command.Parameters.AddWithValue("@name", person.Name);
                    command.Parameters.AddWithValue("@surname", person.Surname);
                    command.Parameters.AddWithValue("@birthday", person.Birthday);
                    command.Parameters.AddWithValue("@sex", (int)person.Sex);

                    int ret_rows = command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return false;
            }
        }

        public bool InsertAddress(Address addr)
        {
            var sql = "INSERT INTO [Address] ([street], [city], [zip], [country]) VALUES ((@street), (@city), (@zip), (@country));";

            try
            {
                using (SqlCommand command = new(sql, _connection))
                {
                    command.Parameters.AddWithValue("@street", addr.Street);
                    command.Parameters.AddWithValue("@city", addr.City);
                    command.Parameters.AddWithValue("@zip", addr.Zip);
                    command.Parameters.AddWithValue("@country", addr.Country);

                    var num_rows = command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return false;
            }
        }

        public int SelectScopeIdentity()
        {
            var sql = "SELECT IDENT_CURRENT((@tbname));";

            try
            {
                int ret = -1;
                using (SqlCommand command = new(sql, _connection))
                {
                    command.Parameters.AddWithValue("@tbname", "Address");
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        ret = Convert.ToInt32(reader.GetDecimal(0));
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return -1;
            }
        }

        public bool UpdateAddrIdWithId(string PersonGuid, int addr_id)
        {
            var sql = "UPDATE [Person] SET [address_id] = (@addrId) WHERE [person_id] = (@person_guid);";

            try
            {
                using (SqlCommand command = new(sql, _connection))
                {
                    command.Parameters.AddWithValue("@addrId", addr_id);
                    command.Parameters.AddWithValue("@person_guid", PersonGuid.ToString());

                    int ret_rows = command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return false;
            }
        }

        public bool UpdatePersonWithId(string guid, Person person)
        {
            var sql = "UPDATE [Person] SET [name] = (@name), [surname] = (@surname), [birthday] = (@birthday), [sex] = (@sex) WHERE [person_id] = (@person_id);";

            try
            {
                using (SqlCommand command = new(sql, _connection))
                {
                    command.Parameters.AddWithValue("@name", person.Name);
                    command.Parameters.AddWithValue("@surname", person.Surname);
                    command.Parameters.AddWithValue("@birthday", person.Birthday);
                    command.Parameters.AddWithValue("@sex", (int)person.Sex);

                    command.Parameters.AddWithValue("@person_id", guid);

                    int ret_rows = command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return false;
            }
        }

        public bool UpdateAddressWithId(int Address_Id, Address address)
        {
            var sql = "UPDATE [Address] SET [street] = (@street), [city] = (@city), [zip] = (@zip), [country] = (@country) WHERE [address_id] = (@address_id);";

            try
            {
                using (SqlCommand command = new(sql, _connection))
                {
                    command.Parameters.AddWithValue("@street", address.Street);
                    command.Parameters.AddWithValue("@city", address.City);
                    command.Parameters.AddWithValue("@zip", address.Zip);
                    command.Parameters.AddWithValue("@country", address.Country);

                    command.Parameters.AddWithValue("@address_id", Address_Id);

                    int ret_rows = command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                OnDatabaseError.Invoke(ex);
                return false;
            }
        }
    }
}
