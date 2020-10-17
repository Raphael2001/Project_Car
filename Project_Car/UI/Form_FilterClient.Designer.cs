namespace Project_Car.UI
{
    partial class Form_FilterClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterClient));
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(12, 34);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(48, 37);
            this.lbl_Id.TabIndex = 134;
            this.lbl_Id.Text = "ID";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Name.Location = new System.Drawing.Point(12, 199);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(327, 41);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(12, 262);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(215, 36);
            this.lbl_PhoneNumber.TabIndex = 133;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_PhoneNumber.Location = new System.Drawing.Point(12, 320);
            this.txt_PhoneNumber.MaxLength = 10;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(327, 41);
            this.txt_PhoneNumber.TabIndex = 2;
            this.txt_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(12, 141);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 36);
            this.lbl_Name.TabIndex = 132;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Id.Location = new System.Drawing.Point(12, 86);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(327, 41);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(12, 409);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(142, 47);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(197, 409);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 47);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_FilterClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(361, 469);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_FilterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
    }
}