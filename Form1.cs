using PersonDatabaseApp.Enums;
using PersonDatabaseApp.Models;
using PersonDatabaseApp.Services;

namespace PersonDatabaseApp
{
    public partial class Form1 : Form
    {
        private readonly DatabaseService _databaseService;
        private PersonService _personService;

        public Form1()
        {
            InitializeComponent();

            _cmb_sex.DataSource = Enum.GetValues(typeof(Sex));

            _databaseService = new DatabaseService();
            _databaseService.OnDatabaseError += _databaseService_OnDatabaseError;
        }

        private void _databaseService_OnDatabaseError(Exception error)
        {
            MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _databaseService.Connect();

            _personService = new PersonService(_databaseService);

            _personService.Refresh();

            _lsb_Persons.Items.AddRange(_personService.People().ToArray());
        }

        private void _lsb_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lsb_Persons.SelectedIndex == -1) return;

            var item = _lsb_Persons.SelectedItem as Person;

            if (item == null) return;

            var address = _personService.GetAddressByPersonId(item.PersonId);

            _txtb_city.Text = address.City;
            _txtb_country.Text = address.Country;
            _txtb_zip.Text = address.Zip;
            _txtb_street.Text = address.Street;

            _txtb_name.Text = item.Name;
            _txtb_surname.Text = item.Surname;
            _lbl_person_id.Text = item.PersonId;
            _date_brithday.Value = item.Birthday;
            _cmb_sex.SelectedIndex = (int)item.Sex;

            _lbl_address_id.Text = address.AddressId.ToString();
        }

        private void _btn_adduserform_Click(object sender, EventArgs e)
        {
            UserAdd form2 = new UserAdd();

            form2.ShowDialog();
        }

        private void _btn_Refresh_Click(object sender, EventArgs e)
        {
            _personService.Refresh();

            _lsb_Persons.Items.Clear();

            _lsb_Persons.Items.AddRange(_personService.People().ToArray());
        }

        private void _btn_applyChanges_Click(object sender, EventArgs e)
        {
            Person new_person = new();

            new_person.Name = _txtb_name.Text;
            new_person.Surname = _txtb_surname.Text;
            new_person.Birthday = _date_brithday.Value;
            new_person.Sex = (Sex)_cmb_sex.SelectedIndex;

            _databaseService.UpdatePersonWithId(_lbl_person_id.Text, new_person);

            if (_lbl_address_id.Text != "-1")
            {
                Address new_address = new();

                new_address.City = _txtb_city.Text;
                new_address.Country = _txtb_country.Text;
                new_address.Zip = _txtb_zip.Text;
                new_address.Street = _txtb_street.Text;

                _databaseService.UpdateAddressWithId(int.Parse(_lbl_address_id.Text), new_address);
            }

            _btn_Refresh_Click(null, null);
        }
    }
}