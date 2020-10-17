namespace Project_Car.UI
{
    partial class Form_EmployeeAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EmployeeAuthentication));
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_ErrorUsername = new System.Windows.Forms.Label();
            this.asterix_Usrrname = new System.Windows.Forms.Label();
            this.lbl_ErrorPassword = new System.Windows.Forms.Label();
            this.asterix_Password = new System.Windows.Forms.Label();
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(205, 114);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(292, 41);
            this.txt_Username.TabIndex = 0;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Username.Location = new System.Drawing.Point(41, 114);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(150, 36);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Password.Location = new System.Drawing.Point(41, 207);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(147, 36);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(205, 204);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(292, 41);
            this.txt_Password.TabIndex = 1;
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadLine.Location = new System.Drawing.Point(109, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(410, 69);
            this.lbl_HeadLine.TabIndex = 4;
            this.lbl_HeadLine.Text = "Authentication";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.ForeColor = System.Drawing.Color.Blue;
            this.btn_LogIn.Location = new System.Drawing.Point(99, 364);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(217, 87);
            this.btn_LogIn.TabIndex = 2;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            this.btn_LogIn.Enter += new System.EventHandler(this.btn__Enter);
            this.btn_LogIn.Leave += new System.EventHandler(this.btn__Leave);
            this.btn_LogIn.MouseLeave += new System.EventHandler(this.btn__MouseLeave);
            this.btn_LogIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn__MouseMove);
            // 
            // lbl_ErrorUsername
            // 
            this.lbl_ErrorUsername.AutoSize = true;
            this.lbl_ErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorUsername.Location = new System.Drawing.Point(201, 158);
            this.lbl_ErrorUsername.Name = "lbl_ErrorUsername";
            this.lbl_ErrorUsername.Size = new System.Drawing.Size(165, 20);
            this.lbl_ErrorUsername.TabIndex = 157;
            this.lbl_ErrorUsername.Text = "Enter Vaild Username";
            this.lbl_ErrorUsername.Visible = false;
            // 
            // asterix_Usrrname
            // 
            this.asterix_Usrrname.AutoSize = true;
            this.asterix_Usrrname.BackColor = System.Drawing.Color.Transparent;
            this.asterix_Usrrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Usrrname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Usrrname.Location = new System.Drawing.Point(503, 114);
            this.asterix_Usrrname.Name = "asterix_Usrrname";
            this.asterix_Usrrname.Size = new System.Drawing.Size(27, 36);
            this.asterix_Usrrname.TabIndex = 156;
            this.asterix_Usrrname.Text = "*";
            // 
            // lbl_ErrorPassword
            // 
            this.lbl_ErrorPassword.AutoSize = true;
            this.lbl_ErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPassword.Location = new System.Drawing.Point(201, 248);
            this.lbl_ErrorPassword.Name = "lbl_ErrorPassword";
            this.lbl_ErrorPassword.Size = new System.Drawing.Size(160, 20);
            this.lbl_ErrorPassword.TabIndex = 159;
            this.lbl_ErrorPassword.Text = "Enter Vaild Password";
            this.lbl_ErrorPassword.Visible = false;
            // 
            // asterix_Password
            // 
            this.asterix_Password.AutoSize = true;
            this.asterix_Password.BackColor = System.Drawing.Color.Transparent;
            this.asterix_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Password.Location = new System.Drawing.Point(503, 207);
            this.asterix_Password.Name = "asterix_Password";
            this.asterix_Password.Size = new System.Drawing.Size(27, 36);
            this.asterix_Password.TabIndex = 158;
            this.asterix_Password.Text = "*";
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.BackColor = System.Drawing.Color.Transparent;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(178, 467);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 160;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.Blue;
            this.btn_Admin.Location = new System.Drawing.Point(149, 271);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(304, 87);
            this.btn_Admin.TabIndex = 161;
            this.btn_Admin.Text = "Log In as Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Visible = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Blue;
            this.btn_Close.Location = new System.Drawing.Point(322, 364);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(217, 87);
            this.btn_Close.TabIndex = 162;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.Enter += new System.EventHandler(this.btn__Enter);
            this.btn_Close.Leave += new System.EventHandler(this.btn__Leave);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn__MouseLeave);
            this.btn_Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn__MouseMove);
            // 
            // Form_EmployeeAuthentication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Project_Car.Properties.Resources.Cars5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 512);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_ErrorPassword);
            this.Controls.Add(this.asterix_Password);
            this.Controls.Add(this.lbl_ErrorUsername);
            this.Controls.Add(this.asterix_Usrrname);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_EmployeeAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_ErrorUsername;
        private System.Windows.Forms.Label asterix_Usrrname;
        private System.Windows.Forms.Label lbl_ErrorPassword;
        private System.Windows.Forms.Label asterix_Password;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Close;
    }
}