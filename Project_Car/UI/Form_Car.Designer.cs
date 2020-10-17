namespace Project_Car.UI
{
    partial class Form_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Car));
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ErrorCompany = new System.Windows.Forms.Label();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.asterix_Company = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.listbox_Product = new System.Windows.Forms.ListBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.asterix_Engine = new System.Windows.Forms.Label();
            this.lbl_ErrorEngine = new System.Windows.Forms.Label();
            this.cmb_Engine = new System.Windows.Forms.ComboBox();
            this.lbl_Engine = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_HorsePower = new System.Windows.Forms.TextBox();
            this.asterix_HorsePower = new System.Windows.Forms.Label();
            this.lbl_ErrorHorsePower = new System.Windows.Forms.Label();
            this.lbl_HorsePower = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.asterix_Category = new System.Windows.Forms.Label();
            this.lbl_ErrorCategory = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btn_Photo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(81, 168);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 145;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(8, 168);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 144;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ErrorCompany
            // 
            this.lbl_ErrorCompany.AutoSize = true;
            this.lbl_ErrorCompany.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCompany.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorCompany.Location = new System.Drawing.Point(12, 388);
            this.lbl_ErrorCompany.Name = "lbl_ErrorCompany";
            this.lbl_ErrorCompany.Size = new System.Drawing.Size(158, 20);
            this.lbl_ErrorCompany.TabIndex = 143;
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
            this.cmb_Company.Location = new System.Drawing.Point(12, 330);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(374, 44);
            this.cmb_Company.TabIndex = 1;
            this.cmb_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_SelectedIndexChanged);
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(6, 278);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(141, 36);
            this.lbl_Company.TabIndex = 141;
            this.lbl_Company.Text = "Company";
            this.toolTip1.SetToolTip(this.lbl_Company, "Click to add a new company");
            this.lbl_Company.Click += new System.EventHandler(this.lbl_Company_Click);
            // 
            // txt_Model
            // 
            this.txt_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Model.Location = new System.Drawing.Point(461, 168);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(374, 41);
            this.txt_Model.TabIndex = 0;
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Model.Location = new System.Drawing.Point(455, 117);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(97, 36);
            this.lbl_Model.TabIndex = 138;
            this.lbl_Model.Text = "Model";
            // 
            // asterix_Company
            // 
            this.asterix_Company.AutoSize = true;
            this.asterix_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Company.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Company.Location = new System.Drawing.Point(392, 330);
            this.asterix_Company.Name = "asterix_Company";
            this.asterix_Company.Size = new System.Drawing.Size(27, 36);
            this.asterix_Company.TabIndex = 148;
            this.asterix_Company.Text = "*";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(364, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(126, 69);
            this.lbl_HeadLine.TabIndex = 157;
            this.lbl_HeadLine.Text = "Car";
            // 
            // listbox_Product
            // 
            this.listbox_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Product.FormattingEnabled = true;
            this.listbox_Product.ItemHeight = 36;
            this.listbox_Product.Location = new System.Drawing.Point(921, 100);
            this.listbox_Product.Name = "listbox_Product";
            this.listbox_Product.Size = new System.Drawing.Size(596, 688);
            this.listbox_Product.TabIndex = 159;
            this.listbox_Product.DoubleClick += new System.EventHandler(this.listbox_Product_DoubleClick);
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(921, 37);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(596, 57);
            this.btn_Filter.TabIndex = 12;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // asterix_Engine
            // 
            this.asterix_Engine.AutoSize = true;
            this.asterix_Engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Engine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Engine.Location = new System.Drawing.Point(395, 486);
            this.asterix_Engine.Name = "asterix_Engine";
            this.asterix_Engine.Size = new System.Drawing.Size(27, 36);
            this.asterix_Engine.TabIndex = 164;
            this.asterix_Engine.Text = "*";
            // 
            // lbl_ErrorEngine
            // 
            this.lbl_ErrorEngine.AutoSize = true;
            this.lbl_ErrorEngine.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorEngine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorEngine.Location = new System.Drawing.Point(15, 544);
            this.lbl_ErrorEngine.Name = "lbl_ErrorEngine";
            this.lbl_ErrorEngine.Size = new System.Drawing.Size(141, 20);
            this.lbl_ErrorEngine.TabIndex = 163;
            this.lbl_ErrorEngine.Text = "Enter Vaild Engine";
            this.lbl_ErrorEngine.Visible = false;
            // 
            // cmb_Engine
            // 
            this.cmb_Engine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Engine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Engine.FormattingEnabled = true;
            this.cmb_Engine.Items.AddRange(new object[] {
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
            this.cmb_Engine.Location = new System.Drawing.Point(15, 486);
            this.cmb_Engine.Name = "cmb_Engine";
            this.cmb_Engine.Size = new System.Drawing.Size(374, 44);
            this.cmb_Engine.TabIndex = 3;
            // 
            // lbl_Engine
            // 
            this.lbl_Engine.AutoSize = true;
            this.lbl_Engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Engine.Location = new System.Drawing.Point(9, 434);
            this.lbl_Engine.Name = "lbl_Engine";
            this.lbl_Engine.Size = new System.Drawing.Size(109, 36);
            this.lbl_Engine.TabIndex = 162;
            this.lbl_Engine.Text = "Engine";
            this.lbl_Engine.Click += new System.EventHandler(this.lbl_Engine_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(507, 740);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(204, 57);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete Car";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(88, 740);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(286, 821);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 172;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(259, 740);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(231, 57);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save Car";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_HorsePower
            // 
            this.txt_HorsePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_HorsePower.Location = new System.Drawing.Point(461, 486);
            this.txt_HorsePower.Name = "txt_HorsePower";
            this.txt_HorsePower.Size = new System.Drawing.Size(374, 41);
            this.txt_HorsePower.TabIndex = 4;
            // 
            // asterix_HorsePower
            // 
            this.asterix_HorsePower.AutoSize = true;
            this.asterix_HorsePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_HorsePower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_HorsePower.Location = new System.Drawing.Point(841, 486);
            this.asterix_HorsePower.Name = "asterix_HorsePower";
            this.asterix_HorsePower.Size = new System.Drawing.Size(27, 36);
            this.asterix_HorsePower.TabIndex = 176;
            this.asterix_HorsePower.Text = "*";
            // 
            // lbl_ErrorHorsePower
            // 
            this.lbl_ErrorHorsePower.AutoSize = true;
            this.lbl_ErrorHorsePower.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorHorsePower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorHorsePower.Location = new System.Drawing.Point(457, 544);
            this.lbl_ErrorHorsePower.Name = "lbl_ErrorHorsePower";
            this.lbl_ErrorHorsePower.Size = new System.Drawing.Size(263, 20);
            this.lbl_ErrorHorsePower.TabIndex = 175;
            this.lbl_ErrorHorsePower.Text = "Enter Vaild Number Of Horse Power";
            this.lbl_ErrorHorsePower.Visible = false;
            // 
            // lbl_HorsePower
            // 
            this.lbl_HorsePower.AutoSize = true;
            this.lbl_HorsePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_HorsePower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HorsePower.Location = new System.Drawing.Point(455, 434);
            this.lbl_HorsePower.Name = "lbl_HorsePower";
            this.lbl_HorsePower.Size = new System.Drawing.Size(187, 36);
            this.lbl_HorsePower.TabIndex = 174;
            this.lbl_HorsePower.Text = "Horse Power";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Category.Location = new System.Drawing.Point(446, 281);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(135, 36);
            this.lbl_Category.TabIndex = 178;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.Click += new System.EventHandler(this.lbl_Category_Click);
            // 
            // asterix_Category
            // 
            this.asterix_Category.AutoSize = true;
            this.asterix_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Category.Location = new System.Drawing.Point(832, 333);
            this.asterix_Category.Name = "asterix_Category";
            this.asterix_Category.Size = new System.Drawing.Size(27, 36);
            this.asterix_Category.TabIndex = 180;
            this.asterix_Category.Text = "*";
            // 
            // lbl_ErrorCategory
            // 
            this.lbl_ErrorCategory.AutoSize = true;
            this.lbl_ErrorCategory.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorCategory.Location = new System.Drawing.Point(457, 388);
            this.lbl_ErrorCategory.Name = "lbl_ErrorCategory";
            this.lbl_ErrorCategory.Size = new System.Drawing.Size(155, 20);
            this.lbl_ErrorCategory.TabIndex = 179;
            this.lbl_ErrorCategory.Text = "Enter Vaild Category";
            this.lbl_ErrorCategory.Visible = false;
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
            this.cmb_Category.Location = new System.Drawing.Point(461, 330);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(374, 44);
            this.cmb_Category.TabIndex = 2;
            // 
            // btn_Photo
            // 
            this.btn_Photo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Photo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Photo.Location = new System.Drawing.Point(16, 618);
            this.btn_Photo.Name = "btn_Photo";
            this.btn_Photo.Size = new System.Drawing.Size(373, 57);
            this.btn_Photo.TabIndex = 7;
            this.btn_Photo.Text = "Car Photo";
            this.btn_Photo.UseVisualStyleBackColor = true;
            this.btn_Photo.Click += new System.EventHandler(this.btn_Photo_Click);
            // 
            // Form_Car
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1529, 875);
            this.Controls.Add(this.btn_Photo);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.asterix_Category);
            this.Controls.Add(this.lbl_ErrorCategory);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.txt_HorsePower);
            this.Controls.Add(this.asterix_HorsePower);
            this.Controls.Add(this.lbl_ErrorHorsePower);
            this.Controls.Add(this.lbl_HorsePower);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.asterix_Engine);
            this.Controls.Add(this.lbl_ErrorEngine);
            this.Controls.Add(this.cmb_Engine);
            this.Controls.Add(this.lbl_Engine);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.listbox_Product);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.asterix_Company);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ErrorCompany);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.lbl_Model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ErrorCompany;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label asterix_Company;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.ListBox listbox_Product;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label asterix_Engine;
        private System.Windows.Forms.Label lbl_ErrorEngine;
        private System.Windows.Forms.ComboBox cmb_Engine;
        private System.Windows.Forms.Label lbl_Engine;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_HorsePower;
        private System.Windows.Forms.Label asterix_HorsePower;
        private System.Windows.Forms.Label lbl_ErrorHorsePower;
        private System.Windows.Forms.Label lbl_HorsePower;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label asterix_Category;
        private System.Windows.Forms.Label lbl_ErrorCategory;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_Photo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}