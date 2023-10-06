namespace PersonDatabaseApp
{
    partial class UserAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _txtb_name = new TextBox();
            _txtb_surname = new TextBox();
            _date_birthday = new DateTimePicker();
            _cmb_sex = new ComboBox();
            _btn_submit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            _txtb_street = new TextBox();
            _txtb_city = new TextBox();
            label7 = new Label();
            _txtb_country = new TextBox();
            label8 = new Label();
            _txtb_zip = new TextBox();
            SuspendLayout();
            // 
            // _txtb_name
            // 
            _txtb_name.Location = new Point(12, 150);
            _txtb_name.Name = "_txtb_name";
            _txtb_name.Size = new Size(290, 43);
            _txtb_name.TabIndex = 0;
            // 
            // _txtb_surname
            // 
            _txtb_surname.Location = new Point(308, 150);
            _txtb_surname.Name = "_txtb_surname";
            _txtb_surname.Size = new Size(277, 43);
            _txtb_surname.TabIndex = 1;
            // 
            // _date_birthday
            // 
            _date_birthday.Location = new Point(617, 150);
            _date_birthday.Name = "_date_birthday";
            _date_birthday.Size = new Size(450, 43);
            _date_birthday.TabIndex = 4;
            // 
            // _cmb_sex
            // 
            _cmb_sex.FormattingEnabled = true;
            _cmb_sex.Location = new Point(1073, 148);
            _cmb_sex.Name = "_cmb_sex";
            _cmb_sex.Size = new Size(272, 45);
            _cmb_sex.TabIndex = 5;
            // 
            // _btn_submit
            // 
            _btn_submit.Location = new Point(1465, 148);
            _btn_submit.Name = "_btn_submit";
            _btn_submit.Size = new Size(169, 193);
            _btn_submit.TabIndex = 6;
            _btn_submit.Text = "submit";
            _btn_submit.UseVisualStyleBackColor = true;
            _btn_submit.Click += _btn_submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1104, 72);
            label1.Name = "label1";
            label1.Size = new Size(57, 37);
            label1.TabIndex = 7;
            label1.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 83);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 72);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 9;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(791, 72);
            label4.Name = "label4";
            label4.Size = new Size(115, 37);
            label4.TabIndex = 10;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 220);
            label5.Name = "label5";
            label5.Size = new Size(85, 37);
            label5.TabIndex = 14;
            label5.Text = "Street";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 231);
            label6.Name = "label6";
            label6.Size = new Size(63, 37);
            label6.TabIndex = 13;
            label6.Text = "City";
            // 
            // _txtb_street
            // 
            _txtb_street.Location = new Point(308, 298);
            _txtb_street.Name = "_txtb_street";
            _txtb_street.Size = new Size(461, 43);
            _txtb_street.TabIndex = 12;
            // 
            // _txtb_city
            // 
            _txtb_city.Location = new Point(12, 298);
            _txtb_city.Name = "_txtb_city";
            _txtb_city.Size = new Size(290, 43);
            _txtb_city.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(868, 220);
            label7.Name = "label7";
            label7.Size = new Size(111, 37);
            label7.TabIndex = 16;
            label7.Text = "Country";
            // 
            // _txtb_country
            // 
            _txtb_country.Location = new Point(775, 298);
            _txtb_country.Name = "_txtb_country";
            _txtb_country.Size = new Size(277, 43);
            _txtb_country.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1161, 220);
            label8.Name = "label8";
            label8.Size = new Size(55, 37);
            label8.TabIndex = 18;
            label8.Text = "Zip";
            // 
            // _txtb_zip
            // 
            _txtb_zip.Location = new Point(1068, 298);
            _txtb_zip.Name = "_txtb_zip";
            _txtb_zip.Size = new Size(277, 43);
            _txtb_zip.TabIndex = 17;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 412);
            Controls.Add(label8);
            Controls.Add(_txtb_zip);
            Controls.Add(label7);
            Controls.Add(_txtb_country);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(_txtb_street);
            Controls.Add(_txtb_city);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_btn_submit);
            Controls.Add(_cmb_sex);
            Controls.Add(_date_birthday);
            Controls.Add(_txtb_surname);
            Controls.Add(_txtb_name);
            Name = "UserAdd";
            Text = "UserAdd";
            Load += UserAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _txtb_name;
        private TextBox _txtb_surname;
        private DateTimePicker _date_birthday;
        private ComboBox _cmb_sex;
        private Button _btn_submit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox _txtb_street;
        private TextBox _txtb_city;
        private Label label7;
        private TextBox _txtb_country;
        private Label label8;
        private TextBox _txtb_zip;
    }
}