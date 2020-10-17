namespace Project_Car.UI
{
    partial class Form_CarExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CarExtra));
            this.lbl_ErrorPrice = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.listbox_CarExtra = new System.Windows.Forms.ListBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.asterix_Price = new System.Windows.Forms.Label();
            this.asterix_Name = new System.Windows.Forms.Label();
            this.btn_FilterExtra = new System.Windows.Forms.Button();
            this.asterix_Count = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.lbl_ErrorCount = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ErrorPrice
            // 
            this.lbl_ErrorPrice.AutoSize = true;
            this.lbl_ErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPrice.Location = new System.Drawing.Point(185, 340);
            this.lbl_ErrorPrice.Name = "lbl_ErrorPrice";
            this.lbl_ErrorPrice.Size = new System.Drawing.Size(126, 20);
            this.lbl_ErrorPrice.TabIndex = 219;
            this.lbl_ErrorPrice.Text = "Enter Vaild Price";
            this.lbl_ErrorPrice.Visible = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(13, 290);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(83, 36);
            this.lbl_Price.TabIndex = 218;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(21, 566);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(491, 57);
            this.btn_Delete.TabIndex = 215;
            this.btn_Delete.Text = "Delete Car Extra";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // listbox_CarExtra
            // 
            this.listbox_CarExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_CarExtra.FormattingEnabled = true;
            this.listbox_CarExtra.HorizontalScrollbar = true;
            this.listbox_CarExtra.ItemHeight = 36;
            this.listbox_CarExtra.Location = new System.Drawing.Point(574, 75);
            this.listbox_CarExtra.Name = "listbox_CarExtra";
            this.listbox_CarExtra.Size = new System.Drawing.Size(336, 580);
            this.listbox_CarExtra.TabIndex = 214;
            this.listbox_CarExtra.DoubleClick += new System.EventHandler(this.listbox_CarExtra_DoubleClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(21, 503);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(209, 57);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(246, 503);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(266, 57);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Car Extra";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(240, 657);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 211;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(206, 10);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(236, 58);
            this.lbl_HeadLine.TabIndex = 210;
            this.lbl_HeadLine.Text = "Car Extra";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(180, 110);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 209;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(17, 110);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 208;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorName.Location = new System.Drawing.Point(185, 240);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorName.TabIndex = 207;
            this.lbl_ErrorName.Text = "Enter Vaild Name";
            this.lbl_ErrorName.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(187, 186);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 41);
            this.txt_Name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(16, 186);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 36);
            this.lbl_Name.TabIndex = 206;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(186, 287);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(326, 41);
            this.txt_Price.TabIndex = 1;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // asterix_Price
            // 
            this.asterix_Price.AutoSize = true;
            this.asterix_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Price.Location = new System.Drawing.Point(518, 287);
            this.asterix_Price.Name = "asterix_Price";
            this.asterix_Price.Size = new System.Drawing.Size(27, 36);
            this.asterix_Price.TabIndex = 222;
            this.asterix_Price.Text = "*";
            // 
            // asterix_Name
            // 
            this.asterix_Name.AutoSize = true;
            this.asterix_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Name.Location = new System.Drawing.Point(518, 189);
            this.asterix_Name.Name = "asterix_Name";
            this.asterix_Name.Size = new System.Drawing.Size(27, 36);
            this.asterix_Name.TabIndex = 221;
            this.asterix_Name.Text = "*";
            // 
            // btn_FilterExtra
            // 
            this.btn_FilterExtra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_FilterExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_FilterExtra.Location = new System.Drawing.Point(574, 10);
            this.btn_FilterExtra.Name = "btn_FilterExtra";
            this.btn_FilterExtra.Size = new System.Drawing.Size(336, 57);
            this.btn_FilterExtra.TabIndex = 223;
            this.btn_FilterExtra.Text = "Filter By";
            this.btn_FilterExtra.UseVisualStyleBackColor = true;
            this.btn_FilterExtra.Click += new System.EventHandler(this.btn_FilterExtra_Click);
            // 
            // asterix_Count
            // 
            this.asterix_Count.AutoSize = true;
            this.asterix_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Count.Location = new System.Drawing.Point(518, 392);
            this.asterix_Count.Name = "asterix_Count";
            this.asterix_Count.Size = new System.Drawing.Size(27, 36);
            this.asterix_Count.TabIndex = 227;
            this.asterix_Count.Text = "*";
            // 
            // txt_Count
            // 
            this.txt_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.Location = new System.Drawing.Point(186, 392);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(326, 41);
            this.txt_Count.TabIndex = 3;
            // 
            // lbl_ErrorCount
            // 
            this.lbl_ErrorCount.AutoSize = true;
            this.lbl_ErrorCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorCount.Location = new System.Drawing.Point(185, 445);
            this.lbl_ErrorCount.Name = "lbl_ErrorCount";
            this.lbl_ErrorCount.Size = new System.Drawing.Size(134, 20);
            this.lbl_ErrorCount.TabIndex = 226;
            this.lbl_ErrorCount.Text = "Enter Vaild Count";
            this.lbl_ErrorCount.Visible = false;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(13, 395);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(95, 36);
            this.lbl_Count.TabIndex = 225;
            this.lbl_Count.Text = "Count";
            // 
            // Form_CarExtra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(914, 705);
            this.Controls.Add(this.asterix_Count);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.lbl_ErrorCount);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_FilterExtra);
            this.Controls.Add(this.asterix_Price);
            this.Controls.Add(this.asterix_Name);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.listbox_CarExtra);
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
            this.Name = "Form_CarExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarExtra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ErrorPrice;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListBox listbox_CarExtra;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label asterix_Price;
        private System.Windows.Forms.Label asterix_Name;
        private System.Windows.Forms.Button btn_FilterExtra;
        private System.Windows.Forms.Label asterix_Count;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Label lbl_ErrorCount;
        private System.Windows.Forms.Label lbl_Count;
    }
}