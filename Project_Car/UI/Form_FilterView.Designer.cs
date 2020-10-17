namespace Project_Car.UI
{
    partial class Form_FilterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterView));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.lbl_MinPrice = new System.Windows.Forms.Label();
            this.txt_minPrice = new System.Windows.Forms.TextBox();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.lbl_maxPrice = new System.Windows.Forms.Label();
            this.txt_maxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(224, 430);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(160, 47);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(12, 430);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(158, 47);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_MinPrice
            // 
            this.lbl_MinPrice.AutoSize = true;
            this.lbl_MinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_MinPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_MinPrice.Location = new System.Drawing.Point(6, 142);
            this.lbl_MinPrice.Name = "lbl_MinPrice";
            this.lbl_MinPrice.Size = new System.Drawing.Size(210, 36);
            this.lbl_MinPrice.TabIndex = 233;
            this.lbl_MinPrice.Text = "Minimum Price";
            // 
            // txt_minPrice
            // 
            this.txt_minPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_minPrice.Location = new System.Drawing.Point(12, 207);
            this.txt_minPrice.MaxLength = 7;
            this.txt_minPrice.Name = "txt_minPrice";
            this.txt_minPrice.Size = new System.Drawing.Size(374, 41);
            this.txt_minPrice.TabIndex = 1;
            this.txt_minPrice.Tag = "7";
            this.txt_minPrice.Text = "0";
            this.txt_minPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
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
            this.cmb_Company.Location = new System.Drawing.Point(12, 62);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(374, 44);
            this.cmb_Company.TabIndex = 0;
            this.cmb_Company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(6, 9);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(141, 36);
            this.lbl_Company.TabIndex = 230;
            this.lbl_Company.Text = "Company";
            // 
            // lbl_maxPrice
            // 
            this.lbl_maxPrice.AutoSize = true;
            this.lbl_maxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_maxPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_maxPrice.Location = new System.Drawing.Point(6, 272);
            this.lbl_maxPrice.Name = "lbl_maxPrice";
            this.lbl_maxPrice.Size = new System.Drawing.Size(217, 36);
            this.lbl_maxPrice.TabIndex = 237;
            this.lbl_maxPrice.Text = "Maximum Price";
            // 
            // txt_maxPrice
            // 
            this.txt_maxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_maxPrice.Location = new System.Drawing.Point(12, 345);
            this.txt_maxPrice.MaxLength = 7;
            this.txt_maxPrice.Name = "txt_maxPrice";
            this.txt_maxPrice.Size = new System.Drawing.Size(374, 41);
            this.txt_maxPrice.TabIndex = 2;
            this.txt_maxPrice.Tag = "7";
            this.txt_maxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // Form_FilterView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(396, 503);
            this.Controls.Add(this.lbl_maxPrice);
            this.Controls.Add(this.txt_maxPrice);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.lbl_MinPrice);
            this.Controls.Add(this.txt_minPrice);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.lbl_Company);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FilterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label lbl_MinPrice;
        private System.Windows.Forms.TextBox txt_minPrice;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Label lbl_maxPrice;
        private System.Windows.Forms.TextBox txt_maxPrice;
    }
}