namespace Project_Car.UI
{
    partial class Form_MidView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MidView));
            this.btn_Rent = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.lbl_OR = new System.Windows.Forms.Label();
            this.Mady_by = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Rent
            // 
            this.btn_Rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rent.Location = new System.Drawing.Point(465, 157);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(446, 54);
            this.btn_Rent.TabIndex = 237;
            this.btn_Rent.Text = "Rent";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buy.Location = new System.Drawing.Point(12, 12);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(446, 58);
            this.btn_Buy.TabIndex = 236;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // lbl_OR
            // 
            this.lbl_OR.AutoSize = true;
            this.lbl_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OR.Location = new System.Drawing.Point(435, 95);
            this.lbl_OR.Name = "lbl_OR";
            this.lbl_OR.Size = new System.Drawing.Size(80, 46);
            this.lbl_OR.TabIndex = 238;
            this.lbl_OR.Text = "OR";
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(286, 223);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 239;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // Form_MidView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(923, 266);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.lbl_OR);
            this.Controls.Add(this.btn_Rent);
            this.Controls.Add(this.btn_Buy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MidView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MidView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Label lbl_OR;
        private System.Windows.Forms.Label Mady_by;
    }
}