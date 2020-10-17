namespace Project_Car.UI
{
    partial class Form_CarsInRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CarsInRent));
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.listbox_Cars = new System.Windows.Forms.ListBox();
            this.txt_LicenseNumber = new System.Windows.Forms.Label();
            this.txt_Type = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_IdCar = new System.Windows.Forms.Label();
            this.lbl_LicenseNumber = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(319, 12);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(242, 46);
            this.lbl_HeadLine.TabIndex = 114;
            this.lbl_HeadLine.Text = "Cars In Rent";
            // 
            // listbox_Cars
            // 
            this.listbox_Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Cars.FormattingEnabled = true;
            this.listbox_Cars.HorizontalScrollbar = true;
            this.listbox_Cars.ItemHeight = 36;
            this.listbox_Cars.Location = new System.Drawing.Point(787, 87);
            this.listbox_Cars.Name = "listbox_Cars";
            this.listbox_Cars.Size = new System.Drawing.Size(386, 544);
            this.listbox_Cars.TabIndex = 193;
            this.listbox_Cars.DoubleClick += new System.EventHandler(this.listbox_Cars_DoubleClick);
            // 
            // txt_LicenseNumber
            // 
            this.txt_LicenseNumber.AutoSize = true;
            this.txt_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LicenseNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_LicenseNumber.Location = new System.Drawing.Point(26, 508);
            this.txt_LicenseNumber.Name = "txt_LicenseNumber";
            this.txt_LicenseNumber.Size = new System.Drawing.Size(0, 36);
            this.txt_LicenseNumber.TabIndex = 199;
            // 
            // txt_Type
            // 
            this.txt_Type.AutoSize = true;
            this.txt_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Type.Location = new System.Drawing.Point(26, 216);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(0, 36);
            this.txt_Type.TabIndex = 198;
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(102, 87);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 197;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_IdCar
            // 
            this.lbl_IdCar.AutoSize = true;
            this.lbl_IdCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCar.Location = new System.Drawing.Point(12, 87);
            this.lbl_IdCar.Name = "lbl_IdCar";
            this.lbl_IdCar.Size = new System.Drawing.Size(44, 36);
            this.lbl_IdCar.TabIndex = 196;
            this.lbl_IdCar.Text = "ID";
            // 
            // lbl_LicenseNumber
            // 
            this.lbl_LicenseNumber.AutoSize = true;
            this.lbl_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LicenseNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LicenseNumber.Location = new System.Drawing.Point(12, 440);
            this.lbl_LicenseNumber.Name = "lbl_LicenseNumber";
            this.lbl_LicenseNumber.Size = new System.Drawing.Size(231, 36);
            this.lbl_LicenseNumber.TabIndex = 195;
            this.lbl_LicenseNumber.Text = "License Number";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Model.Location = new System.Drawing.Point(12, 159);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(126, 36);
            this.lbl_Model.TabIndex = 194;
            this.lbl_Model.Text = "Car type";
            // 
            // txt_FullName
            // 
            this.txt_FullName.AutoSize = true;
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FullName.Location = new System.Drawing.Point(31, 361);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(0, 36);
            this.txt_FullName.TabIndex = 201;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FullName.Location = new System.Drawing.Point(12, 300);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(149, 36);
            this.lbl_FullName.TabIndex = 200;
            this.lbl_FullName.Text = "Full Name";
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(787, 12);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(386, 57);
            this.btn_Filter.TabIndex = 202;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(358, 558);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(256, 73);
            this.btn_Return.TabIndex = 203;
            this.btn_Return.Text = "Return Car";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // Form_CarsInRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.txt_LicenseNumber);
            this.Controls.Add(this.txt_Type);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_IdCar);
            this.Controls.Add(this.lbl_LicenseNumber);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.listbox_Cars);
            this.Controls.Add(this.lbl_HeadLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CarsInRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsInRent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.ListBox listbox_Cars;
        private System.Windows.Forms.Label txt_LicenseNumber;
        private System.Windows.Forms.Label txt_Type;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_IdCar;
        private System.Windows.Forms.Label lbl_LicenseNumber;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label txt_FullName;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Return;
    }
}