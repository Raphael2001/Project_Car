namespace Project_Car.UI
{
   public partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.pnl_Options = new System.Windows.Forms.Panel();
            this.btn_AddOns = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Salary = new System.Windows.Forms.Button();
            this.btn_Design = new System.Windows.Forms.Button();
            this.btn_CarExtra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Cur = new System.Windows.Forms.Panel();
            this.btn_Role = new System.Windows.Forms.Button();
            this.btn_Cars = new System.Windows.Forms.Button();
            this.btn_Password = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.pnl_Background = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Options.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Options
            // 
            this.pnl_Options.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_Options.Controls.Add(this.btn_AddOns);
            this.pnl_Options.Controls.Add(this.btn_Return);
            this.pnl_Options.Controls.Add(this.btn_Salary);
            this.pnl_Options.Controls.Add(this.btn_Design);
            this.pnl_Options.Controls.Add(this.btn_CarExtra);
            this.pnl_Options.Controls.Add(this.panel1);
            this.pnl_Options.Controls.Add(this.btn_Close);
            this.pnl_Options.Controls.Add(this.pnl_Cur);
            this.pnl_Options.Controls.Add(this.btn_Role);
            this.pnl_Options.Controls.Add(this.btn_Cars);
            this.pnl_Options.Controls.Add(this.btn_Password);
            this.pnl_Options.Controls.Add(this.btn_Order);
            this.pnl_Options.Controls.Add(this.btn_Employee);
            this.pnl_Options.Controls.Add(this.btn_Product);
            this.pnl_Options.Controls.Add(this.btn_Client);
            this.pnl_Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Options.Location = new System.Drawing.Point(0, 0);
            this.pnl_Options.Name = "pnl_Options";
            this.pnl_Options.Size = new System.Drawing.Size(236, 991);
            this.pnl_Options.TabIndex = 0;
            this.pnl_Options.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseDown);
            this.pnl_Options.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseMove);
            this.pnl_Options.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseUp);
            // 
            // btn_AddOns
            // 
            this.btn_AddOns.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddOns.FlatAppearance.BorderSize = 0;
            this.btn_AddOns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOns.ForeColor = System.Drawing.Color.White;
            this.btn_AddOns.Location = new System.Drawing.Point(3, 861);
            this.btn_AddOns.Name = "btn_AddOns";
            this.btn_AddOns.Size = new System.Drawing.Size(210, 53);
            this.btn_AddOns.TabIndex = 14;
            this.btn_AddOns.TabStop = false;
            this.btn_AddOns.Text = "Reports";
            this.btn_AddOns.UseVisualStyleBackColor = false;
            this.btn_AddOns.Click += new System.EventHandler(this.btn_AddOns_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.White;
            this.btn_Return.Location = new System.Drawing.Point(3, 790);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(210, 53);
            this.btn_Return.TabIndex = 13;
            this.btn_Return.TabStop = false;
            this.btn_Return.Text = "Return Car";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Salary
            // 
            this.btn_Salary.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Salary.FlatAppearance.BorderSize = 0;
            this.btn_Salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salary.ForeColor = System.Drawing.Color.White;
            this.btn_Salary.Location = new System.Drawing.Point(3, 719);
            this.btn_Salary.Name = "btn_Salary";
            this.btn_Salary.Size = new System.Drawing.Size(210, 53);
            this.btn_Salary.TabIndex = 12;
            this.btn_Salary.TabStop = false;
            this.btn_Salary.Text = "My Salary";
            this.btn_Salary.UseVisualStyleBackColor = false;
            this.btn_Salary.Click += new System.EventHandler(this.btn_Salary_Click);
            // 
            // btn_Design
            // 
            this.btn_Design.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Design.FlatAppearance.BorderSize = 0;
            this.btn_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Design.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Design.ForeColor = System.Drawing.Color.White;
            this.btn_Design.Location = new System.Drawing.Point(3, 648);
            this.btn_Design.Name = "btn_Design";
            this.btn_Design.Size = new System.Drawing.Size(210, 53);
            this.btn_Design.TabIndex = 11;
            this.btn_Design.TabStop = false;
            this.btn_Design.Text = "Car Design";
            this.btn_Design.UseVisualStyleBackColor = false;
            this.btn_Design.Click += new System.EventHandler(this.btn_Design_Click);
            // 
            // btn_CarExtra
            // 
            this.btn_CarExtra.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_CarExtra.FlatAppearance.BorderSize = 0;
            this.btn_CarExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CarExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarExtra.ForeColor = System.Drawing.Color.White;
            this.btn_CarExtra.Location = new System.Drawing.Point(3, 577);
            this.btn_CarExtra.Name = "btn_CarExtra";
            this.btn_CarExtra.Size = new System.Drawing.Size(210, 53);
            this.btn_CarExtra.TabIndex = 10;
            this.btn_CarExtra.TabStop = false;
            this.btn_CarExtra.Text = "Car Extra";
            this.btn_CarExtra.UseVisualStyleBackColor = false;
            this.btn_CarExtra.Click += new System.EventHandler(this.btn_CarExtra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.lbl_Company);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 53);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseUp);
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Company.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_Company.Location = new System.Drawing.Point(65, 7);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(108, 48);
            this.lbl_Company.TabIndex = 172;
            this.lbl_Company.Text = "NYM";
            this.lbl_Company.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseDown);
            this.lbl_Company.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseMove);
            this.lbl_Company.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Options_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(0, 926);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(236, 53);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.TabStop = false;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Cur
            // 
            this.pnl_Cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_Cur.Location = new System.Drawing.Point(219, 80);
            this.pnl_Cur.Name = "pnl_Cur";
            this.pnl_Cur.Size = new System.Drawing.Size(10, 53);
            this.pnl_Cur.TabIndex = 7;
            this.pnl_Cur.Visible = false;
            // 
            // btn_Role
            // 
            this.btn_Role.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Role.FlatAppearance.BorderSize = 0;
            this.btn_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Role.ForeColor = System.Drawing.Color.White;
            this.btn_Role.Location = new System.Drawing.Point(3, 506);
            this.btn_Role.Name = "btn_Role";
            this.btn_Role.Size = new System.Drawing.Size(210, 53);
            this.btn_Role.TabIndex = 6;
            this.btn_Role.TabStop = false;
            this.btn_Role.Text = "Role";
            this.btn_Role.UseVisualStyleBackColor = false;
            this.btn_Role.Click += new System.EventHandler(this.btn_Role_Click);
            // 
            // btn_Cars
            // 
            this.btn_Cars.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Cars.FlatAppearance.BorderSize = 0;
            this.btn_Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cars.ForeColor = System.Drawing.Color.White;
            this.btn_Cars.Location = new System.Drawing.Point(3, 435);
            this.btn_Cars.Name = "btn_Cars";
            this.btn_Cars.Size = new System.Drawing.Size(210, 53);
            this.btn_Cars.TabIndex = 5;
            this.btn_Cars.TabStop = false;
            this.btn_Cars.Text = "All Cars";
            this.btn_Cars.UseVisualStyleBackColor = false;
            this.btn_Cars.Click += new System.EventHandler(this.btn_Cars_Click);
            // 
            // btn_Password
            // 
            this.btn_Password.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Password.FlatAppearance.BorderSize = 0;
            this.btn_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Password.ForeColor = System.Drawing.Color.White;
            this.btn_Password.Location = new System.Drawing.Point(3, 364);
            this.btn_Password.Name = "btn_Password";
            this.btn_Password.Size = new System.Drawing.Size(210, 53);
            this.btn_Password.TabIndex = 4;
            this.btn_Password.TabStop = false;
            this.btn_Password.Text = "New Password";
            this.btn_Password.UseVisualStyleBackColor = false;
            this.btn_Password.Click += new System.EventHandler(this.btn_Password_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(3, 293);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(210, 53);
            this.btn_Order.TabIndex = 3;
            this.btn_Order.TabStop = false;
            this.btn_Order.Text = "New Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Employee.FlatAppearance.BorderSize = 0;
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Location = new System.Drawing.Point(3, 222);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(210, 53);
            this.btn_Employee.TabIndex = 2;
            this.btn_Employee.TabStop = false;
            this.btn_Employee.Text = "Employee";
            this.btn_Employee.UseVisualStyleBackColor = false;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Location = new System.Drawing.Point(3, 151);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(210, 53);
            this.btn_Product.TabIndex = 1;
            this.btn_Product.TabStop = false;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Client.FlatAppearance.BorderSize = 0;
            this.btn_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client.ForeColor = System.Drawing.Color.White;
            this.btn_Client.Location = new System.Drawing.Point(3, 80);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(210, 53);
            this.btn_Client.TabIndex = 0;
            this.btn_Client.TabStop = false;
            this.btn_Client.Text = "Client";
            this.btn_Client.UseVisualStyleBackColor = false;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // pnl_Background
            // 
            this.pnl_Background.BackgroundImage = global::Project_Car.Properties.Resources.Cars_Backgroud;
            this.pnl_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Background.Controls.Add(this.lbl_Name);
            this.pnl_Background.Controls.Add(this.lbl_HeadLine);
            this.pnl_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Background.Location = new System.Drawing.Point(236, 0);
            this.pnl_Background.Name = "pnl_Background";
            this.pnl_Background.Size = new System.Drawing.Size(1064, 991);
            this.pnl_Background.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_Name.Location = new System.Drawing.Point(270, 901);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(408, 58);
            this.lbl_Name.TabIndex = 173;
            this.lbl_Name.Text = "New York Motors";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadLine.ForeColor = System.Drawing.Color.Blue;
            this.lbl_HeadLine.Location = new System.Drawing.Point(337, 41);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(181, 58);
            this.lbl_HeadLine.TabIndex = 171;
            this.lbl_HeadLine.Text = "Hello...";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 991);
            this.Controls.Add(this.pnl_Background);
            this.Controls.Add(this.pnl_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.LocationChanged += new System.EventHandler(this.Form_Home_LocationChanged);
            this.pnl_Options.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Background.ResumeLayout(false);
            this.pnl_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_Options;
        public System.Windows.Forms.Button btn_Client;
        public System.Windows.Forms.Panel pnl_Background;
        public System.Windows.Forms.Button btn_Order;
        public System.Windows.Forms.Button btn_Employee;
        public System.Windows.Forms.Button btn_Product;
        public System.Windows.Forms.Button btn_Role;
        public System.Windows.Forms.Button btn_Cars;
        public System.Windows.Forms.Button btn_Password;
        public System.Windows.Forms.Panel pnl_Cur;
        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Label lbl_HeadLine;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_CarExtra;
        public System.Windows.Forms.Label lbl_Company;
        public System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_Design;
        public System.Windows.Forms.Button btn_Salary;
        public System.Windows.Forms.Button btn_Return;
        public System.Windows.Forms.Button btn_AddOns;
    }
}