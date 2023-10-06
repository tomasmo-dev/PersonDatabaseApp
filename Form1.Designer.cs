namespace PersonDatabaseApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _lsb_Persons = new ListBox();
            _lbl_street = new Label();
            _lbl_city = new Label();
            _lbl_zip = new Label();
            _lbl_country = new Label();
            _btn_adduserform = new Button();
            _btn_Refresh = new Button();
            _txtb_street = new TextBox();
            _txtb_city = new TextBox();
            _txtb_zip = new TextBox();
            _txtb_country = new TextBox();
            label1 = new Label();
            _lbl_person_id = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            _txtb_name = new TextBox();
            _txtb_surname = new TextBox();
            _date_brithday = new DateTimePicker();
            _cmb_sex = new ComboBox();
            label5 = new Label();
            _btn_applyChanges = new Button();
            _lbl_address_id = new Label();
            SuspendLayout();
            // 
            // _lsb_Persons
            // 
            _lsb_Persons.FormattingEnabled = true;
            _lsb_Persons.ItemHeight = 37;
            _lsb_Persons.Location = new Point(12, 12);
            _lsb_Persons.Name = "_lsb_Persons";
            _lsb_Persons.Size = new Size(1061, 1336);
            _lsb_Persons.TabIndex = 0;
            _lsb_Persons.SelectedIndexChanged += _lsb_Persons_SelectedIndexChanged;
            // 
            // _lbl_street
            // 
            _lbl_street.AutoSize = true;
            _lbl_street.Location = new Point(1303, 73);
            _lbl_street.Name = "_lbl_street";
            _lbl_street.Size = new Size(85, 37);
            _lbl_street.TabIndex = 1;
            _lbl_street.Text = "Street";
            // 
            // _lbl_city
            // 
            _lbl_city.AutoSize = true;
            _lbl_city.Location = new Point(1556, 73);
            _lbl_city.Name = "_lbl_city";
            _lbl_city.Size = new Size(63, 37);
            _lbl_city.TabIndex = 2;
            _lbl_city.Text = "City";
            // 
            // _lbl_zip
            // 
            _lbl_zip.AutoSize = true;
            _lbl_zip.Location = new Point(1795, 73);
            _lbl_zip.Name = "_lbl_zip";
            _lbl_zip.Size = new Size(55, 37);
            _lbl_zip.TabIndex = 3;
            _lbl_zip.Text = "Zip";
            // 
            // _lbl_country
            // 
            _lbl_country.AutoSize = true;
            _lbl_country.Location = new Point(1970, 73);
            _lbl_country.Name = "_lbl_country";
            _lbl_country.Size = new Size(111, 37);
            _lbl_country.TabIndex = 4;
            _lbl_country.Text = "Country";
            // 
            // _btn_adduserform
            // 
            _btn_adduserform.Location = new Point(1079, 1377);
            _btn_adduserform.Name = "_btn_adduserform";
            _btn_adduserform.Size = new Size(169, 52);
            _btn_adduserform.TabIndex = 5;
            _btn_adduserform.Text = "Add user";
            _btn_adduserform.UseVisualStyleBackColor = true;
            _btn_adduserform.Click += _btn_adduserform_Click;
            // 
            // _btn_Refresh
            // 
            _btn_Refresh.Location = new Point(12, 1377);
            _btn_Refresh.Name = "_btn_Refresh";
            _btn_Refresh.Size = new Size(1061, 52);
            _btn_Refresh.TabIndex = 6;
            _btn_Refresh.Text = "Refresh";
            _btn_Refresh.UseVisualStyleBackColor = true;
            _btn_Refresh.Click += _btn_Refresh_Click;
            // 
            // _txtb_street
            // 
            _txtb_street.Location = new Point(1163, 141);
            _txtb_street.Name = "_txtb_street";
            _txtb_street.Size = new Size(225, 43);
            _txtb_street.TabIndex = 7;
            // 
            // _txtb_city
            // 
            _txtb_city.Location = new Point(1394, 141);
            _txtb_city.Name = "_txtb_city";
            _txtb_city.Size = new Size(225, 43);
            _txtb_city.TabIndex = 8;
            // 
            // _txtb_zip
            // 
            _txtb_zip.Location = new Point(1625, 141);
            _txtb_zip.Name = "_txtb_zip";
            _txtb_zip.Size = new Size(225, 43);
            _txtb_zip.TabIndex = 9;
            // 
            // _txtb_country
            // 
            _txtb_country.Location = new Point(1856, 141);
            _txtb_country.Name = "_txtb_country";
            _txtb_country.Size = new Size(225, 43);
            _txtb_country.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1208, 391);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 11;
            label1.Text = "Person ID";
            // 
            // _lbl_person_id
            // 
            _lbl_person_id.AutoSize = true;
            _lbl_person_id.Location = new Point(1208, 428);
            _lbl_person_id.Name = "_lbl_person_id";
            _lbl_person_id.Size = new Size(28, 37);
            _lbl_person_id.TabIndex = 12;
            _lbl_person_id.Text = "_";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1394, 255);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1625, 255);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 14;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1856, 255);
            label4.Name = "label4";
            label4.Size = new Size(115, 37);
            label4.TabIndex = 15;
            label4.Text = "Birthday";
            // 
            // _txtb_name
            // 
            _txtb_name.Location = new Point(1394, 329);
            _txtb_name.Name = "_txtb_name";
            _txtb_name.Size = new Size(225, 43);
            _txtb_name.TabIndex = 16;
            // 
            // _txtb_surname
            // 
            _txtb_surname.Location = new Point(1625, 330);
            _txtb_surname.Name = "_txtb_surname";
            _txtb_surname.Size = new Size(225, 43);
            _txtb_surname.TabIndex = 17;
            // 
            // _date_brithday
            // 
            _date_brithday.Location = new Point(1856, 330);
            _date_brithday.Name = "_date_brithday";
            _date_brithday.Size = new Size(450, 43);
            _date_brithday.TabIndex = 18;
            // 
            // _cmb_sex
            // 
            _cmb_sex.FormattingEnabled = true;
            _cmb_sex.Location = new Point(2146, 141);
            _cmb_sex.Name = "_cmb_sex";
            _cmb_sex.Size = new Size(160, 45);
            _cmb_sex.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2249, 73);
            label5.Name = "label5";
            label5.Size = new Size(57, 37);
            label5.TabIndex = 20;
            label5.Text = "Sex";
            // 
            // _btn_applyChanges
            // 
            _btn_applyChanges.Location = new Point(1079, 569);
            _btn_applyChanges.Name = "_btn_applyChanges";
            _btn_applyChanges.Size = new Size(1261, 168);
            _btn_applyChanges.TabIndex = 21;
            _btn_applyChanges.Text = "Apply Changes";
            _btn_applyChanges.UseVisualStyleBackColor = true;
            _btn_applyChanges.Click += _btn_applyChanges_Click;
            // 
            // _lbl_address_id
            // 
            _lbl_address_id.AutoSize = true;
            _lbl_address_id.Location = new Point(2182, 1407);
            _lbl_address_id.Name = "_lbl_address_id";
            _lbl_address_id.Size = new Size(43, 37);
            _lbl_address_id.TabIndex = 22;
            _lbl_address_id.Text = "-1";
            _lbl_address_id.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2352, 1465);
            Controls.Add(_lbl_address_id);
            Controls.Add(_btn_applyChanges);
            Controls.Add(label5);
            Controls.Add(_cmb_sex);
            Controls.Add(_date_brithday);
            Controls.Add(_txtb_surname);
            Controls.Add(_txtb_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(_lbl_person_id);
            Controls.Add(label1);
            Controls.Add(_txtb_country);
            Controls.Add(_txtb_zip);
            Controls.Add(_txtb_city);
            Controls.Add(_txtb_street);
            Controls.Add(_btn_Refresh);
            Controls.Add(_btn_adduserform);
            Controls.Add(_lbl_country);
            Controls.Add(_lbl_zip);
            Controls.Add(_lbl_city);
            Controls.Add(_lbl_street);
            Controls.Add(_lsb_Persons);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox _lsb_Persons;
        private Label _lbl_street;
        private Label _lbl_city;
        private Label _lbl_zip;
        private Label _lbl_country;
        private Button _btn_adduserform;
        private Button _btn_Refresh;
        private TextBox _txtb_street;
        private TextBox _txtb_city;
        private TextBox _txtb_zip;
        private TextBox _txtb_country;
        private Label label1;
        private Label _lbl_person_id;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox _txtb_name;
        private TextBox _txtb_surname;
        private DateTimePicker _date_brithday;
        private ComboBox _cmb_sex;
        private Label label5;
        private Button _btn_applyChanges;
        private Label _lbl_address_id;
    }
}