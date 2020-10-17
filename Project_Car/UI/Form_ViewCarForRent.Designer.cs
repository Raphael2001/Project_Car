namespace Project_Car.UI
{
    partial class Form_ViewCarForRent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewCarForRent));
            this.dgv_Cars = new System.Windows.Forms.DataGridView();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Engine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cars
            // 
            this.dgv_Cars.AllowUserToAddRows = false;
            this.dgv_Cars.AllowUserToDeleteRows = false;
            this.dgv_Cars.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Company,
            this.col_Category,
            this.col_Model,
            this.col_Engine,
            this.col_Price,
            this.col_LicenseNumber,
            this.col_Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Cars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Cars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cars.Location = new System.Drawing.Point(0, 0);
            this.dgv_Cars.MultiSelect = false;
            this.dgv_Cars.Name = "dgv_Cars";
            this.dgv_Cars.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Cars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Cars.RowTemplate.Height = 40;
            this.dgv_Cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cars.Size = new System.Drawing.Size(1271, 650);
            this.dgv_Cars.TabIndex = 8;
            this.dgv_Cars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_ViewCarForRent_KeyDown);
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AllowDrop = true;
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Instructions.Location = new System.Drawing.Point(262, 148);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(746, 354);
            this.lbl_Instructions.TabIndex = 9;
            this.lbl_Instructions.Text = "Instructions\r\n\r\nEsc - Exit\r\nCtrl+I - Open/Close Instructions\r\nCtrl+F - Filter\r\nCt" +
    "rl+N - New Car ";
            // 
            // col_Id
            // 
            this.col_Id.HeaderText = "ID";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            // 
            // col_Company
            // 
            this.col_Company.HeaderText = "Company";
            this.col_Company.Name = "col_Company";
            this.col_Company.ReadOnly = true;
            // 
            // col_Category
            // 
            this.col_Category.HeaderText = "Categoty";
            this.col_Category.Name = "col_Category";
            this.col_Category.ReadOnly = true;
            // 
            // col_Model
            // 
            this.col_Model.HeaderText = "Model";
            this.col_Model.Name = "col_Model";
            this.col_Model.ReadOnly = true;
            // 
            // col_Engine
            // 
            this.col_Engine.HeaderText = "Engine";
            this.col_Engine.Name = "col_Engine";
            this.col_Engine.ReadOnly = true;
            // 
            // col_Price
            // 
            this.col_Price.HeaderText = "Price";
            this.col_Price.Name = "col_Price";
            this.col_Price.ReadOnly = true;
            // 
            // col_LicenseNumber
            // 
            this.col_LicenseNumber.HeaderText = "License Number";
            this.col_LicenseNumber.Name = "col_LicenseNumber";
            this.col_LicenseNumber.ReadOnly = true;
            // 
            // col_Status
            // 
            this.col_Status.HeaderText = "Status";
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            // 
            // Form_ViewCarForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 650);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.dgv_Cars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ViewCarForRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCarForRent";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Cars;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
    }
}