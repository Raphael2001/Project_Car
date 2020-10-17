namespace Project_Car.UI
{
    partial class Form_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Category));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.listbox_Category = new System.Windows.Forms.ListBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.asterix_Name = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.asterix_Company = new System.Windows.Forms.Label();
            this.lbl_ErrorCompany = new System.Windows.Forms.Label();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(20, 472);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(491, 57);
            this.btn_Delete.TabIndex = 200;
            this.btn_Delete.Text = "Delete Category";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // listbox_Category
            // 
            this.listbox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Category.FormattingEnabled = true;
            this.listbox_Category.ItemHeight = 36;
            this.listbox_Category.Location = new System.Drawing.Point(574, 12);
            this.listbox_Category.Name = "listbox_Category";
            this.listbox_Category.Size = new System.Drawing.Size(336, 508);
            this.listbox_Category.TabIndex = 199;
            this.listbox_Category.DoubleClick += new System.EventHandler(this.listbox_Category_DoubleClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(20, 409);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(209, 57);
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
            this.btn_Save.Location = new System.Drawing.Point(245, 409);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(266, 57);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save Category";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(338, 553);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 196;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(216, 12);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(229, 58);
            this.lbl_HeadLine.TabIndex = 195;
            this.lbl_HeadLine.Text = "Category";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(179, 112);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 194;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(16, 112);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 193;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorName.Location = new System.Drawing.Point(182, 352);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorName.TabIndex = 192;
            this.lbl_ErrorName.Text = "Enter Vaild Name";
            this.lbl_ErrorName.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Name.Location = new System.Drawing.Point(185, 290);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 41);
            this.txt_Name.TabIndex = 1;
            // 
            // asterix_Name
            // 
            this.asterix_Name.AutoSize = true;
            this.asterix_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Name.Location = new System.Drawing.Point(517, 290);
            this.asterix_Name.Name = "asterix_Name";
            this.asterix_Name.Size = new System.Drawing.Size(27, 36);
            this.asterix_Name.TabIndex = 191;
            this.asterix_Name.Text = "*";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(14, 290);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 36);
            this.lbl_Name.TabIndex = 190;
            this.lbl_Name.Text = "Name";
            // 
            // asterix_Company
            // 
            this.asterix_Company.AutoSize = true;
            this.asterix_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Company.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Company.Location = new System.Drawing.Point(517, 175);
            this.asterix_Company.Name = "asterix_Company";
            this.asterix_Company.Size = new System.Drawing.Size(27, 36);
            this.asterix_Company.TabIndex = 205;
            this.asterix_Company.Text = "*";
            // 
            // lbl_ErrorCompany
            // 
            this.lbl_ErrorCompany.AutoSize = true;
            this.lbl_ErrorCompany.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCompany.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorCompany.Location = new System.Drawing.Point(182, 240);
            this.lbl_ErrorCompany.Name = "lbl_ErrorCompany";
            this.lbl_ErrorCompany.Size = new System.Drawing.Size(158, 20);
            this.lbl_ErrorCompany.TabIndex = 204;
            this.lbl_ErrorCompany.Text = "Enter Vaild Company";
            this.lbl_ErrorCompany.Visible = false;
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
            this.cmb_Company.Location = new System.Drawing.Point(185, 175);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(326, 44);
            this.cmb_Company.TabIndex = 0;
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(10, 183);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(141, 36);
            this.lbl_Company.TabIndex = 203;
            this.lbl_Company.Text = "Company";
            this.toolTip1.SetToolTip(this.lbl_Company, "Click to add a new Company");
            this.lbl_Company.Click += new System.EventHandler(this.Lbl_Company_Click);
            // 
            // Form_Category
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(917, 607);
            this.Controls.Add(this.asterix_Company);
            this.Controls.Add(this.lbl_ErrorCompany);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.listbox_Category);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ErrorName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.asterix_Name);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListBox listbox_Category;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label asterix_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label asterix_Company;
        private System.Windows.Forms.Label lbl_ErrorCompany;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}