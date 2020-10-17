namespace Project_Car
{
    partial class Form_Client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Client));
            this.lbl_ErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lbl_ErrorFullName = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.asterix_PhoneNumber = new System.Windows.Forms.Label();
            this.asterix_FullName = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_BirthdayMonth = new System.Windows.Forms.ComboBox();
            this.cmb_BirthdayYear = new System.Windows.Forms.ComboBox();
            this.cmb_BirthdayDay = new System.Windows.Forms.ComboBox();
            this.lbl_BirthDay = new System.Windows.Forms.Label();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_ErrorCity = new System.Windows.Forms.Label();
            this.asterix_City = new System.Windows.Forms.Label();
            this.lbl_ErrorBirthDay = new System.Windows.Forms.Label();
            this.asterix_Birthday = new System.Windows.Forms.Label();
            this.lbl_ErrorEmail = new System.Windows.Forms.Label();
            this.asterix_Email = new System.Windows.Forms.Label();
            this.lbl_ErrorGender = new System.Windows.Forms.Label();
            this.asterix_Gender = new System.Windows.Forms.Label();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.lbl_ErrorStreet = new System.Windows.Forms.Label();
            this.asterix_Street = new System.Windows.Forms.Label();
            this.cmb_Street = new System.Windows.Forms.ComboBox();
            this.lbl_ErrorNumber = new System.Windows.Forms.Label();
            this.asterix_Number = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.listbox_Clients = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmb_AreaPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ErrorPhoneNumber
            // 
            this.lbl_ErrorPhoneNumber.AutoSize = true;
            this.lbl_ErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPhoneNumber.Location = new System.Drawing.Point(12, 366);
            this.lbl_ErrorPhoneNumber.Name = "lbl_ErrorPhoneNumber";
            this.lbl_ErrorPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.lbl_ErrorPhoneNumber.TabIndex = 91;
            this.lbl_ErrorPhoneNumber.Text = "Enter Vaild Phone Number";
            this.lbl_ErrorPhoneNumber.Visible = false;
            // 
            // lbl_ErrorFullName
            // 
            this.lbl_ErrorFullName.AutoSize = true;
            this.lbl_ErrorFullName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorFullName.Location = new System.Drawing.Point(418, 215);
            this.lbl_ErrorFullName.Name = "lbl_ErrorFullName";
            this.lbl_ErrorFullName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorFullName.TabIndex = 90;
            this.lbl_ErrorFullName.Text = "Enter Vaild Name";
            this.lbl_ErrorFullName.Visible = false;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_FullName.Location = new System.Drawing.Point(414, 157);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(374, 41);
            this.txt_FullName.TabIndex = 0;
            this.txt_FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // asterix_PhoneNumber
            // 
            this.asterix_PhoneNumber.AutoSize = true;
            this.asterix_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_PhoneNumber.Location = new System.Drawing.Point(357, 303);
            this.asterix_PhoneNumber.Name = "asterix_PhoneNumber";
            this.asterix_PhoneNumber.Size = new System.Drawing.Size(27, 36);
            this.asterix_PhoneNumber.TabIndex = 89;
            this.asterix_PhoneNumber.Text = "*";
            // 
            // asterix_FullName
            // 
            this.asterix_FullName.AutoSize = true;
            this.asterix_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_FullName.Location = new System.Drawing.Point(802, 155);
            this.asterix_FullName.Name = "asterix_FullName";
            this.asterix_FullName.Size = new System.Drawing.Size(27, 36);
            this.asterix_FullName.TabIndex = 88;
            this.asterix_FullName.Text = "*";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(2, 255);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(215, 36);
            this.lbl_PhoneNumber.TabIndex = 87;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_PhoneNumber.Location = new System.Drawing.Point(129, 303);
            this.txt_PhoneNumber.MaxLength = 7;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(212, 41);
            this.txt_PhoneNumber.TabIndex = 2;
            this.txt_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FullName.Location = new System.Drawing.Point(402, 108);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(149, 36);
            this.lbl_FullName.TabIndex = 86;
            this.lbl_FullName.Text = "Full Name";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Female.Location = new System.Drawing.Point(544, 626);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(136, 40);
            this.rdb_Female.TabIndex = 11;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female\r\n";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Male.Location = new System.Drawing.Point(426, 625);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(104, 40);
            this.rdb_Male.TabIndex = 10;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(406, 576);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(114, 36);
            this.lbl_Gender.TabIndex = 94;
            this.lbl_Gender.Text = "Gender";
            // 
            // cmb_BirthdayMonth
            // 
            this.cmb_BirthdayMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_BirthdayMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_BirthdayMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BirthdayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BirthdayMonth.FormattingEnabled = true;
            this.cmb_BirthdayMonth.Items.AddRange(new object[] {
            "Month",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmb_BirthdayMonth.Location = new System.Drawing.Point(524, 300);
            this.cmb_BirthdayMonth.MaxDropDownItems = 10;
            this.cmb_BirthdayMonth.Name = "cmb_BirthdayMonth";
            this.cmb_BirthdayMonth.Size = new System.Drawing.Size(138, 44);
            this.cmb_BirthdayMonth.TabIndex = 5;
            // 
            // cmb_BirthdayYear
            // 
            this.cmb_BirthdayYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_BirthdayYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_BirthdayYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BirthdayYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BirthdayYear.FormattingEnabled = true;
            this.cmb_BirthdayYear.Items.AddRange(new object[] {
            "Year"});
            this.cmb_BirthdayYear.Location = new System.Drawing.Point(668, 300);
            this.cmb_BirthdayYear.MaxDropDownItems = 10;
            this.cmb_BirthdayYear.Name = "cmb_BirthdayYear";
            this.cmb_BirthdayYear.Size = new System.Drawing.Size(120, 44);
            this.cmb_BirthdayYear.TabIndex = 6;
            // 
            // cmb_BirthdayDay
            // 
            this.cmb_BirthdayDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_BirthdayDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_BirthdayDay.DropDownHeight = 200;
            this.cmb_BirthdayDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BirthdayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BirthdayDay.FormattingEnabled = true;
            this.cmb_BirthdayDay.IntegralHeight = false;
            this.cmb_BirthdayDay.ItemHeight = 36;
            this.cmb_BirthdayDay.Items.AddRange(new object[] {
            "Day"});
            this.cmb_BirthdayDay.Location = new System.Drawing.Point(412, 300);
            this.cmb_BirthdayDay.MaxDropDownItems = 10;
            this.cmb_BirthdayDay.Name = "cmb_BirthdayDay";
            this.cmb_BirthdayDay.Size = new System.Drawing.Size(103, 44);
            this.cmb_BirthdayDay.TabIndex = 4;
            this.cmb_BirthdayDay.Tag = "";
            // 
            // lbl_BirthDay
            // 
            this.lbl_BirthDay.AutoSize = true;
            this.lbl_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BirthDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_BirthDay.Location = new System.Drawing.Point(402, 255);
            this.lbl_BirthDay.Name = "lbl_BirthDay";
            this.lbl_BirthDay.Size = new System.Drawing.Size(125, 36);
            this.lbl_BirthDay.TabIndex = 98;
            this.lbl_BirthDay.Text = "Birthday";
            // 
            // cmb_City
            // 
            this.cmb_City.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_City.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "ʿAfula",
            "ʿAkko",
            "ʿArad",
            "Ashdod",
            "Ashqelon",
            "Bat Yam",
            "Beersheba",
            "Bet Sheʾan",
            "Bet Sheʿarim",
            "Bnei Brak",
            "Caesarea",
            "Dimona",
            "Dor",
            "Elat",
            "ʿEn Gedi",
            "Givʿatayim",
            "H̱adera",
            "Haifa",
            "Herzliyya",
            "H̱olon",
            "Jerusalem",
            "Karmiʾel",
            "Kefar Sava",
            "Lod",
            "Meron",
            "Nahariyya",
            "Nazareth",
            "Netanya",
            "Petaẖ Tiqwa",
            "Qiryat Shemona",
            "Ramat Gan",
            "Ramla",
            "Reẖovot",
            "Rishon LeẔiyyon",
            "Sedom",
            "Tel Aviv–Yafo",
            "Tiberias",
            "Ẕefat"});
            this.cmb_City.Location = new System.Drawing.Point(16, 457);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(336, 44);
            this.cmb_City.TabIndex = 7;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(2, 414);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(66, 36);
            this.lbl_City.TabIndex = 107;
            this.lbl_City.Text = "City";
            this.toolTip1.SetToolTip(this.lbl_City, "Click to add a new city");
            this.lbl_City.Click += new System.EventHandler(this.lbl_City_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(10, 729);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(100, 36);
            this.lbl_Email.TabIndex = 108;
            this.lbl_Email.Text = "E-Mail";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Email.Location = new System.Drawing.Point(16, 768);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(772, 41);
            this.txt_Email.TabIndex = 13;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(373, 881);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(509, 955);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 112;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(544, 881);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(231, 57);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save Client";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(299, 4);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(184, 69);
            this.lbl_HeadLine.TabIndex = 113;
            this.lbl_HeadLine.Text = "Client";
            // 
            // lbl_ErrorCity
            // 
            this.lbl_ErrorCity.AutoSize = true;
            this.lbl_ErrorCity.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorCity.Location = new System.Drawing.Point(20, 522);
            this.lbl_ErrorCity.Name = "lbl_ErrorCity";
            this.lbl_ErrorCity.Size = new System.Drawing.Size(117, 20);
            this.lbl_ErrorCity.TabIndex = 125;
            this.lbl_ErrorCity.Text = "Enter Vaild City";
            this.lbl_ErrorCity.Visible = false;
            // 
            // asterix_City
            // 
            this.asterix_City.AutoSize = true;
            this.asterix_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_City.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_City.Location = new System.Drawing.Point(358, 460);
            this.asterix_City.Name = "asterix_City";
            this.asterix_City.Size = new System.Drawing.Size(27, 36);
            this.asterix_City.TabIndex = 124;
            this.asterix_City.Text = "*";
            // 
            // lbl_ErrorBirthDay
            // 
            this.lbl_ErrorBirthDay.AutoSize = true;
            this.lbl_ErrorBirthDay.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorBirthDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorBirthDay.Location = new System.Drawing.Point(418, 366);
            this.lbl_ErrorBirthDay.Name = "lbl_ErrorBirthDay";
            this.lbl_ErrorBirthDay.Size = new System.Drawing.Size(110, 20);
            this.lbl_ErrorBirthDay.TabIndex = 117;
            this.lbl_ErrorBirthDay.Text = "Enter Birthday";
            this.lbl_ErrorBirthDay.Visible = false;
            // 
            // asterix_Birthday
            // 
            this.asterix_Birthday.AutoSize = true;
            this.asterix_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Birthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Birthday.Location = new System.Drawing.Point(802, 308);
            this.asterix_Birthday.Name = "asterix_Birthday";
            this.asterix_Birthday.Size = new System.Drawing.Size(27, 36);
            this.asterix_Birthday.TabIndex = 116;
            this.asterix_Birthday.Text = "*";
            // 
            // lbl_ErrorEmail
            // 
            this.lbl_ErrorEmail.AutoSize = true;
            this.lbl_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorEmail.Location = new System.Drawing.Point(20, 825);
            this.lbl_ErrorEmail.Name = "lbl_ErrorEmail";
            this.lbl_ErrorEmail.Size = new System.Drawing.Size(96, 20);
            this.lbl_ErrorEmail.TabIndex = 119;
            this.lbl_ErrorEmail.Text = "Enter E-Mail";
            this.lbl_ErrorEmail.Visible = false;
            // 
            // asterix_Email
            // 
            this.asterix_Email.AutoSize = true;
            this.asterix_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Email.Location = new System.Drawing.Point(802, 768);
            this.asterix_Email.Name = "asterix_Email";
            this.asterix_Email.Size = new System.Drawing.Size(27, 36);
            this.asterix_Email.TabIndex = 118;
            this.asterix_Email.Text = "*";
            // 
            // lbl_ErrorGender
            // 
            this.lbl_ErrorGender.AutoSize = true;
            this.lbl_ErrorGender.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorGender.Location = new System.Drawing.Point(418, 682);
            this.lbl_ErrorGender.Name = "lbl_ErrorGender";
            this.lbl_ErrorGender.Size = new System.Drawing.Size(106, 20);
            this.lbl_ErrorGender.TabIndex = 121;
            this.lbl_ErrorGender.Text = "Enter Gender";
            this.lbl_ErrorGender.Visible = false;
            // 
            // asterix_Gender
            // 
            this.asterix_Gender.AutoSize = true;
            this.asterix_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Gender.Location = new System.Drawing.Point(802, 625);
            this.asterix_Gender.Name = "asterix_Gender";
            this.asterix_Gender.Size = new System.Drawing.Size(27, 36);
            this.asterix_Gender.TabIndex = 120;
            this.asterix_Gender.Text = "*";
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Street.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Street.Location = new System.Drawing.Point(402, 414);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(93, 36);
            this.lbl_Street.TabIndex = 123;
            this.lbl_Street.Text = "Street";
            this.toolTip1.SetToolTip(this.lbl_Street, "Click to add a new street");
            this.lbl_Street.Click += new System.EventHandler(this.lbl_Street_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(1, 157);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 128;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(87, 155);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 129;
            this.lbl_Idtxt.Text = "0";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(789, 881);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(204, 57);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete Client";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(855, 72);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(496, 57);
            this.btn_Filter.TabIndex = 131;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // lbl_ErrorStreet
            // 
            this.lbl_ErrorStreet.AutoSize = true;
            this.lbl_ErrorStreet.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorStreet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorStreet.Location = new System.Drawing.Point(418, 522);
            this.lbl_ErrorStreet.Name = "lbl_ErrorStreet";
            this.lbl_ErrorStreet.Size = new System.Drawing.Size(135, 20);
            this.lbl_ErrorStreet.TabIndex = 133;
            this.lbl_ErrorStreet.Text = "Enter Vaild Street";
            this.lbl_ErrorStreet.Visible = false;
            // 
            // asterix_Street
            // 
            this.asterix_Street.AutoSize = true;
            this.asterix_Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Street.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Street.Location = new System.Drawing.Point(802, 465);
            this.asterix_Street.Name = "asterix_Street";
            this.asterix_Street.Size = new System.Drawing.Size(27, 36);
            this.asterix_Street.TabIndex = 134;
            this.asterix_Street.Text = "*";
            // 
            // cmb_Street
            // 
            this.cmb_Street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Street.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Street.FormattingEnabled = true;
            this.cmb_Street.Items.AddRange(new object[] {
            "ʿAfula",
            "ʿAkko",
            "ʿArad",
            "Ashdod",
            "Ashqelon",
            "Bat Yam",
            "Beersheba",
            "Bet Sheʾan",
            "Bet Sheʿarim",
            "Bnei Brak",
            "Caesarea",
            "Dimona",
            "Dor",
            "Elat",
            "ʿEn Gedi",
            "Givʿatayim",
            "H̱adera",
            "Haifa",
            "Herzliyya",
            "H̱olon",
            "Jerusalem",
            "Karmiʾel",
            "Kefar Sava",
            "Lod",
            "Meron",
            "Nahariyya",
            "Nazareth",
            "Netanya",
            "Petaẖ Tiqwa",
            "Qiryat Shemona",
            "Ramat Gan",
            "Ramla",
            "Reẖovot",
            "Rishon LeẔiyyon",
            "Sedom",
            "Tel Aviv–Yafo",
            "Tiberias",
            "Ẕefat"});
            this.cmb_Street.Location = new System.Drawing.Point(414, 457);
            this.cmb_Street.Name = "cmb_Street";
            this.cmb_Street.Size = new System.Drawing.Size(374, 44);
            this.cmb_Street.TabIndex = 8;
            // 
            // lbl_ErrorNumber
            // 
            this.lbl_ErrorNumber.AutoSize = true;
            this.lbl_ErrorNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorNumber.Location = new System.Drawing.Point(20, 684);
            this.lbl_ErrorNumber.Name = "lbl_ErrorNumber";
            this.lbl_ErrorNumber.Size = new System.Drawing.Size(108, 20);
            this.lbl_ErrorNumber.TabIndex = 191;
            this.lbl_ErrorNumber.Text = "Enter Number";
            this.lbl_ErrorNumber.Visible = false;
            // 
            // asterix_Number
            // 
            this.asterix_Number.AutoSize = true;
            this.asterix_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Number.Location = new System.Drawing.Point(358, 624);
            this.asterix_Number.Name = "asterix_Number";
            this.asterix_Number.Size = new System.Drawing.Size(27, 36);
            this.asterix_Number.TabIndex = 190;
            this.asterix_Number.Text = "*";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Number.Location = new System.Drawing.Point(10, 576);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(120, 36);
            this.lbl_Number.TabIndex = 189;
            this.lbl_Number.Text = "Number";
            // 
            // txt_Number
            // 
            this.txt_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Number.Location = new System.Drawing.Point(16, 624);
            this.txt_Number.MaxLength = 5;
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(212, 41);
            this.txt_Number.TabIndex = 9;
            this.txt_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // listbox_Clients
            // 
            this.listbox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Clients.FormattingEnabled = true;
            this.listbox_Clients.ItemHeight = 36;
            this.listbox_Clients.Location = new System.Drawing.Point(855, 135);
            this.listbox_Clients.Name = "listbox_Clients";
            this.listbox_Clients.Size = new System.Drawing.Size(496, 652);
            this.listbox_Clients.TabIndex = 192;
            this.listbox_Clients.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // cmb_AreaPhoneNumber
            // 
            this.cmb_AreaPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_AreaPhoneNumber.Location = new System.Drawing.Point(16, 303);
            this.cmb_AreaPhoneNumber.MaxLength = 3;
            this.cmb_AreaPhoneNumber.Name = "cmb_AreaPhoneNumber";
            this.cmb_AreaPhoneNumber.Size = new System.Drawing.Size(87, 41);
            this.cmb_AreaPhoneNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 36);
            this.label1.TabIndex = 194;
            this.label1.Text = "-";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 1006);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_AreaPhoneNumber);
            this.Controls.Add(this.listbox_Clients);
            this.Controls.Add(this.lbl_ErrorNumber);
            this.Controls.Add(this.asterix_Number);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.cmb_Street);
            this.Controls.Add(this.asterix_Street);
            this.Controls.Add(this.lbl_ErrorStreet);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Street);
            this.Controls.Add(this.lbl_ErrorGender);
            this.Controls.Add(this.asterix_Gender);
            this.Controls.Add(this.lbl_ErrorEmail);
            this.Controls.Add(this.asterix_Email);
            this.Controls.Add(this.lbl_ErrorBirthDay);
            this.Controls.Add(this.asterix_Birthday);
            this.Controls.Add(this.lbl_ErrorCity);
            this.Controls.Add(this.asterix_City);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.cmb_BirthdayMonth);
            this.Controls.Add(this.cmb_BirthdayYear);
            this.Controls.Add(this.cmb_BirthdayDay);
            this.Controls.Add(this.lbl_BirthDay);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_ErrorPhoneNumber);
            this.Controls.Add(this.lbl_ErrorFullName);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.asterix_PhoneNumber);
            this.Controls.Add(this.asterix_FullName);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.lbl_FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ErrorPhoneNumber;
        private System.Windows.Forms.Label lbl_ErrorFullName;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label asterix_PhoneNumber;
        private System.Windows.Forms.Label asterix_FullName;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.ComboBox cmb_BirthdayMonth;
        private System.Windows.Forms.ComboBox cmb_BirthdayYear;
        private System.Windows.Forms.ComboBox cmb_BirthdayDay;
        private System.Windows.Forms.Label lbl_BirthDay;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_ErrorCity;
        private System.Windows.Forms.Label asterix_City;
        private System.Windows.Forms.Label lbl_ErrorBirthDay;
        private System.Windows.Forms.Label asterix_Birthday;
        private System.Windows.Forms.Label lbl_ErrorEmail;
        private System.Windows.Forms.Label asterix_Email;
        private System.Windows.Forms.Label lbl_ErrorGender;
        private System.Windows.Forms.Label asterix_Gender;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label lbl_ErrorStreet;
        private System.Windows.Forms.Label asterix_Street;
        private System.Windows.Forms.ComboBox cmb_Street;
        private System.Windows.Forms.Label lbl_ErrorNumber;
        private System.Windows.Forms.Label asterix_Number;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.ListBox listbox_Clients;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox cmb_AreaPhoneNumber;
        private System.Windows.Forms.Label label1;
    }
}

