namespace Project_Car.UI
{
    partial class Form_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Product));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.asterix_Model = new System.Windows.Forms.Label();
            this.lbl_ErrorModel = new System.Windows.Forms.Label();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.asterix_Price = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.rdb_Rent = new System.Windows.Forms.RadioButton();
            this.rdb_Buy = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_ErrorPrice = new System.Windows.Forms.Label();
            this.txt_LicenseNumber = new System.Windows.Forms.TextBox();
            this.lbl_LicenseNumber = new System.Windows.Forms.Label();
            this.lbl_ErrorLicense = new System.Windows.Forms.Label();
            this.asterix_License = new System.Windows.Forms.Label();
            this.asterix_Status = new System.Windows.Forms.Label();
            this.lbl_ErrorStatus = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.listbox_Cars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(381, 755);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(180, 57);
            this.btn_Delete.TabIndex = 200;
            this.btn_Delete.Text = "Delete Car";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(792, 755);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 198;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(574, 755);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(199, 57);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save Car";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(568, 836);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 196;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(342, 0);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(126, 69);
            this.lbl_HeadLine.TabIndex = 195;
            this.lbl_HeadLine.Text = "Car";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(106, 160);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 194;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(3, 160);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 193;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Model.Location = new System.Drawing.Point(507, 248);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(97, 36);
            this.lbl_Model.TabIndex = 190;
            this.lbl_Model.Text = "Model";
            this.lbl_Model.Click += new System.EventHandler(this.lbl_Model_Click);
            // 
            // cmb_Category
            // 
            this.cmb_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
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
            this.cmb_Category.Location = new System.Drawing.Point(12, 297);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(374, 44);
            this.cmb_Category.TabIndex = 1;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Category.Location = new System.Drawing.Point(3, 248);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(135, 36);
            this.Category.TabIndex = 207;
            this.Category.Text = "Category";
            // 
            // asterix_Model
            // 
            this.asterix_Model.AutoSize = true;
            this.asterix_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Model.Location = new System.Drawing.Point(893, 297);
            this.asterix_Model.Name = "asterix_Model";
            this.asterix_Model.Size = new System.Drawing.Size(27, 36);
            this.asterix_Model.TabIndex = 206;
            this.asterix_Model.Text = "*";
            // 
            // lbl_ErrorModel
            // 
            this.lbl_ErrorModel.AutoSize = true;
            this.lbl_ErrorModel.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorModel.Location = new System.Drawing.Point(509, 357);
            this.lbl_ErrorModel.Name = "lbl_ErrorModel";
            this.lbl_ErrorModel.Size = new System.Drawing.Size(134, 20);
            this.lbl_ErrorModel.TabIndex = 205;
            this.lbl_ErrorModel.Text = "Enter Vaild Model";
            this.lbl_ErrorModel.Visible = false;
            // 
            // cmb_Company
            // 
            this.cmb_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Items.AddRange(new object[] {
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
            this.cmb_Company.Location = new System.Drawing.Point(513, 157);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(374, 44);
            this.cmb_Company.TabIndex = 0;
            this.cmb_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_SelectedIndexChanged);
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(507, 109);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(141, 36);
            this.lbl_Company.TabIndex = 204;
            this.lbl_Company.Text = "Company";
            // 
            // cmb_Model
            // 
            this.cmb_Model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Model.FormattingEnabled = true;
            this.cmb_Model.Items.AddRange(new object[] {
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
            this.cmb_Model.Location = new System.Drawing.Point(513, 297);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(374, 44);
            this.cmb_Model.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Price.Location = new System.Drawing.Point(513, 478);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(374, 41);
            this.txt_Price.TabIndex = 5;
            this.txt_Price.Tag = "5";
            this.txt_Price.Visible = false;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // asterix_Price
            // 
            this.asterix_Price.AutoSize = true;
            this.asterix_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Price.Location = new System.Drawing.Point(893, 480);
            this.asterix_Price.Name = "asterix_Price";
            this.asterix_Price.Size = new System.Drawing.Size(27, 36);
            this.asterix_Price.TabIndex = 212;
            this.asterix_Price.Text = "*";
            this.asterix_Price.Visible = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Price.Location = new System.Drawing.Point(507, 418);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(83, 36);
            this.lbl_Price.TabIndex = 210;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.Visible = false;
            // 
            // rdb_Rent
            // 
            this.rdb_Rent.AutoSize = true;
            this.rdb_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Rent.Location = new System.Drawing.Point(13, 479);
            this.rdb_Rent.Name = "rdb_Rent";
            this.rdb_Rent.Size = new System.Drawing.Size(103, 40);
            this.rdb_Rent.TabIndex = 3;
            this.rdb_Rent.TabStop = true;
            this.rdb_Rent.Tag = "3";
            this.rdb_Rent.Text = "Rent";
            this.rdb_Rent.UseVisualStyleBackColor = true;
            this.rdb_Rent.CheckedChanged += new System.EventHandler(this.rdb_Rent_CheckedChanged);
            // 
            // rdb_Buy
            // 
            this.rdb_Buy.AutoSize = true;
            this.rdb_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Buy.Location = new System.Drawing.Point(189, 478);
            this.rdb_Buy.Name = "rdb_Buy";
            this.rdb_Buy.Size = new System.Drawing.Size(100, 40);
            this.rdb_Buy.TabIndex = 4;
            this.rdb_Buy.TabStop = true;
            this.rdb_Buy.Tag = "4";
            this.rdb_Buy.Text = "Buy ";
            this.rdb_Buy.UseVisualStyleBackColor = true;
            this.rdb_Buy.CheckedChanged += new System.EventHandler(this.rdb_Buy_CheckedChanged);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Status.Location = new System.Drawing.Point(6, 418);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(99, 36);
            this.lbl_Status.TabIndex = 216;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_ErrorPrice
            // 
            this.lbl_ErrorPrice.AutoSize = true;
            this.lbl_ErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPrice.Location = new System.Drawing.Point(509, 535);
            this.lbl_ErrorPrice.Name = "lbl_ErrorPrice";
            this.lbl_ErrorPrice.Size = new System.Drawing.Size(126, 20);
            this.lbl_ErrorPrice.TabIndex = 219;
            this.lbl_ErrorPrice.Text = "Enter Vaild Price";
            this.lbl_ErrorPrice.Visible = false;
            // 
            // txt_LicenseNumber
            // 
            this.txt_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_LicenseNumber.Location = new System.Drawing.Point(9, 649);
            this.txt_LicenseNumber.MaxLength = 7;
            this.txt_LicenseNumber.Name = "txt_LicenseNumber";
            this.txt_LicenseNumber.Size = new System.Drawing.Size(374, 41);
            this.txt_LicenseNumber.TabIndex = 6;
            this.txt_LicenseNumber.Tag = "7";
            // 
            // lbl_LicenseNumber
            // 
            this.lbl_LicenseNumber.AutoSize = true;
            this.lbl_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_LicenseNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LicenseNumber.Location = new System.Drawing.Point(3, 596);
            this.lbl_LicenseNumber.Name = "lbl_LicenseNumber";
            this.lbl_LicenseNumber.Size = new System.Drawing.Size(231, 36);
            this.lbl_LicenseNumber.TabIndex = 221;
            this.lbl_LicenseNumber.Text = "License Number";
            // 
            // lbl_ErrorLicense
            // 
            this.lbl_ErrorLicense.AutoSize = true;
            this.lbl_ErrorLicense.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorLicense.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorLicense.Location = new System.Drawing.Point(9, 717);
            this.lbl_ErrorLicense.Name = "lbl_ErrorLicense";
            this.lbl_ErrorLicense.Size = new System.Drawing.Size(206, 20);
            this.lbl_ErrorLicense.TabIndex = 222;
            this.lbl_ErrorLicense.Text = "Enter Vaild License Number";
            this.lbl_ErrorLicense.Visible = false;
            // 
            // asterix_License
            // 
            this.asterix_License.AutoSize = true;
            this.asterix_License.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_License.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_License.Location = new System.Drawing.Point(389, 652);
            this.asterix_License.Name = "asterix_License";
            this.asterix_License.Size = new System.Drawing.Size(27, 36);
            this.asterix_License.TabIndex = 223;
            this.asterix_License.Text = "*";
            // 
            // asterix_Status
            // 
            this.asterix_Status.AutoSize = true;
            this.asterix_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Status.Location = new System.Drawing.Point(389, 480);
            this.asterix_Status.Name = "asterix_Status";
            this.asterix_Status.Size = new System.Drawing.Size(27, 36);
            this.asterix_Status.TabIndex = 224;
            this.asterix_Status.Text = "*";
            // 
            // lbl_ErrorStatus
            // 
            this.lbl_ErrorStatus.AutoSize = true;
            this.lbl_ErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorStatus.Location = new System.Drawing.Point(12, 535);
            this.lbl_ErrorStatus.Name = "lbl_ErrorStatus";
            this.lbl_ErrorStatus.Size = new System.Drawing.Size(138, 20);
            this.lbl_ErrorStatus.TabIndex = 225;
            this.lbl_ErrorStatus.Text = "Enter Vaild Status";
            this.lbl_ErrorStatus.Visible = false;
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(952, 17);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(475, 57);
            this.btn_Filter.TabIndex = 226;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // listbox_Cars
            // 
            this.listbox_Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Cars.FormattingEnabled = true;
            this.listbox_Cars.HorizontalScrollbar = true;
            this.listbox_Cars.ItemHeight = 36;
            this.listbox_Cars.Location = new System.Drawing.Point(952, 87);
            this.listbox_Cars.Name = "listbox_Cars";
            this.listbox_Cars.Size = new System.Drawing.Size(475, 616);
            this.listbox_Cars.TabIndex = 229;
            this.listbox_Cars.DoubleClick += new System.EventHandler(this.listbox_Cars_DoubleClick);
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1436, 881);
            this.Controls.Add(this.listbox_Cars);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.lbl_ErrorStatus);
            this.Controls.Add(this.asterix_Status);
            this.Controls.Add(this.asterix_License);
            this.Controls.Add(this.lbl_ErrorLicense);
            this.Controls.Add(this.lbl_LicenseNumber);
            this.Controls.Add(this.txt_LicenseNumber);
            this.Controls.Add(this.lbl_ErrorPrice);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.rdb_Buy);
            this.Controls.Add(this.rdb_Rent);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.asterix_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.cmb_Model);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.asterix_Model);
            this.Controls.Add(this.lbl_ErrorModel);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label asterix_Model;
        private System.Windows.Forms.Label lbl_ErrorModel;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.ComboBox cmb_Model;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label asterix_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.RadioButton rdb_Rent;
        private System.Windows.Forms.RadioButton rdb_Buy;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_ErrorPrice;
        private System.Windows.Forms.TextBox txt_LicenseNumber;
        private System.Windows.Forms.Label lbl_LicenseNumber;
        private System.Windows.Forms.Label lbl_ErrorLicense;
        private System.Windows.Forms.Label asterix_License;
        private System.Windows.Forms.Label asterix_Status;
        private System.Windows.Forms.Label lbl_ErrorStatus;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ListBox listbox_Cars;
    }
}