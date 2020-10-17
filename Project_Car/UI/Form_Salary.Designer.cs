namespace Project_Car.UI
{
    partial class Form_Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Salary));
            this.lbl_Bonus = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.cmb_Employee = new System.Windows.Forms.ComboBox();
            this.lbl_Choose = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Bonus
            // 
            this.lbl_Bonus.AutoSize = true;
            this.lbl_Bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bonus.Location = new System.Drawing.Point(14, 524);
            this.lbl_Bonus.Name = "lbl_Bonus";
            this.lbl_Bonus.Size = new System.Drawing.Size(109, 36);
            this.lbl_Bonus.TabIndex = 194;
            this.lbl_Bonus.Text = "Bonus:";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(14, 416);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(115, 36);
            this.lbl_Salary.TabIndex = 193;
            this.lbl_Salary.Text = "Salary :";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(109, 109);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 191;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 109);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 190;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Role.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Role.Location = new System.Drawing.Point(12, 316);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(93, 36);
            this.lbl_Role.TabIndex = 189;
            this.lbl_Role.Text = "Role :";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FullName.Location = new System.Drawing.Point(12, 198);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(165, 36);
            this.lbl_FullName.TabIndex = 188;
            this.lbl_FullName.Text = "Full Name :";
            // 
            // dtp_Time
            // 
            this.dtp_Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Time.Location = new System.Drawing.Point(12, 601);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(186, 41);
            this.dtp_Time.TabIndex = 195;
            this.dtp_Time.ValueChanged += new System.EventHandler(this.dtp_Time_ValueChanged);
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee.FormattingEnabled = true;
            this.cmb_Employee.Items.AddRange(new object[] {
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
            this.cmb_Employee.Location = new System.Drawing.Point(796, 223);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.Size = new System.Drawing.Size(374, 44);
            this.cmb_Employee.TabIndex = 196;
            this.cmb_Employee.SelectionChangeCommitted += new System.EventHandler(this.cmb_Employee_SelectionChangeCommitted);
            // 
            // lbl_Choose
            // 
            this.lbl_Choose.AutoSize = true;
            this.lbl_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Choose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Choose.Location = new System.Drawing.Point(790, 165);
            this.lbl_Choose.Name = "lbl_Choose";
            this.lbl_Choose.Size = new System.Drawing.Size(257, 36);
            this.lbl_Choose.TabIndex = 197;
            this.lbl_Choose.Text = "Choose Employee";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(452, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(200, 69);
            this.lbl_HeadLine.TabIndex = 198;
            this.lbl_HeadLine.Text = "Salary";
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(458, 643);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 199;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(458, 524);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(89, 36);
            this.lbl_Total.TabIndex = 200;
            this.lbl_Total.Text = "Total:";
            // 
            // Form_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1197, 686);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.cmb_Employee);
            this.Controls.Add(this.lbl_Choose);
            this.Controls.Add(this.dtp_Time);
            this.Controls.Add(this.lbl_Bonus);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.lbl_FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Bonus;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.ComboBox cmb_Employee;
        private System.Windows.Forms.Label lbl_Choose;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_Total;
    }
}