namespace Project_Car.UI
{
    partial class Form_Street
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Street));
            this.listbox_Streets = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_NewAddrees = new System.Windows.Forms.TextBox();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.asterix_Name = new System.Windows.Forms.Label();
            this.Mady_by = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox_Streets
            // 
            this.listbox_Streets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Streets.FormattingEnabled = true;
            this.listbox_Streets.ItemHeight = 36;
            this.listbox_Streets.Location = new System.Drawing.Point(517, 12);
            this.listbox_Streets.Name = "listbox_Streets";
            this.listbox_Streets.Size = new System.Drawing.Size(316, 436);
            this.listbox_Streets.TabIndex = 119;
            this.listbox_Streets.DoubleClick += new System.EventHandler(this.listbox_Street_DoubleClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(204, 391);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(232, 57);
            this.btn_Delete.TabIndex = 144;
            this.btn_Delete.Text = "Delete Street";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(12, 391);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(178, 57);
            this.btn_Clear.TabIndex = 143;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_NewAddrees
            // 
            this.txt_NewAddrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_NewAddrees.Location = new System.Drawing.Point(8, 209);
            this.txt_NewAddrees.Name = "txt_NewAddrees";
            this.txt_NewAddrees.Size = new System.Drawing.Size(470, 41);
            this.txt_NewAddrees.TabIndex = 0;
            this.txt_NewAddrees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NewStreet_KeyUp);
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(192, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(190, 69);
            this.lbl_HeadLine.TabIndex = 145;
            this.lbl_HeadLine.Text = "Street";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(70, 92);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 151;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(5, 92);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 150;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Street.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Street.Location = new System.Drawing.Point(2, 153);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(93, 36);
            this.lbl_Street.TabIndex = 152;
            this.lbl_Street.Text = "Street";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(11, 322);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(425, 57);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save Street";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorName.Location = new System.Drawing.Point(12, 263);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(135, 20);
            this.lbl_ErrorName.TabIndex = 155;
            this.lbl_ErrorName.Text = "Enter Vaild Street";
            this.lbl_ErrorName.Visible = false;
            // 
            // asterix_Name
            // 
            this.asterix_Name.AutoSize = true;
            this.asterix_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Name.Location = new System.Drawing.Point(484, 209);
            this.asterix_Name.Name = "asterix_Name";
            this.asterix_Name.Size = new System.Drawing.Size(27, 36);
            this.asterix_Name.TabIndex = 154;
            this.asterix_Name.Text = "*";
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(245, 485);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 156;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // Form_Street
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(845, 543);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_ErrorName);
            this.Controls.Add(this.asterix_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Street);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_NewAddrees);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.listbox_Streets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Street";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Street";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NewStreet_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listbox_Streets;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_NewAddrees;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.Label asterix_Name;
        private System.Windows.Forms.Label Mady_by;
    }
}