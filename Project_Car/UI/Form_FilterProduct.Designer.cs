namespace Project_Car.UI
{
    partial class Form_FilterProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterProduct));
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.rdb_Buy = new System.Windows.Forms.RadioButton();
            this.rdb_Rent = new System.Windows.Forms.RadioButton();
            this.lbl_LicenseNumber = new System.Windows.Forms.Label();
            this.txt_LicenseNumber = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cmb_Model.Location = new System.Drawing.Point(12, 457);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(374, 44);
            this.cmb_Model.TabIndex = 3;
            this.cmb_Model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
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
            this.cmb_Category.Location = new System.Drawing.Point(12, 318);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(374, 44);
            this.cmb_Category.TabIndex = 2;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            this.cmb_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Category.Location = new System.Drawing.Point(6, 259);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(135, 36);
            this.Category.TabIndex = 213;
            this.Category.Text = "Category";
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
            this.cmb_Company.Location = new System.Drawing.Point(12, 186);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(374, 44);
            this.cmb_Company.TabIndex = 1;
            this.cmb_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_SelectedIndexChanged);
            this.cmb_Company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(6, 133);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(141, 36);
            this.lbl_Company.TabIndex = 212;
            this.lbl_Company.Text = "Company";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Model.Location = new System.Drawing.Point(6, 393);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(97, 36);
            this.lbl_Model.TabIndex = 211;
            this.lbl_Model.Text = "Model";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Id.Location = new System.Drawing.Point(12, 63);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(368, 41);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(12, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(44, 36);
            this.lbl_Id.TabIndex = 215;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Status.Location = new System.Drawing.Point(6, 516);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(99, 36);
            this.lbl_Status.TabIndex = 219;
            this.lbl_Status.Text = "Status";
            // 
            // rdb_Buy
            // 
            this.rdb_Buy.AutoSize = true;
            this.rdb_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Buy.Location = new System.Drawing.Point(167, 565);
            this.rdb_Buy.Name = "rdb_Buy";
            this.rdb_Buy.Size = new System.Drawing.Size(100, 40);
            this.rdb_Buy.TabIndex = 5;
            this.rdb_Buy.TabStop = true;
            this.rdb_Buy.Tag = "5";
            this.rdb_Buy.Text = "Buy ";
            this.rdb_Buy.UseVisualStyleBackColor = true;
            this.rdb_Buy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // rdb_Rent
            // 
            this.rdb_Rent.AutoSize = true;
            this.rdb_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Rent.Location = new System.Drawing.Point(18, 565);
            this.rdb_Rent.Name = "rdb_Rent";
            this.rdb_Rent.Size = new System.Drawing.Size(103, 40);
            this.rdb_Rent.TabIndex = 4;
            this.rdb_Rent.TabStop = true;
            this.rdb_Rent.Tag = "4";
            this.rdb_Rent.Text = "Rent";
            this.rdb_Rent.UseVisualStyleBackColor = true;
            this.rdb_Rent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_LicenseNumber
            // 
            this.lbl_LicenseNumber.AutoSize = true;
            this.lbl_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_LicenseNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LicenseNumber.Location = new System.Drawing.Point(6, 636);
            this.lbl_LicenseNumber.Name = "lbl_LicenseNumber";
            this.lbl_LicenseNumber.Size = new System.Drawing.Size(231, 36);
            this.lbl_LicenseNumber.TabIndex = 223;
            this.lbl_LicenseNumber.Text = "License Number";
            // 
            // txt_LicenseNumber
            // 
            this.txt_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_LicenseNumber.Location = new System.Drawing.Point(12, 690);
            this.txt_LicenseNumber.MaxLength = 7;
            this.txt_LicenseNumber.Name = "txt_LicenseNumber";
            this.txt_LicenseNumber.Size = new System.Drawing.Size(374, 41);
            this.txt_LicenseNumber.TabIndex = 6;
            this.txt_LicenseNumber.Tag = "6";
            this.txt_LicenseNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 753);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 47);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(25, 753);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(142, 47);
            this.btn_Apply.TabIndex = 7;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // Form_FilterProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(409, 819);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.lbl_LicenseNumber);
            this.Controls.Add(this.txt_LicenseNumber);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.rdb_Buy);
            this.Controls.Add(this.rdb_Rent);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.cmb_Model);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.lbl_Model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FilterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Model;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.RadioButton rdb_Buy;
        private System.Windows.Forms.RadioButton rdb_Rent;
        private System.Windows.Forms.Label lbl_LicenseNumber;
        private System.Windows.Forms.TextBox txt_LicenseNumber;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
    }
}