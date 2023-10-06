using PersonDatabaseApp.Enums;
using PersonDatabaseApp.Models;
using PersonDatabaseApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonDatabaseApp
{
    public partial class UserAdd : Form
    {
        private readonly DatabaseService _databaseService;
        private PersonService _personService;

        public UserAdd()
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

        private void UserAdd_Load(object sender, EventArgs e)
        {
            _databaseService.Connect();

            _personService = new PersonService(_databaseService);

            _personService.Refresh();
        }

        private void _btn_submit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Address address = new();

            address.City = _txtb_city.Text;
            address.Country = _txtb_country.Text;
            address.Zip = _txtb_zip.Text;
            address.Street = _txtb_street.Text;

            if (!_databaseService.InsertAddress(address)) MessageBox.Show("An error occured while trying to push information to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Person person = new();

            person.PersonId = Guid.NewGuid().ToString();
            person.Name = _txtb_name.Text;
            person.Surname = _txtb_surname.Text;
            person.Birthday = _date_birthday.Value;
            person.Sex = (Sex)_cmb_sex.SelectedIndex;

            if (!_databaseService.InsertPerson(person)) MessageBox.Show("An error occured while trying to push information to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!_databaseService.UpdateAddrIdWithId(person.PersonId, _databaseService.SelectScopeIdentity())) MessageBox.Show(Text = "An error occured while trying to push information to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _personService.Refresh();

            ClearInputs();
        }

        private void ClearInputs()
        {
            _txtb_name.Text = "";
            _txtb_surname.Text = "";

            _date_birthday.Value = DateTime.Now;

            _cmb_sex.SelectedIndex = -1;

            _txtb_city.Text = "";
            _txtb_country.Text = "";
            _txtb_zip.Text = "";
            _txtb_street.Text = "";
        }
        private bool ValidateInputs()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(_txtb_name.Text))
            {
                _txtb_name.BackColor = Color.Red;
                valid = false;
            }
            else
            {
                _txtb_surname.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(_txtb_surname.Text))
            {
                _txtb_surname.BackColor = Color.Red;
                valid = false;
            }
            else
            {
                _txtb_surname.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(_txtb_city.Text))
            {
                _txtb_city.BackColor = Color.Red;
                valid = false;
            }
            else
            {
                _txtb_city.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(_txtb_country.Text))
            {
                _txtb_country.BackColor = Color.Red;
                valid = false;
            }
            else
            {
                _txtb_country.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(_txtb_zip.Text))
            {
                _txtb_zip.BackColor = Color.Red;
                valid = false;
            }
            else
            {
                _txtb_zip.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(_txtb_street.Text))
            {
                _txtb_street.BackColor = Color.Red;
                valid = false;
            }
            else
            {
                _txtb_street.BackColor = Color.White;
            }

            return valid;
        }
    }
}
