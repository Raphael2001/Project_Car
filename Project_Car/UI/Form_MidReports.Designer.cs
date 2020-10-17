namespace Project_Car.UI
{
    partial class Form_MidReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MidReports));
            this.Mady_by = new System.Windows.Forms.Label();
            this.lbl_OR = new System.Windows.Forms.Label();
            this.btn_Table = new System.Windows.Forms.Button();
            this.btn_Graphic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(302, 273);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 247;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // lbl_OR
            // 
            this.lbl_OR.AutoSize = true;
            this.lbl_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OR.Location = new System.Drawing.Point(452, 112);
            this.lbl_OR.Name = "lbl_OR";
            this.lbl_OR.Size = new System.Drawing.Size(80, 46);
            this.lbl_OR.TabIndex = 246;
            this.lbl_OR.Text = "OR";
            // 
            // btn_Table
            // 
            this.btn_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table.Location = new System.Drawing.Point(524, 216);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Size = new System.Drawing.Size(446, 54);
            this.btn_Table.TabIndex = 245;
            this.btn_Table.Text = "Table";
            this.btn_Table.UseVisualStyleBackColor = true;
            this.btn_Table.Click += new System.EventHandler(this.Btn_Table_Click);
            // 
            // btn_Graphic
            // 
            this.btn_Graphic.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Graphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Graphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Graphic.Location = new System.Drawing.Point(14, 11);
            this.btn_Graphic.Name = "btn_Graphic";
            this.btn_Graphic.Size = new System.Drawing.Size(446, 58);
            this.btn_Graphic.TabIndex = 244;
            this.btn_Graphic.Text = "Graphic";
            this.btn_Graphic.UseVisualStyleBackColor = true;
            this.btn_Graphic.Click += new System.EventHandler(this.Btn_Graphic_Click);
            // 
            // Form_MidReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(982, 316);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_OR);
            this.Controls.Add(this.btn_Table);
            this.Controls.Add(this.btn_Graphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MidReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MidReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label lbl_OR;
        private System.Windows.Forms.Button btn_Table;
        private System.Windows.Forms.Button btn_Graphic;
    }
}