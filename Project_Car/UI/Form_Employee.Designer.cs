namespace Project_Car.UI
{
    partial class Form_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee));
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.asterix_Role = new System.Windows.Forms.Label();
            this.lbl_ErrorRole = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.cmb_PhoneNumber = new System.Windows.Forms.ComboBox();
            this.lbl_ErrorGender = new System.Windows.Forms.Label();
            this.lbl_ErrorEmail = new System.Windows.Forms.Label();
            this.asterix_Email = new System.Windows.Forms.Label();
            this.lbl_ErrorBirthDay = new System.Windows.Forms.Label();
            this.asterix_Birthday = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.cmb_BirthdayMonth = new System.Windows.Forms.ComboBox();
            this.cmb_BirthdayYear = new System.Windows.Forms.ComboBox();
            this.cmb_BirthdayDay = new System.Windows.Forms.ComboBox();
            this.lbl_BirthDay = new System.Windows.Forms.Label();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_ErrorPhoneNumber = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.asterix_PhoneNumber = new System.Windows.Forms.Label();
            this.asterix_FullName = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_ErrorFullName = new System.Windows.Forms.Label();
            this.lbl_ErrorSalary = new System.Windows.Forms.Label();
            this.asterix_Salary = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_ErrorUsername = new System.Windows.Forms.Label();
            this.asterix_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.asterix_Gender = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.Label();
            this.listbox_Employees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_Role
            // 
            this.cmb_Role.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Items.AddRange(new object[] {
            "Manager"});
            this.cmb_Role.Location = new System.Drawing.Point(11, 651);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(329, 44);
            this.cmb_Role.TabIndex = 9;
            // 
            // asterix_Role
            // 
            this.asterix_Role.AutoSize = true;
            this.asterix_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Role.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Role.Location = new System.Drawing.Point(346, 659);
            this.asterix_Role.Name = "asterix_Role";
            this.asterix_Role.Size = new System.Drawing.Size(27, 36);
            this.asterix_Role.TabIndex = 169;
            this.asterix_Role.Text = "*";
            // 
            // lbl_ErrorRole
            // 
            this.lbl_ErrorRole.AutoSize = true;
            this.lbl_ErrorRole.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorRole.Location = new System.Drawing.Point(13, 716);
            this.lbl_ErrorRole.Name = "lbl_ErrorRole";
            this.lbl_ErrorRole.Size = new System.Drawing.Size(85, 20);
            this.lbl_ErrorRole.TabIndex = 168;
            this.lbl_ErrorRole.Text = "Enter Role";
            this.lbl_ErrorRole.Visible = false;
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(838, 69);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(565, 64);
            this.btn_Filter.TabIndex = 166;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(625, 933);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(261, 57);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete Employee";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(96, 186);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 164;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(11, 186);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 163;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Role.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Role.Location = new System.Drawing.Point(12, 597);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(77, 36);
            this.lbl_Role.TabIndex = 162;
            this.lbl_Role.Text = "Role";
            // 
            // cmb_PhoneNumber
            // 
            this.cmb_PhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_PhoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PhoneNumber.FormattingEnabled = true;
            this.cmb_PhoneNumber.Items.AddRange(new object[] {
            "050",
            "052",
            "053",
            "054",
            "055",
            "058"});
            this.cmb_PhoneNumber.Location = new System.Drawing.Point(18, 334);
            this.cmb_PhoneNumber.Name = "cmb_PhoneNumber";
            this.cmb_PhoneNumber.Size = new System.Drawing.Size(104, 44);
            this.cmb_PhoneNumber.TabIndex = 1;
            // 
            // lbl_ErrorGender
            // 
            this.lbl_ErrorGender.AutoSize = true;
            this.lbl_ErrorGender.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorGender.Location = new System.Drawing.Point(14, 553);
            this.lbl_ErrorGender.Name = "lbl_ErrorGender";
            this.lbl_ErrorGender.Size = new System.Drawing.Size(106, 20);
            this.lbl_ErrorGender.TabIndex = 161;
            this.lbl_ErrorGender.Text = "Enter Gender";
            this.lbl_ErrorGender.Visible = false;
            // 
            // lbl_ErrorEmail
            // 
            this.lbl_ErrorEmail.AutoSize = true;
            this.lbl_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorEmail.Location = new System.Drawing.Point(411, 553);
            this.lbl_ErrorEmail.Name = "lbl_ErrorEmail";
            this.lbl_ErrorEmail.Size = new System.Drawing.Size(96, 20);
            this.lbl_ErrorEmail.TabIndex = 160;
            this.lbl_ErrorEmail.Text = "Enter E-Mail";
            this.lbl_ErrorEmail.Visible = false;
            // 
            // asterix_Email
            // 
            this.asterix_Email.AutoSize = true;
            this.asterix_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Email.Location = new System.Drawing.Point(773, 484);
            this.asterix_Email.Name = "asterix_Email";
            this.asterix_Email.Size = new System.Drawing.Size(27, 36);
            this.asterix_Email.TabIndex = 159;
            this.asterix_Email.Text = "*";
            // 
            // lbl_ErrorBirthDay
            // 
            this.lbl_ErrorBirthDay.AutoSize = true;
            this.lbl_ErrorBirthDay.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorBirthDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorBirthDay.Location = new System.Drawing.Point(411, 397);
            this.lbl_ErrorBirthDay.Name = "lbl_ErrorBirthDay";
            this.lbl_ErrorBirthDay.Size = new System.Drawing.Size(110, 20);
            this.lbl_ErrorBirthDay.TabIndex = 158;
            this.lbl_ErrorBirthDay.Text = "Enter Birthday";
            this.lbl_ErrorBirthDay.Visible = false;
            // 
            // asterix_Birthday
            // 
            this.asterix_Birthday.AutoSize = true;
            this.asterix_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Birthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Birthday.Location = new System.Drawing.Point(805, 339);
            this.asterix_Birthday.Name = "asterix_Birthday";
            this.asterix_Birthday.Size = new System.Drawing.Size(27, 36);
            this.asterix_Birthday.TabIndex = 157;
            this.asterix_Birthday.Text = "*";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(269, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(296, 69);
            this.lbl_HeadLine.TabIndex = 156;
            this.lbl_HeadLine.Text = "Employee";
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(116, 933);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(347, 1007);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 155;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(296, 933);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(306, 57);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save Employee";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Email.Location = new System.Drawing.Point(415, 484);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(349, 41);
            this.txt_Email.TabIndex = 8;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(405, 445);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(100, 36);
            this.lbl_Email.TabIndex = 154;
            this.lbl_Email.Text = "E-Mail";
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
            this.cmb_BirthdayMonth.Location = new System.Drawing.Point(527, 331);
            this.cmb_BirthdayMonth.MaxDropDownItems = 10;
            this.cmb_BirthdayMonth.Name = "cmb_BirthdayMonth";
            this.cmb_BirthdayMonth.Size = new System.Drawing.Size(138, 44);
            this.cmb_BirthdayMonth.TabIndex = 4;
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
            this.cmb_BirthdayYear.Location = new System.Drawing.Point(671, 331);
            this.cmb_BirthdayYear.MaxDropDownItems = 10;
            this.cmb_BirthdayYear.Name = "cmb_BirthdayYear";
            this.cmb_BirthdayYear.Size = new System.Drawing.Size(120, 44);
            this.cmb_BirthdayYear.TabIndex = 5;
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
            this.cmb_BirthdayDay.Location = new System.Drawing.Point(415, 331);
            this.cmb_BirthdayDay.MaxDropDownItems = 10;
            this.cmb_BirthdayDay.Name = "cmb_BirthdayDay";
            this.cmb_BirthdayDay.Size = new System.Drawing.Size(103, 44);
            this.cmb_BirthdayDay.TabIndex = 3;
            this.cmb_BirthdayDay.Tag = "";
            // 
            // lbl_BirthDay
            // 
            this.lbl_BirthDay.AutoSize = true;
            this.lbl_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BirthDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_BirthDay.Location = new System.Drawing.Point(405, 286);
            this.lbl_BirthDay.Name = "lbl_BirthDay";
            this.lbl_BirthDay.Size = new System.Drawing.Size(125, 36);
            this.lbl_BirthDay.TabIndex = 153;
            this.lbl_BirthDay.Text = "Birthday";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Female.Location = new System.Drawing.Point(169, 496);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(136, 40);
            this.rdb_Female.TabIndex = 7;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female\r\n";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Male.Location = new System.Drawing.Point(27, 496);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(104, 40);
            this.rdb_Male.TabIndex = 6;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(12, 445);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(114, 36);
            this.lbl_Gender.TabIndex = 152;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_ErrorPhoneNumber
            // 
            this.lbl_ErrorPhoneNumber.AutoSize = true;
            this.lbl_ErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPhoneNumber.Location = new System.Drawing.Point(14, 397);
            this.lbl_ErrorPhoneNumber.Name = "lbl_ErrorPhoneNumber";
            this.lbl_ErrorPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.lbl_ErrorPhoneNumber.TabIndex = 151;
            this.lbl_ErrorPhoneNumber.Text = "Enter Vaild Phone Number";
            this.lbl_ErrorPhoneNumber.Visible = false;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_FullName.Location = new System.Drawing.Point(411, 188);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(326, 41);
            this.txt_FullName.TabIndex = 0;
            this.txt_FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // asterix_PhoneNumber
            // 
            this.asterix_PhoneNumber.AutoSize = true;
            this.asterix_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_PhoneNumber.Location = new System.Drawing.Point(346, 336);
            this.asterix_PhoneNumber.Name = "asterix_PhoneNumber";
            this.asterix_PhoneNumber.Size = new System.Drawing.Size(27, 36);
            this.asterix_PhoneNumber.TabIndex = 150;
            this.asterix_PhoneNumber.Text = "*";
            // 
            // asterix_FullName
            // 
            this.asterix_FullName.AutoSize = true;
            this.asterix_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_FullName.Location = new System.Drawing.Point(773, 188);
            this.asterix_FullName.Name = "asterix_FullName";
            this.asterix_FullName.Size = new System.Drawing.Size(27, 36);
            this.asterix_FullName.TabIndex = 149;
            this.asterix_FullName.Text = "*";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(11, 286);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(215, 36);
            this.lbl_PhoneNumber.TabIndex = 148;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_PhoneNumber.Location = new System.Drawing.Point(128, 336);
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
            this.lbl_FullName.Location = new System.Drawing.Point(405, 139);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(149, 36);
            this.lbl_FullName.TabIndex = 147;
            this.lbl_FullName.Text = "Full Name";
            // 
            // lbl_ErrorFullName
            // 
            this.lbl_ErrorFullName.AutoSize = true;
            this.lbl_ErrorFullName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorFullName.Location = new System.Drawing.Point(407, 246);
            this.lbl_ErrorFullName.Name = "lbl_ErrorFullName";
            this.lbl_ErrorFullName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorFullName.TabIndex = 171;
            this.lbl_ErrorFullName.Text = "Enter Vaild Name";
            this.lbl_ErrorFullName.Visible = false;
            // 
            // lbl_ErrorSalary
            // 
            this.lbl_ErrorSalary.AutoSize = true;
            this.lbl_ErrorSalary.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorSalary.Location = new System.Drawing.Point(411, 716);
            this.lbl_ErrorSalary.Name = "lbl_ErrorSalary";
            this.lbl_ErrorSalary.Size = new System.Drawing.Size(96, 20);
            this.lbl_ErrorSalary.TabIndex = 175;
            this.lbl_ErrorSalary.Text = "Enter Salary";
            this.lbl_ErrorSalary.Visible = false;
            // 
            // asterix_Salary
            // 
            this.asterix_Salary.AutoSize = true;
            this.asterix_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Salary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Salary.Location = new System.Drawing.Point(773, 654);
            this.asterix_Salary.Name = "asterix_Salary";
            this.asterix_Salary.Size = new System.Drawing.Size(27, 36);
            this.asterix_Salary.TabIndex = 174;
            this.asterix_Salary.Text = "*";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Salary.Location = new System.Drawing.Point(411, 654);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(349, 41);
            this.txt_Salary.TabIndex = 10;
            this.txt_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(406, 597);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(99, 36);
            this.lbl_Salary.TabIndex = 173;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_ErrorUsername
            // 
            this.lbl_ErrorUsername.AutoSize = true;
            this.lbl_ErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorUsername.Location = new System.Drawing.Point(13, 862);
            this.lbl_ErrorUsername.Name = "lbl_ErrorUsername";
            this.lbl_ErrorUsername.Size = new System.Drawing.Size(126, 20);
            this.lbl_ErrorUsername.TabIndex = 179;
            this.lbl_ErrorUsername.Text = "Enter Username";
            this.lbl_ErrorUsername.Visible = false;
            // 
            // asterix_Username
            // 
            this.asterix_Username.AutoSize = true;
            this.asterix_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Username.Location = new System.Drawing.Point(346, 806);
            this.asterix_Username.Name = "asterix_Username";
            this.asterix_Username.Size = new System.Drawing.Size(27, 36);
            this.asterix_Username.TabIndex = 178;
            this.asterix_Username.Text = "*";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Username.Location = new System.Drawing.Point(17, 806);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(323, 41);
            this.txt_Username.TabIndex = 11;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(7, 761);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(150, 36);
            this.lbl_Username.TabIndex = 177;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(405, 761);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(147, 36);
            this.lbl_Password.TabIndex = 181;
            this.lbl_Password.Text = "Password";
            // 
            // asterix_Gender
            // 
            this.asterix_Gender.AutoSize = true;
            this.asterix_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Gender.Location = new System.Drawing.Point(347, 444);
            this.asterix_Gender.Name = "asterix_Gender";
            this.asterix_Gender.Size = new System.Drawing.Size(27, 36);
            this.asterix_Gender.TabIndex = 184;
            this.asterix_Gender.Text = "*";
            // 
            // txt_Password
            // 
            this.txt_Password.AutoSize = true;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(405, 811);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(147, 36);
            this.txt_Password.TabIndex = 185;
            this.txt_Password.Text = "Password";
            // 
            // listbox_Employees
            // 
            this.listbox_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Employees.FormattingEnabled = true;
            this.listbox_Employees.ItemHeight = 36;
            this.listbox_Employees.Location = new System.Drawing.Point(838, 148);
            this.listbox_Employees.Name = "listbox_Employees";
            this.listbox_Employees.Size = new System.Drawing.Size(562, 688);
            this.listbox_Employees.TabIndex = 187;
            this.listbox_Employees.DoubleClick += new System.EventHandler(this.listBox_Employee_DoubleClick);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1412, 1050);
            this.Controls.Add(this.listbox_Employees);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.asterix_Gender);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_ErrorUsername);
            this.Controls.Add(this.asterix_Username);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_ErrorSalary);
            this.Controls.Add(this.asterix_Salary);
            this.Controls.Add(this.txt_Salary);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_ErrorFullName);
            this.Controls.Add(this.cmb_Role);
            this.Controls.Add(this.asterix_Role);
            this.Controls.Add(this.lbl_ErrorRole);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.cmb_PhoneNumber);
            this.Controls.Add(this.lbl_ErrorGender);
            this.Controls.Add(this.lbl_ErrorEmail);
            this.Controls.Add(this.asterix_Email);
            this.Controls.Add(this.lbl_ErrorBirthDay);
            this.Controls.Add(this.asterix_Birthday);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.cmb_BirthdayMonth);
            this.Controls.Add(this.cmb_BirthdayYear);
            this.Controls.Add(this.cmb_BirthdayDay);
            this.Controls.Add(this.lbl_BirthDay);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_ErrorPhoneNumber);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.asterix_PhoneNumber);
            this.Controls.Add(this.asterix_FullName);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.lbl_FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.Label asterix_Role;
        private System.Windows.Forms.Label lbl_ErrorRole;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ComboBox cmb_PhoneNumber;
        private System.Windows.Forms.Label lbl_ErrorGender;
        private System.Windows.Forms.Label lbl_ErrorEmail;
        private System.Windows.Forms.Label asterix_Email;
        private System.Windows.Forms.Label lbl_ErrorBirthDay;
        private System.Windows.Forms.Label asterix_Birthday;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.ComboBox cmb_BirthdayMonth;
        private System.Windows.Forms.ComboBox cmb_BirthdayYear;
        private System.Windows.Forms.ComboBox cmb_BirthdayDay;
        private System.Windows.Forms.Label lbl_BirthDay;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_ErrorPhoneNumber;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label asterix_PhoneNumber;
        private System.Windows.Forms.Label asterix_FullName;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_ErrorFullName;
        private System.Windows.Forms.Label lbl_ErrorSalary;
        private System.Windows.Forms.Label asterix_Salary;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_ErrorUsername;
        private System.Windows.Forms.Label asterix_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label asterix_Gender;
        private System.Windows.Forms.Label txt_Password;
        private System.Windows.Forms.ListBox listbox_Employees;
    }
}