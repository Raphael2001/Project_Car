﻿namespace Project_Car.UI
{
    partial class Form_Engine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Engine));
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.listbox_Engine = new System.Windows.Forms.ListBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.asterix_Name = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(192, 446);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 214;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(19, 375);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(496, 57);
            this.btn_Delete.TabIndex = 212;
            this.btn_Delete.Text = "Delete Engine";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // listbox_Engine
            // 
            this.listbox_Engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Engine.FormattingEnabled = true;
            this.listbox_Engine.ItemHeight = 36;
            this.listbox_Engine.Location = new System.Drawing.Point(577, 12);
            this.listbox_Engine.Name = "listbox_Engine";
            this.listbox_Engine.Size = new System.Drawing.Size(445, 436);
            this.listbox_Engine.TabIndex = 211;
            this.listbox_Engine.DoubleClick += new System.EventHandler(this.listbox_Engine_DoubleClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(19, 311);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 210;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(185, 311);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(330, 57);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save Engine";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(221, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(216, 69);
            this.lbl_HeadLine.TabIndex = 208;
            this.lbl_HeadLine.Text = "Engine";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(182, 112);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 207;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(19, 112);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 206;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorName.Location = new System.Drawing.Point(185, 248);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorName.TabIndex = 205;
            this.lbl_ErrorName.Text = "Enter Vaild Name";
            this.lbl_ErrorName.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Name.Location = new System.Drawing.Point(189, 186);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 41);
            this.txt_Name.TabIndex = 0;
            // 
            // asterix_Name
            // 
            this.asterix_Name.AutoSize = true;
            this.asterix_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Name.Location = new System.Drawing.Point(530, 186);
            this.asterix_Name.Name = "asterix_Name";
            this.asterix_Name.Size = new System.Drawing.Size(27, 36);
            this.asterix_Name.TabIndex = 204;
            this.asterix_Name.Text = "*";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(13, 189);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 36);
            this.lbl_Name.TabIndex = 203;
            this.lbl_Name.Text = "Name";
            // 
            // Form_Engine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1031, 489);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.listbox_Engine);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ErrorName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.asterix_Name);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Engine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListBox listbox_Engine;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label asterix_Name;
        private System.Windows.Forms.Label lbl_Name;
    }
}