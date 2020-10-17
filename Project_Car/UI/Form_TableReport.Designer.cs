namespace Project_Car.UI
{
    partial class Form_TableReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TableReport));
            this.listBox_Data = new System.Windows.Forms.ListBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.Mady_by = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Data
            // 
            this.listBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Data.FormattingEnabled = true;
            this.listBox_Data.ItemHeight = 36;
            this.listBox_Data.Location = new System.Drawing.Point(156, 219);
            this.listBox_Data.Name = "listBox_Data";
            this.listBox_Data.Size = new System.Drawing.Size(849, 436);
            this.listBox_Data.TabIndex = 0;
            // 
            // btn_Filter
            // 
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Filter.Location = new System.Drawing.Point(342, 127);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(442, 86);
            this.btn_Filter.TabIndex = 132;
            this.btn_Filter.Text = "Filter By";
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(440, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(147, 69);
            this.lbl_HeadLine.TabIndex = 133;
            this.lbl_HeadLine.Text = "Text";
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(446, 658);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 253;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(1036, 644);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 254;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form_TableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1208, 713);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_HeadLine);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.listBox_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TableReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableReport";
            this.Load += new System.EventHandler(this.Form_TableReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Data;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Button btn_Clear;
    }
}