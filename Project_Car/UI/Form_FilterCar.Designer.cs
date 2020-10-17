namespace Project_Car.UI
{
    partial class Form_FilterCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterCar));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(202, 398);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 47);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(17, 398);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(142, 47);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Id.Location = new System.Drawing.Point(17, 75);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(327, 41);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(12, 26);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(44, 36);
            this.lbl_Id.TabIndex = 143;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Category.Location = new System.Drawing.Point(12, 252);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(145, 36);
            this.lbl_Category.TabIndex = 141;
            this.lbl_Category.Text = "Catergory";
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
            this.cmb_Company.Location = new System.Drawing.Point(17, 187);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(332, 44);
            this.cmb_Company.TabIndex = 1;
            this.cmb_Company.SelectedValueChanged += new System.EventHandler(this.cmb_Company_SelectedValueChanged);
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(12, 139);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(141, 36);
            this.lbl_Company.TabIndex = 147;
            this.lbl_Company.Text = "Company";
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
            this.cmb_Category.Location = new System.Drawing.Point(17, 301);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(332, 44);
            this.cmb_Category.TabIndex = 2;
            // 
            // Form_FilterCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(361, 469);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FilterCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.ComboBox cmb_Category;
    }
}