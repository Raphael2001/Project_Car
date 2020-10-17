namespace Project_Car.UI
{
    partial class Form_OrderBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OrderBuy));
            this.tbc_Order = new System.Windows.Forms.TabControl();
            this.tp_OrderDetails = new System.Windows.Forms.TabPage();
            this.dtp_DateBuy = new System.Windows.Forms.DateTimePicker();
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.listbox_Orders = new System.Windows.Forms.ListBox();
            this.txt_Client = new System.Windows.Forms.Label();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.lbl_ErrorDateBuy = new System.Windows.Forms.Label();
            this.asterix_DateBuy = new System.Windows.Forms.Label();
            this.lbl_DateOrder = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tp_Client = new System.Windows.Forms.TabPage();
            this.lbl_HeadlineClient = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.Label();
            this.listbox_Clients = new System.Windows.Forms.ListBox();
            this.btn_FilterClient = new System.Windows.Forms.Button();
            this.lbl_IdtxtClient = new System.Windows.Forms.Label();
            this.lbl_ClientId = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.tp_Car = new System.Windows.Forms.TabPage();
            this.lbl_HeadlineCar = new System.Windows.Forms.Label();
            this.btn_FilterCar = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.Label();
            this.txt_LicenseNumber = new System.Windows.Forms.Label();
            this.txt_Type = new System.Windows.Forms.Label();
            this.lbl_IdtxtCar = new System.Windows.Forms.Label();
            this.lbl_IdCar = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_LicenseNumber = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.listbox_Cars = new System.Windows.Forms.ListBox();
            this.tp_CarExtra = new System.Windows.Forms.TabPage();
            this.lbl_HeadlineExtra = new System.Windows.Forms.Label();
            this.btn_FilterExtra = new System.Windows.Forms.Button();
            this.listbox_InOrder = new System.Windows.Forms.ListBox();
            this.listbox_Potential = new System.Windows.Forms.ListBox();
            this.tp_Design = new System.Windows.Forms.TabPage();
            this.lbl_HeadlineDesign = new System.Windows.Forms.Label();
            this.txt_BodyDesign = new System.Windows.Forms.Label();
            this.txt_ColorType = new System.Windows.Forms.Label();
            this.txt_CarColor = new System.Windows.Forms.Label();
            this.lbl_IdtxtDesign = new System.Windows.Forms.Label();
            this.lbl_IdDesign = new System.Windows.Forms.Label();
            this.lbl_BodyDesign = new System.Windows.Forms.Label();
            this.lbl_ColorType = new System.Windows.Forms.Label();
            this.lbl_CarColor = new System.Windows.Forms.Label();
            this.btn_FilterDesign = new System.Windows.Forms.Button();
            this.listbox_Designs = new System.Windows.Forms.ListBox();
            this.pnl_Options = new System.Windows.Forms.Panel();
            this.btn_Design = new System.Windows.Forms.Button();
            this.btn_Extra = new System.Windows.Forms.Button();
            this.btn_Car = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.pnl_Cur = new System.Windows.Forms.Panel();
            this.btn_Details = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.tbc_Order.SuspendLayout();
            this.tp_OrderDetails.SuspendLayout();
            this.tp_Client.SuspendLayout();
            this.tp_Car.SuspendLayout();
            this.tp_CarExtra.SuspendLayout();
            this.tp_Design.SuspendLayout();
            this.pnl_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Order
            // 
            this.tbc_Order.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbc_Order.Controls.Add(this.tp_OrderDetails);
            this.tbc_Order.Controls.Add(this.tp_Client);
            this.tbc_Order.Controls.Add(this.tp_Car);
            this.tbc_Order.Controls.Add(this.tp_CarExtra);
            this.tbc_Order.Controls.Add(this.tp_Design);
            this.tbc_Order.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbc_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Order.Location = new System.Drawing.Point(0, 83);
            this.tbc_Order.Name = "tbc_Order";
            this.tbc_Order.SelectedIndex = 0;
            this.tbc_Order.Size = new System.Drawing.Size(1312, 731);
            this.tbc_Order.TabIndex = 0;
            // 
            // tp_OrderDetails
            // 
            this.tp_OrderDetails.BackColor = System.Drawing.Color.Aquamarine;
            this.tp_OrderDetails.Controls.Add(this.dtp_DateBuy);
            this.tp_OrderDetails.Controls.Add(this.Mady_by);
            this.tp_OrderDetails.Controls.Add(this.btn_Clear);
            this.tp_OrderDetails.Controls.Add(this.btn_Filter);
            this.tp_OrderDetails.Controls.Add(this.listbox_Orders);
            this.tp_OrderDetails.Controls.Add(this.txt_Client);
            this.tp_OrderDetails.Controls.Add(this.lbl_Client);
            this.tp_OrderDetails.Controls.Add(this.txt_Comment);
            this.tp_OrderDetails.Controls.Add(this.lbl_Comment);
            this.tp_OrderDetails.Controls.Add(this.lbl_ErrorDateBuy);
            this.tp_OrderDetails.Controls.Add(this.asterix_DateBuy);
            this.tp_OrderDetails.Controls.Add(this.lbl_DateOrder);
            this.tp_OrderDetails.Controls.Add(this.lbl_Idtxt);
            this.tp_OrderDetails.Controls.Add(this.lbl_id);
            this.tp_OrderDetails.Location = new System.Drawing.Point(4, 41);
            this.tp_OrderDetails.Name = "tp_OrderDetails";
            this.tp_OrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tp_OrderDetails.Size = new System.Drawing.Size(1304, 686);
            this.tp_OrderDetails.TabIndex = 1;
            this.tp_OrderDetails.Text = "Order details";
            // 
            // dtp_DateBuy
            // 
            this.dtp_DateBuy.Location = new System.Drawing.Point(9, 163);
            this.dtp_DateBuy.Name = "dtp_DateBuy";
            this.dtp_DateBuy.ShowCheckBox = true;
            this.dtp_DateBuy.Size = new System.Drawing.Size(441, 35);
            this.dtp_DateBuy.TabIndex = 246;
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(421, 636);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 244;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(57, 559);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 145;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(683, 2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(614, 57);
            this.btn_Filter.TabIndex = 143;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // listbox_Orders
            // 
            this.listbox_Orders.FormattingEnabled = true;
            this.listbox_Orders.ItemHeight = 29;
            this.listbox_Orders.Location = new System.Drawing.Point(684, 65);
            this.listbox_Orders.Name = "listbox_Orders";
            this.listbox_Orders.Size = new System.Drawing.Size(614, 497);
            this.listbox_Orders.TabIndex = 142;
            this.listbox_Orders.DoubleClick += new System.EventHandler(this.listbox_Orders_DoubleClick);
            // 
            // txt_Client
            // 
            this.txt_Client.AutoSize = true;
            this.txt_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Client.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Client.Location = new System.Drawing.Point(3, 456);
            this.txt_Client.Name = "txt_Client";
            this.txt_Client.Size = new System.Drawing.Size(0, 36);
            this.txt_Client.TabIndex = 141;
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Client.Location = new System.Drawing.Point(3, 402);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(91, 36);
            this.lbl_Client.TabIndex = 140;
            this.lbl_Client.Text = "Client";
            // 
            // txt_Comment
            // 
            this.txt_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Comment.Location = new System.Drawing.Point(12, 330);
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(376, 41);
            this.txt_Comment.TabIndex = 138;
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comment.Location = new System.Drawing.Point(6, 275);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(140, 36);
            this.lbl_Comment.TabIndex = 139;
            this.lbl_Comment.Text = "Comment";
            // 
            // lbl_ErrorDateBuy
            // 
            this.lbl_ErrorDateBuy.AutoSize = true;
            this.lbl_ErrorDateBuy.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorDateBuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorDateBuy.Location = new System.Drawing.Point(8, 224);
            this.lbl_ErrorDateBuy.Name = "lbl_ErrorDateBuy";
            this.lbl_ErrorDateBuy.Size = new System.Drawing.Size(221, 29);
            this.lbl_ErrorDateBuy.TabIndex = 137;
            this.lbl_ErrorDateBuy.Text = "Enter Date of Order";
            this.lbl_ErrorDateBuy.Visible = false;
            // 
            // asterix_DateBuy
            // 
            this.asterix_DateBuy.AutoSize = true;
            this.asterix_DateBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_DateBuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_DateBuy.Location = new System.Drawing.Point(456, 162);
            this.asterix_DateBuy.Name = "asterix_DateBuy";
            this.asterix_DateBuy.Size = new System.Drawing.Size(27, 36);
            this.asterix_DateBuy.TabIndex = 136;
            this.asterix_DateBuy.Text = "*";
            // 
            // lbl_DateOrder
            // 
            this.lbl_DateOrder.AutoSize = true;
            this.lbl_DateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_DateOrder.Location = new System.Drawing.Point(6, 106);
            this.lbl_DateOrder.Name = "lbl_DateOrder";
            this.lbl_DateOrder.Size = new System.Drawing.Size(192, 36);
            this.lbl_DateOrder.TabIndex = 135;
            this.lbl_DateOrder.Text = "Date of Order";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(65, 39);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 131;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(3, 39);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 130;
            this.lbl_id.Text = "ID";
            // 
            // tp_Client
            // 
            this.tp_Client.BackColor = System.Drawing.Color.Aquamarine;
            this.tp_Client.Controls.Add(this.lbl_HeadlineClient);
            this.tp_Client.Controls.Add(this.txt_Email);
            this.tp_Client.Controls.Add(this.txt_Address);
            this.tp_Client.Controls.Add(this.txt_PhoneNumber);
            this.tp_Client.Controls.Add(this.lbl_Address);
            this.tp_Client.Controls.Add(this.txt_FullName);
            this.tp_Client.Controls.Add(this.listbox_Clients);
            this.tp_Client.Controls.Add(this.btn_FilterClient);
            this.tp_Client.Controls.Add(this.lbl_IdtxtClient);
            this.tp_Client.Controls.Add(this.lbl_ClientId);
            this.tp_Client.Controls.Add(this.lbl_Email);
            this.tp_Client.Controls.Add(this.lbl_PhoneNumber);
            this.tp_Client.Controls.Add(this.lbl_FullName);
            this.tp_Client.Location = new System.Drawing.Point(4, 41);
            this.tp_Client.Name = "tp_Client";
            this.tp_Client.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Client.Size = new System.Drawing.Size(1304, 686);
            this.tp_Client.TabIndex = 2;
            this.tp_Client.Text = "Client to Order";
            // 
            // lbl_HeadlineClient
            // 
            this.lbl_HeadlineClient.AutoSize = true;
            this.lbl_HeadlineClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadlineClient.Location = new System.Drawing.Point(363, 16);
            this.lbl_HeadlineClient.Name = "lbl_HeadlineClient";
            this.lbl_HeadlineClient.Size = new System.Drawing.Size(122, 46);
            this.lbl_HeadlineClient.TabIndex = 148;
            this.lbl_HeadlineClient.Text = "Client";
            this.toolTip1.SetToolTip(this.lbl_HeadlineClient, "Click to add a new Client");
            this.lbl_HeadlineClient.Click += new System.EventHandler(this.lbl_HeadlineClient_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.AutoSize = true;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(22, 459);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(0, 36);
            this.txt_Email.TabIndex = 146;
            // 
            // txt_Address
            // 
            this.txt_Address.AutoSize = true;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Address.Location = new System.Drawing.Point(22, 593);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(0, 36);
            this.txt_Address.TabIndex = 147;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.AutoSize = true;
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(22, 319);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(0, 36);
            this.txt_PhoneNumber.TabIndex = 145;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Address.Location = new System.Drawing.Point(3, 543);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(126, 36);
            this.lbl_Address.TabIndex = 146;
            this.lbl_Address.Text = "Address";
            // 
            // txt_FullName
            // 
            this.txt_FullName.AutoSize = true;
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FullName.Location = new System.Drawing.Point(22, 177);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(0, 36);
            this.txt_FullName.TabIndex = 144;
            // 
            // listbox_Clients
            // 
            this.listbox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Clients.FormattingEnabled = true;
            this.listbox_Clients.ItemHeight = 36;
            this.listbox_Clients.Location = new System.Drawing.Point(687, 68);
            this.listbox_Clients.Name = "listbox_Clients";
            this.listbox_Clients.Size = new System.Drawing.Size(609, 544);
            this.listbox_Clients.TabIndex = 143;
            this.listbox_Clients.DoubleClick += new System.EventHandler(this.listbox_Clients_DoubleClick);
            // 
            // btn_FilterClient
            // 
            this.btn_FilterClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_FilterClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_FilterClient.Location = new System.Drawing.Point(687, 5);
            this.btn_FilterClient.Name = "btn_FilterClient";
            this.btn_FilterClient.Size = new System.Drawing.Size(609, 57);
            this.btn_FilterClient.TabIndex = 139;
            this.btn_FilterClient.Text = "Filter By";
            this.btn_FilterClient.UseVisualStyleBackColor = true;
            this.btn_FilterClient.Click += new System.EventHandler(this.btn_FilterClient_Click);
            // 
            // lbl_IdtxtClient
            // 
            this.lbl_IdtxtClient.AutoSize = true;
            this.lbl_IdtxtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdtxtClient.Location = new System.Drawing.Point(120, 43);
            this.lbl_IdtxtClient.Name = "lbl_IdtxtClient";
            this.lbl_IdtxtClient.Size = new System.Drawing.Size(32, 36);
            this.lbl_IdtxtClient.TabIndex = 138;
            this.lbl_IdtxtClient.Text = "0";
            // 
            // lbl_ClientId
            // 
            this.lbl_ClientId.AutoSize = true;
            this.lbl_ClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientId.Location = new System.Drawing.Point(3, 43);
            this.lbl_ClientId.Name = "lbl_ClientId";
            this.lbl_ClientId.Size = new System.Drawing.Size(44, 36);
            this.lbl_ClientId.TabIndex = 137;
            this.lbl_ClientId.Text = "ID";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(3, 401);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(100, 36);
            this.lbl_Email.TabIndex = 136;
            this.lbl_Email.Text = "E-Mail";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(3, 257);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(215, 36);
            this.lbl_PhoneNumber.TabIndex = 135;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FullName.Location = new System.Drawing.Point(3, 114);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(149, 36);
            this.lbl_FullName.TabIndex = 134;
            this.lbl_FullName.Text = "Full Name";
            // 
            // tp_Car
            // 
            this.tp_Car.BackColor = System.Drawing.Color.Aquamarine;
            this.tp_Car.Controls.Add(this.lbl_HeadlineCar);
            this.tp_Car.Controls.Add(this.btn_FilterCar);
            this.tp_Car.Controls.Add(this.txt_Price);
            this.tp_Car.Controls.Add(this.txt_LicenseNumber);
            this.tp_Car.Controls.Add(this.txt_Type);
            this.tp_Car.Controls.Add(this.lbl_IdtxtCar);
            this.tp_Car.Controls.Add(this.lbl_IdCar);
            this.tp_Car.Controls.Add(this.lbl_Price);
            this.tp_Car.Controls.Add(this.lbl_LicenseNumber);
            this.tp_Car.Controls.Add(this.lbl_Model);
            this.tp_Car.Controls.Add(this.listbox_Cars);
            this.tp_Car.Location = new System.Drawing.Point(4, 41);
            this.tp_Car.Name = "tp_Car";
            this.tp_Car.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Car.Size = new System.Drawing.Size(1304, 686);
            this.tp_Car.TabIndex = 3;
            this.tp_Car.Text = "Car to Order";
            // 
            // lbl_HeadlineCar
            // 
            this.lbl_HeadlineCar.AutoSize = true;
            this.lbl_HeadlineCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadlineCar.Location = new System.Drawing.Point(348, 23);
            this.lbl_HeadlineCar.Name = "lbl_HeadlineCar";
            this.lbl_HeadlineCar.Size = new System.Drawing.Size(84, 46);
            this.lbl_HeadlineCar.TabIndex = 157;
            this.lbl_HeadlineCar.Text = "Car";
            this.toolTip1.SetToolTip(this.lbl_HeadlineCar, "Click to add a new Car");
            this.lbl_HeadlineCar.Click += new System.EventHandler(this.lbl_HeadlineCar_Click);
            // 
            // btn_FilterCar
            // 
            this.btn_FilterCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_FilterCar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_FilterCar.Location = new System.Drawing.Point(682, 23);
            this.btn_FilterCar.Name = "btn_FilterCar";
            this.btn_FilterCar.Size = new System.Drawing.Size(614, 57);
            this.btn_FilterCar.TabIndex = 156;
            this.btn_FilterCar.Text = "Filter By";
            this.btn_FilterCar.UseVisualStyleBackColor = true;
            this.btn_FilterCar.Click += new System.EventHandler(this.btn_FilterCar_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.AutoSize = true;
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(18, 451);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(0, 36);
            this.txt_Price.TabIndex = 155;
            // 
            // txt_LicenseNumber
            // 
            this.txt_LicenseNumber.AutoSize = true;
            this.txt_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LicenseNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_LicenseNumber.Location = new System.Drawing.Point(18, 320);
            this.txt_LicenseNumber.Name = "txt_LicenseNumber";
            this.txt_LicenseNumber.Size = new System.Drawing.Size(0, 36);
            this.txt_LicenseNumber.TabIndex = 154;
            // 
            // txt_Type
            // 
            this.txt_Type.AutoSize = true;
            this.txt_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Type.Location = new System.Drawing.Point(18, 181);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(0, 36);
            this.txt_Type.TabIndex = 153;
            // 
            // lbl_IdtxtCar
            // 
            this.lbl_IdtxtCar.AutoSize = true;
            this.lbl_IdtxtCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdtxtCar.Location = new System.Drawing.Point(94, 52);
            this.lbl_IdtxtCar.Name = "lbl_IdtxtCar";
            this.lbl_IdtxtCar.Size = new System.Drawing.Size(32, 36);
            this.lbl_IdtxtCar.TabIndex = 152;
            this.lbl_IdtxtCar.Text = "0";
            // 
            // lbl_IdCar
            // 
            this.lbl_IdCar.AutoSize = true;
            this.lbl_IdCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCar.Location = new System.Drawing.Point(4, 52);
            this.lbl_IdCar.Name = "lbl_IdCar";
            this.lbl_IdCar.Size = new System.Drawing.Size(44, 36);
            this.lbl_IdCar.TabIndex = 151;
            this.lbl_IdCar.Text = "ID";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(6, 390);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(83, 36);
            this.lbl_Price.TabIndex = 150;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_LicenseNumber
            // 
            this.lbl_LicenseNumber.AutoSize = true;
            this.lbl_LicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LicenseNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LicenseNumber.Location = new System.Drawing.Point(4, 253);
            this.lbl_LicenseNumber.Name = "lbl_LicenseNumber";
            this.lbl_LicenseNumber.Size = new System.Drawing.Size(231, 36);
            this.lbl_LicenseNumber.TabIndex = 149;
            this.lbl_LicenseNumber.Text = "License Number";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Model.Location = new System.Drawing.Point(4, 124);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(126, 36);
            this.lbl_Model.TabIndex = 148;
            this.lbl_Model.Text = "Car type";
            // 
            // listbox_Cars
            // 
            this.listbox_Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Cars.FormattingEnabled = true;
            this.listbox_Cars.ItemHeight = 36;
            this.listbox_Cars.Location = new System.Drawing.Point(685, 86);
            this.listbox_Cars.Name = "listbox_Cars";
            this.listbox_Cars.Size = new System.Drawing.Size(611, 544);
            this.listbox_Cars.TabIndex = 144;
            this.listbox_Cars.DoubleClick += new System.EventHandler(this.listbox_Cars_DoubleClick);
            // 
            // tp_CarExtra
            // 
            this.tp_CarExtra.BackColor = System.Drawing.Color.Aquamarine;
            this.tp_CarExtra.Controls.Add(this.lbl_HeadlineExtra);
            this.tp_CarExtra.Controls.Add(this.btn_FilterExtra);
            this.tp_CarExtra.Controls.Add(this.listbox_InOrder);
            this.tp_CarExtra.Controls.Add(this.listbox_Potential);
            this.tp_CarExtra.Location = new System.Drawing.Point(4, 41);
            this.tp_CarExtra.Name = "tp_CarExtra";
            this.tp_CarExtra.Padding = new System.Windows.Forms.Padding(3);
            this.tp_CarExtra.Size = new System.Drawing.Size(1304, 686);
            this.tp_CarExtra.TabIndex = 4;
            this.tp_CarExtra.Text = "Car Extra";
            // 
            // lbl_HeadlineExtra
            // 
            this.lbl_HeadlineExtra.AutoSize = true;
            this.lbl_HeadlineExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadlineExtra.Location = new System.Drawing.Point(507, 23);
            this.lbl_HeadlineExtra.Name = "lbl_HeadlineExtra";
            this.lbl_HeadlineExtra.Size = new System.Drawing.Size(189, 46);
            this.lbl_HeadlineExtra.TabIndex = 158;
            this.lbl_HeadlineExtra.Text = "Car Extra";
            this.toolTip1.SetToolTip(this.lbl_HeadlineExtra, "Click to add a new Car Extra");
            this.lbl_HeadlineExtra.Click += new System.EventHandler(this.lbl_HeadlineExtra_Click);
            // 
            // btn_FilterExtra
            // 
            this.btn_FilterExtra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_FilterExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_FilterExtra.Location = new System.Drawing.Point(23, 102);
            this.btn_FilterExtra.Name = "btn_FilterExtra";
            this.btn_FilterExtra.Size = new System.Drawing.Size(552, 57);
            this.btn_FilterExtra.TabIndex = 157;
            this.btn_FilterExtra.Text = "Filter By";
            this.btn_FilterExtra.UseVisualStyleBackColor = true;
            this.btn_FilterExtra.Click += new System.EventHandler(this.btn_FilterExtra_Click);
            // 
            // listbox_InOrder
            // 
            this.listbox_InOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_InOrder.FormattingEnabled = true;
            this.listbox_InOrder.HorizontalScrollbar = true;
            this.listbox_InOrder.ItemHeight = 36;
            this.listbox_InOrder.Location = new System.Drawing.Point(694, 165);
            this.listbox_InOrder.Name = "listbox_InOrder";
            this.listbox_InOrder.Size = new System.Drawing.Size(569, 508);
            this.listbox_InOrder.TabIndex = 145;
            this.listbox_InOrder.DoubleClick += new System.EventHandler(this.listbox_InOrder_DoubleClick);
            // 
            // listbox_Potential
            // 
            this.listbox_Potential.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Potential.FormattingEnabled = true;
            this.listbox_Potential.HorizontalScrollbar = true;
            this.listbox_Potential.ItemHeight = 36;
            this.listbox_Potential.Location = new System.Drawing.Point(23, 165);
            this.listbox_Potential.Name = "listbox_Potential";
            this.listbox_Potential.Size = new System.Drawing.Size(552, 508);
            this.listbox_Potential.TabIndex = 144;
            this.listbox_Potential.DoubleClick += new System.EventHandler(this.listbox_Potential_DoubleClick);
            // 
            // tp_Design
            // 
            this.tp_Design.BackColor = System.Drawing.Color.Aquamarine;
            this.tp_Design.Controls.Add(this.btn_Save);
            this.tp_Design.Controls.Add(this.lbl_HeadlineDesign);
            this.tp_Design.Controls.Add(this.txt_BodyDesign);
            this.tp_Design.Controls.Add(this.txt_ColorType);
            this.tp_Design.Controls.Add(this.txt_CarColor);
            this.tp_Design.Controls.Add(this.lbl_IdtxtDesign);
            this.tp_Design.Controls.Add(this.lbl_IdDesign);
            this.tp_Design.Controls.Add(this.lbl_BodyDesign);
            this.tp_Design.Controls.Add(this.lbl_ColorType);
            this.tp_Design.Controls.Add(this.lbl_CarColor);
            this.tp_Design.Controls.Add(this.btn_FilterDesign);
            this.tp_Design.Controls.Add(this.listbox_Designs);
            this.tp_Design.Location = new System.Drawing.Point(4, 41);
            this.tp_Design.Name = "tp_Design";
            this.tp_Design.Size = new System.Drawing.Size(1304, 686);
            this.tp_Design.TabIndex = 5;
            this.tp_Design.Text = "Car Design";
            // 
            // lbl_HeadlineDesign
            // 
            this.lbl_HeadlineDesign.AutoSize = true;
            this.lbl_HeadlineDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadlineDesign.Location = new System.Drawing.Point(319, 30);
            this.lbl_HeadlineDesign.Name = "lbl_HeadlineDesign";
            this.lbl_HeadlineDesign.Size = new System.Drawing.Size(219, 46);
            this.lbl_HeadlineDesign.TabIndex = 166;
            this.lbl_HeadlineDesign.Text = "Car Design";
            this.toolTip1.SetToolTip(this.lbl_HeadlineDesign, "Click to add a new Car Design");
            this.lbl_HeadlineDesign.Click += new System.EventHandler(this.lbl_HeadlineDesign_Click);
            // 
            // txt_BodyDesign
            // 
            this.txt_BodyDesign.AutoSize = true;
            this.txt_BodyDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BodyDesign.Location = new System.Drawing.Point(20, 503);
            this.txt_BodyDesign.Name = "txt_BodyDesign";
            this.txt_BodyDesign.Size = new System.Drawing.Size(0, 36);
            this.txt_BodyDesign.TabIndex = 165;
            // 
            // txt_ColorType
            // 
            this.txt_ColorType.AutoSize = true;
            this.txt_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ColorType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ColorType.Location = new System.Drawing.Point(20, 370);
            this.txt_ColorType.Name = "txt_ColorType";
            this.txt_ColorType.Size = new System.Drawing.Size(0, 36);
            this.txt_ColorType.TabIndex = 164;
            // 
            // txt_CarColor
            // 
            this.txt_CarColor.AutoSize = true;
            this.txt_CarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CarColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_CarColor.Location = new System.Drawing.Point(20, 231);
            this.txt_CarColor.Name = "txt_CarColor";
            this.txt_CarColor.Size = new System.Drawing.Size(0, 36);
            this.txt_CarColor.TabIndex = 163;
            // 
            // lbl_IdtxtDesign
            // 
            this.lbl_IdtxtDesign.AutoSize = true;
            this.lbl_IdtxtDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdtxtDesign.Location = new System.Drawing.Point(125, 98);
            this.lbl_IdtxtDesign.Name = "lbl_IdtxtDesign";
            this.lbl_IdtxtDesign.Size = new System.Drawing.Size(32, 36);
            this.lbl_IdtxtDesign.TabIndex = 162;
            this.lbl_IdtxtDesign.Text = "0";
            // 
            // lbl_IdDesign
            // 
            this.lbl_IdDesign.AutoSize = true;
            this.lbl_IdDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdDesign.Location = new System.Drawing.Point(8, 98);
            this.lbl_IdDesign.Name = "lbl_IdDesign";
            this.lbl_IdDesign.Size = new System.Drawing.Size(44, 36);
            this.lbl_IdDesign.TabIndex = 161;
            this.lbl_IdDesign.Text = "ID";
            // 
            // lbl_BodyDesign
            // 
            this.lbl_BodyDesign.AutoSize = true;
            this.lbl_BodyDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BodyDesign.Location = new System.Drawing.Point(8, 440);
            this.lbl_BodyDesign.Name = "lbl_BodyDesign";
            this.lbl_BodyDesign.Size = new System.Drawing.Size(185, 36);
            this.lbl_BodyDesign.TabIndex = 160;
            this.lbl_BodyDesign.Text = "Body Design";
            // 
            // lbl_ColorType
            // 
            this.lbl_ColorType.AutoSize = true;
            this.lbl_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ColorType.Location = new System.Drawing.Point(8, 301);
            this.lbl_ColorType.Name = "lbl_ColorType";
            this.lbl_ColorType.Size = new System.Drawing.Size(161, 36);
            this.lbl_ColorType.TabIndex = 159;
            this.lbl_ColorType.Text = "Color Type";
            // 
            // lbl_CarColor
            // 
            this.lbl_CarColor.AutoSize = true;
            this.lbl_CarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_CarColor.Location = new System.Drawing.Point(8, 170);
            this.lbl_CarColor.Name = "lbl_CarColor";
            this.lbl_CarColor.Size = new System.Drawing.Size(142, 36);
            this.lbl_CarColor.TabIndex = 158;
            this.lbl_CarColor.Text = "Car Color";
            // 
            // btn_FilterDesign
            // 
            this.btn_FilterDesign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_FilterDesign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_FilterDesign.Location = new System.Drawing.Point(682, 19);
            this.btn_FilterDesign.Name = "btn_FilterDesign";
            this.btn_FilterDesign.Size = new System.Drawing.Size(614, 57);
            this.btn_FilterDesign.TabIndex = 157;
            this.btn_FilterDesign.Text = "Filter By";
            this.btn_FilterDesign.UseVisualStyleBackColor = true;
            this.btn_FilterDesign.Click += new System.EventHandler(this.btn_FilterDesign_Click);
            // 
            // listbox_Designs
            // 
            this.listbox_Designs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Designs.FormattingEnabled = true;
            this.listbox_Designs.HorizontalScrollbar = true;
            this.listbox_Designs.ItemHeight = 36;
            this.listbox_Designs.Location = new System.Drawing.Point(685, 82);
            this.listbox_Designs.Name = "listbox_Designs";
            this.listbox_Designs.Size = new System.Drawing.Size(611, 544);
            this.listbox_Designs.TabIndex = 145;
            this.listbox_Designs.DoubleClick += new System.EventHandler(this.listbox_Designs_DoubleClick);
            // 
            // pnl_Options
            // 
            this.pnl_Options.Controls.Add(this.btn_Design);
            this.pnl_Options.Controls.Add(this.btn_Extra);
            this.pnl_Options.Controls.Add(this.btn_Car);
            this.pnl_Options.Controls.Add(this.btn_Client);
            this.pnl_Options.Controls.Add(this.pnl_Cur);
            this.pnl_Options.Controls.Add(this.btn_Details);
            this.pnl_Options.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Options.Location = new System.Drawing.Point(0, 0);
            this.pnl_Options.Name = "pnl_Options";
            this.pnl_Options.Size = new System.Drawing.Size(1312, 89);
            this.pnl_Options.TabIndex = 1;
            // 
            // btn_Design
            // 
            this.btn_Design.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Design.FlatAppearance.BorderSize = 0;
            this.btn_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Design.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Design.ForeColor = System.Drawing.Color.White;
            this.btn_Design.Location = new System.Drawing.Point(716, 3);
            this.btn_Design.Name = "btn_Design";
            this.btn_Design.Size = new System.Drawing.Size(162, 41);
            this.btn_Design.TabIndex = 7;
            this.btn_Design.TabStop = false;
            this.btn_Design.Text = "Car Design";
            this.btn_Design.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Design.UseVisualStyleBackColor = false;
            this.btn_Design.Click += new System.EventHandler(this.btn_Design_Click);
            // 
            // btn_Extra
            // 
            this.btn_Extra.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Extra.FlatAppearance.BorderSize = 0;
            this.btn_Extra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Extra.ForeColor = System.Drawing.Color.White;
            this.btn_Extra.Location = new System.Drawing.Point(538, 3);
            this.btn_Extra.Name = "btn_Extra";
            this.btn_Extra.Size = new System.Drawing.Size(162, 41);
            this.btn_Extra.TabIndex = 6;
            this.btn_Extra.TabStop = false;
            this.btn_Extra.Text = "Car Extra";
            this.btn_Extra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Extra.UseVisualStyleBackColor = false;
            this.btn_Extra.Click += new System.EventHandler(this.btn_Extra_Click);
            // 
            // btn_Car
            // 
            this.btn_Car.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Car.FlatAppearance.BorderSize = 0;
            this.btn_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Car.ForeColor = System.Drawing.Color.White;
            this.btn_Car.Location = new System.Drawing.Point(360, 3);
            this.btn_Car.Name = "btn_Car";
            this.btn_Car.Size = new System.Drawing.Size(162, 41);
            this.btn_Car.TabIndex = 5;
            this.btn_Car.TabStop = false;
            this.btn_Car.Text = "Car To Order";
            this.btn_Car.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Car.UseVisualStyleBackColor = false;
            this.btn_Car.Click += new System.EventHandler(this.btn_Car_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Client.FlatAppearance.BorderSize = 0;
            this.btn_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client.ForeColor = System.Drawing.Color.White;
            this.btn_Client.Location = new System.Drawing.Point(182, 3);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(162, 41);
            this.btn_Client.TabIndex = 4;
            this.btn_Client.TabStop = false;
            this.btn_Client.Text = "Client to Order";
            this.btn_Client.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Client.UseVisualStyleBackColor = false;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // pnl_Cur
            // 
            this.pnl_Cur.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_Cur.Location = new System.Drawing.Point(4, 50);
            this.pnl_Cur.Name = "pnl_Cur";
            this.pnl_Cur.Size = new System.Drawing.Size(162, 20);
            this.pnl_Cur.TabIndex = 3;
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Details.FlatAppearance.BorderSize = 0;
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Details.ForeColor = System.Drawing.Color.White;
            this.btn_Details.Location = new System.Drawing.Point(4, 3);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(162, 41);
            this.btn_Details.TabIndex = 2;
            this.btn_Details.TabStop = false;
            this.btn_Details.Text = "Order Details";
            this.btn_Details.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(389, 598);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(231, 57);
            this.btn_Save.TabIndex = 167;
            this.btn_Save.Text = "Save Order";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form_OrderBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.pnl_Options);
            this.Controls.Add(this.tbc_Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OrderBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderBuy";
            this.tbc_Order.ResumeLayout(false);
            this.tp_OrderDetails.ResumeLayout(false);
            this.tp_OrderDetails.PerformLayout();
            this.tp_Client.ResumeLayout(false);
            this.tp_Client.PerformLayout();
            this.tp_Car.ResumeLayout(false);
            this.tp_Car.PerformLayout();
            this.tp_CarExtra.ResumeLayout(false);
            this.tp_CarExtra.PerformLayout();
            this.tp_Design.ResumeLayout(false);
            this.tp_Design.PerformLayout();
            this.pnl_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Order;
        private System.Windows.Forms.TabPage tp_OrderDetails;
        private System.Windows.Forms.TabPage tp_Client;
        private System.Windows.Forms.TabPage tp_Car;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ErrorDateBuy;
        private System.Windows.Forms.Label asterix_DateBuy;
        private System.Windows.Forms.Label lbl_DateOrder;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.Label txt_Client;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.ListBox listbox_Orders;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_IdtxtClient;
        private System.Windows.Forms.Label lbl_ClientId;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Button btn_FilterClient;
        private System.Windows.Forms.ListBox listbox_Clients;
        private System.Windows.Forms.Label txt_FullName;
        private System.Windows.Forms.Label txt_Email;
        private System.Windows.Forms.Label txt_PhoneNumber;
        private System.Windows.Forms.Label txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label txt_Price;
        private System.Windows.Forms.Label txt_LicenseNumber;
        private System.Windows.Forms.Label txt_Type;
        private System.Windows.Forms.Label lbl_IdtxtCar;
        private System.Windows.Forms.Label lbl_IdCar;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_LicenseNumber;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.ListBox listbox_Cars;
        private System.Windows.Forms.Button btn_FilterCar;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.TabPage tp_CarExtra;
        private System.Windows.Forms.Button btn_FilterExtra;
        private System.Windows.Forms.ListBox listbox_InOrder;
        private System.Windows.Forms.ListBox listbox_Potential;
        private System.Windows.Forms.DateTimePicker dtp_DateBuy;
        private System.Windows.Forms.TabPage tp_Design;
        private System.Windows.Forms.ListBox listbox_Designs;
        private System.Windows.Forms.Button btn_FilterDesign;
        private System.Windows.Forms.Label txt_BodyDesign;
        private System.Windows.Forms.Label txt_ColorType;
        private System.Windows.Forms.Label txt_CarColor;
        private System.Windows.Forms.Label lbl_IdtxtDesign;
        private System.Windows.Forms.Label lbl_IdDesign;
        private System.Windows.Forms.Label lbl_BodyDesign;
        private System.Windows.Forms.Label lbl_ColorType;
        private System.Windows.Forms.Label lbl_CarColor;
        private System.Windows.Forms.Panel pnl_Options;
        public System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Panel pnl_Cur;
        public System.Windows.Forms.Button btn_Extra;
        public System.Windows.Forms.Button btn_Car;
        public System.Windows.Forms.Button btn_Client;
        public System.Windows.Forms.Button btn_Design;
        private System.Windows.Forms.Label lbl_HeadlineClient;
        private System.Windows.Forms.Label lbl_HeadlineCar;
        private System.Windows.Forms.Label lbl_HeadlineExtra;
        private System.Windows.Forms.Label lbl_HeadlineDesign;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Save;
    }
}