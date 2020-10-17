namespace Project_Car.UI
{
    partial class Form_FilterExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterExtra));
            this.txt_MinPrice = new System.Windows.Forms.TextBox();
            this.lbl_MinPrice = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_MaxPrice = new System.Windows.Forms.TextBox();
            this.lbl_MaxPrice = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MinPrice
            // 
            this.txt_MinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MinPrice.Location = new System.Drawing.Point(17, 338);
            this.txt_MinPrice.Name = "txt_MinPrice";
            this.txt_MinPrice.Size = new System.Drawing.Size(335, 41);
            this.txt_MinPrice.TabIndex = 2;
            this.txt_MinPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.txt_MinPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // lbl_MinPrice
            // 
            this.lbl_MinPrice.AutoSize = true;
            this.lbl_MinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MinPrice.Location = new System.Drawing.Point(11, 278);
            this.lbl_MinPrice.Name = "lbl_MinPrice";
            this.lbl_MinPrice.Size = new System.Drawing.Size(140, 36);
            this.lbl_MinPrice.TabIndex = 224;
            this.lbl_MinPrice.Text = "Min Price";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 222;
            this.lbl_id.Text = "ID";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(17, 211);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(335, 41);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(11, 154);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 36);
            this.lbl_Name.TabIndex = 221;
            this.lbl_Name.Text = "Name";
            // 
            // txt_MaxPrice
            // 
            this.txt_MaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaxPrice.Location = new System.Drawing.Point(17, 459);
            this.txt_MaxPrice.Name = "txt_MaxPrice";
            this.txt_MaxPrice.Size = new System.Drawing.Size(335, 41);
            this.txt_MaxPrice.TabIndex = 3;
            this.txt_MaxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.txt_MaxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // lbl_MaxPrice
            // 
            this.lbl_MaxPrice.AutoSize = true;
            this.lbl_MaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaxPrice.Location = new System.Drawing.Point(11, 401);
            this.lbl_MaxPrice.Name = "lbl_MaxPrice";
            this.lbl_MaxPrice.Size = new System.Drawing.Size(147, 36);
            this.lbl_MaxPrice.TabIndex = 226;
            this.lbl_MaxPrice.Text = "Max Price";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 639);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 47);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(12, 639);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(142, 47);
            this.btn_Apply.TabIndex = 5;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(17, 78);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(335, 41);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // txt_Count
            // 
            this.txt_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.Location = new System.Drawing.Point(18, 573);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(335, 41);
            this.txt_Count.TabIndex = 4;
            this.txt_Count.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(12, 515);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(159, 36);
            this.lbl_Count.TabIndex = 231;
            this.lbl_Count.Text = "Max Count";
            // 
            // Form_FilterExtra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(387, 698);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.txt_MaxPrice);
            this.Controls.Add(this.lbl_MaxPrice);
            this.Controls.Add(this.txt_MinPrice);
            this.Controls.Add(this.lbl_MinPrice);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FilterExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterExtra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MinPrice;
        private System.Windows.Forms.Label lbl_MinPrice;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_MaxPrice;
        private System.Windows.Forms.Label lbl_MaxPrice;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Label lbl_Count;
    }
}