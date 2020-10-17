namespace Project_Car.UI
{
    partial class Form_FilterCarsInRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterCarsInRent));
            this.cmb_Client = new System.Windows.Forms.ComboBox();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.dtp_DateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateOrder = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.rdb_Dates = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmb_Client
            // 
            this.cmb_Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Client.FormattingEnabled = true;
            this.cmb_Client.Items.AddRange(new object[] {
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
            this.cmb_Client.Location = new System.Drawing.Point(12, 77);
            this.cmb_Client.Name = "cmb_Client";
            this.cmb_Client.Size = new System.Drawing.Size(374, 44);
            this.cmb_Client.TabIndex = 0;
            this.cmb_Client.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.cmb_Client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Client.Location = new System.Drawing.Point(6, 24);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(91, 36);
            this.lbl_Client.TabIndex = 109;
            this.lbl_Client.Text = "Client";
            // 
            // cmb_Product
            // 
            this.cmb_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Items.AddRange(new object[] {
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
            this.cmb_Product.Location = new System.Drawing.Point(12, 207);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(374, 44);
            this.cmb_Product.TabIndex = 1;
            this.cmb_Product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.cmb_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Product.Location = new System.Drawing.Point(6, 141);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(119, 36);
            this.lbl_Product.TabIndex = 125;
            this.lbl_Product.Text = "Product";
            // 
            // dtp_DateTo
            // 
            this.dtp_DateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateTo.Location = new System.Drawing.Point(12, 338);
            this.dtp_DateTo.Name = "dtp_DateTo";
            this.dtp_DateTo.ShowCheckBox = true;
            this.dtp_DateTo.Size = new System.Drawing.Size(374, 30);
            this.dtp_DateTo.TabIndex = 2;
            this.dtp_DateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_DateOrder
            // 
            this.lbl_DateOrder.AutoSize = true;
            this.lbl_DateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_DateOrder.Location = new System.Drawing.Point(6, 275);
            this.lbl_DateOrder.Name = "lbl_DateOrder";
            this.lbl_DateOrder.Size = new System.Drawing.Size(119, 36);
            this.lbl_DateOrder.TabIndex = 248;
            this.lbl_DateOrder.Text = "Date To";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 443);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 47);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(25, 443);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(142, 47);
            this.btn_Apply.TabIndex = 4;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // rdb_Dates
            // 
            this.rdb_Dates.AutoSize = true;
            this.rdb_Dates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Dates.Location = new System.Drawing.Point(12, 384);
            this.rdb_Dates.Name = "rdb_Dates";
            this.rdb_Dates.Size = new System.Drawing.Size(133, 33);
            this.rdb_Dates.TabIndex = 3;
            this.rdb_Dates.TabStop = true;
            this.rdb_Dates.Text = "All Dates";
            this.rdb_Dates.UseVisualStyleBackColor = true;
            this.rdb_Dates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // Form_FilterCarsInRent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(412, 514);
            this.Controls.Add(this.rdb_Dates);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.lbl_DateOrder);
            this.Controls.Add(this.dtp_DateTo);
            this.Controls.Add(this.cmb_Product);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.cmb_Client);
            this.Controls.Add(this.lbl_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FilterCarsInRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterCarsInRent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Client;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.DateTimePicker dtp_DateTo;
        private System.Windows.Forms.Label lbl_DateOrder;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.RadioButton rdb_Dates;
    }
}