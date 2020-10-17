namespace Project_Car.UI
{
    partial class Form_BodyDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BodyDesign));
            this.asterix_Price = new System.Windows.Forms.Label();
            this.asterix_Name = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.listbox_BodyDesign = new System.Windows.Forms.ListBox();
            this.lbl_ErrorPrice = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asterix_Price
            // 
            this.asterix_Price.AutoSize = true;
            this.asterix_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Price.Location = new System.Drawing.Point(516, 297);
            this.asterix_Price.Name = "asterix_Price";
            this.asterix_Price.Size = new System.Drawing.Size(27, 36);
            this.asterix_Price.TabIndex = 256;
            this.asterix_Price.Text = "*";
            // 
            // asterix_Name
            // 
            this.asterix_Name.AutoSize = true;
            this.asterix_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Name.Location = new System.Drawing.Point(516, 199);
            this.asterix_Name.Name = "asterix_Name";
            this.asterix_Name.Size = new System.Drawing.Size(27, 36);
            this.asterix_Name.TabIndex = 255;
            this.asterix_Name.Text = "*";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(184, 297);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(326, 41);
            this.txt_Price.TabIndex = 1;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // listbox_BodyDesign
            // 
            this.listbox_BodyDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_BodyDesign.FormattingEnabled = true;
            this.listbox_BodyDesign.ItemHeight = 36;
            this.listbox_BodyDesign.Location = new System.Drawing.Point(572, 85);
            this.listbox_BodyDesign.Name = "listbox_BodyDesign";
            this.listbox_BodyDesign.Size = new System.Drawing.Size(336, 508);
            this.listbox_BodyDesign.TabIndex = 251;
            this.listbox_BodyDesign.DoubleClick += new System.EventHandler(this.listbox_BodyDesign_DoubleClick);
            // 
            // lbl_ErrorPrice
            // 
            this.lbl_ErrorPrice.AutoSize = true;
            this.lbl_ErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPrice.Location = new System.Drawing.Point(183, 350);
            this.lbl_ErrorPrice.Name = "lbl_ErrorPrice";
            this.lbl_ErrorPrice.Size = new System.Drawing.Size(126, 20);
            this.lbl_ErrorPrice.TabIndex = 254;
            this.lbl_ErrorPrice.Text = "Enter Vaild Price";
            this.lbl_ErrorPrice.Visible = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(11, 300);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(83, 36);
            this.lbl_Price.TabIndex = 253;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(19, 480);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(491, 57);
            this.btn_Delete.TabIndex = 252;
            this.btn_Delete.Text = "Delete Body Design";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(19, 417);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(191, 57);
            this.btn_Clear.TabIndex = 244;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(231, 417);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(279, 57);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save Body Design";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(245, 562);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 250;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(204, 20);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(308, 58);
            this.lbl_HeadLine.TabIndex = 249;
            this.lbl_HeadLine.Text = "Body Design";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(178, 120);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 248;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(15, 120);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 247;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorName.Location = new System.Drawing.Point(183, 250);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorName.TabIndex = 246;
            this.lbl_ErrorName.Text = "Enter Vaild Name";
            this.lbl_ErrorName.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(185, 196);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 41);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(14, 196);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 36);
            this.lbl_Name.TabIndex = 245;
            this.lbl_Name.Text = "Name";
            // 
            // Form_BodyDesign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(922, 623);
            this.Controls.Add(this.asterix_Price);
            this.Controls.Add(this.asterix_Name);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.listbox_BodyDesign);
            this.Controls.Add(this.lbl_ErrorPrice);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ErrorName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BodyDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BodyDesign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label asterix_Price;
        private System.Windows.Forms.Label asterix_Name;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ListBox listbox_BodyDesign;
        private System.Windows.Forms.Label lbl_ErrorPrice;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
    }
}