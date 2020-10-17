namespace Project_Car.UI
{
    partial class Form_PasswordUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PasswordUpdate));
            this.btn_Apply = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_New = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Old = new System.Windows.Forms.TextBox();
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_ErrorOld = new System.Windows.Forms.Label();
            this.lbl_ErrorNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Apply.Location = new System.Drawing.Point(275, 358);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(304, 87);
            this.btn_Apply.TabIndex = 7;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = false;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password.Location = new System.Drawing.Point(59, 256);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(215, 36);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "New Password";
            // 
            // txt_New
            // 
            this.txt_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New.Location = new System.Drawing.Point(308, 251);
            this.txt_New.Name = "txt_New";
            this.txt_New.Size = new System.Drawing.Size(292, 41);
            this.txt_New.TabIndex = 5;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Username.Location = new System.Drawing.Point(59, 159);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(201, 36);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Old Password";
            // 
            // txt_Old
            // 
            this.txt_Old.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Old.Location = new System.Drawing.Point(308, 154);
            this.txt_Old.Name = "txt_Old";
            this.txt_Old.Size = new System.Drawing.Size(292, 41);
            this.txt_Old.TabIndex = 4;
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.BackColor = System.Drawing.Color.Transparent;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(269, 468);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 161;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadLine.Location = new System.Drawing.Point(79, 28);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(500, 69);
            this.lbl_HeadLine.TabIndex = 162;
            this.lbl_HeadLine.Text = "Update Password";
            // 
            // lbl_ErrorOld
            // 
            this.lbl_ErrorOld.AutoSize = true;
            this.lbl_ErrorOld.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorOld.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorOld.Location = new System.Drawing.Point(304, 208);
            this.lbl_ErrorOld.Name = "lbl_ErrorOld";
            this.lbl_ErrorOld.Size = new System.Drawing.Size(170, 20);
            this.lbl_ErrorOld.TabIndex = 163;
            this.lbl_ErrorOld.Text = "Password Don`t match";
            this.lbl_ErrorOld.Visible = false;
            // 
            // lbl_ErrorNew
            // 
            this.lbl_ErrorNew.AutoSize = true;
            this.lbl_ErrorNew.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorNew.Location = new System.Drawing.Point(304, 304);
            this.lbl_ErrorNew.Name = "lbl_ErrorNew";
            this.lbl_ErrorNew.Size = new System.Drawing.Size(160, 20);
            this.lbl_ErrorNew.TabIndex = 164;
            this.lbl_ErrorNew.Text = "Enter Vaild Password";
            this.lbl_ErrorNew.Visible = false;
            // 
            // Form_PasswordUpdate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 518);
            this.Controls.Add(this.lbl_ErrorNew);
            this.Controls.Add(this.lbl_ErrorOld);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_New);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Old);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PasswordUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_New;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Old;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_ErrorOld;
        private System.Windows.Forms.Label lbl_ErrorNew;
    }
}