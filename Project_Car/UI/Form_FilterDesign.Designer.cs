namespace Project_Car.UI
{
    partial class Form_FilterDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FilterDesign));
            this.cmb_Body = new System.Windows.Forms.ComboBox();
            this.cmb_ColorType = new System.Windows.Forms.ComboBox();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.lbl_ColorType = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Body
            // 
            this.cmb_Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Body.FormattingEnabled = true;
            this.cmb_Body.Location = new System.Drawing.Point(12, 358);
            this.cmb_Body.Name = "cmb_Body";
            this.cmb_Body.Size = new System.Drawing.Size(316, 44);
            this.cmb_Body.TabIndex = 2;
            this.cmb_Body.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // cmb_ColorType
            // 
            this.cmb_ColorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ColorType.FormattingEnabled = true;
            this.cmb_ColorType.Location = new System.Drawing.Point(12, 219);
            this.cmb_ColorType.Name = "cmb_ColorType";
            this.cmb_ColorType.Size = new System.Drawing.Size(316, 44);
            this.cmb_ColorType.TabIndex = 1;
            this.cmb_ColorType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // cmb_Color
            // 
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(12, 84);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(316, 44);
            this.cmb_Color.TabIndex = 0;
            this.cmb_Color.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Body.Location = new System.Drawing.Point(6, 305);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(185, 36);
            this.lbl_Body.TabIndex = 247;
            this.lbl_Body.Text = "Body Design";
            // 
            // lbl_ColorType
            // 
            this.lbl_ColorType.AutoSize = true;
            this.lbl_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorType.Location = new System.Drawing.Point(6, 166);
            this.lbl_ColorType.Name = "lbl_ColorType";
            this.lbl_ColorType.Size = new System.Drawing.Size(161, 36);
            this.lbl_ColorType.TabIndex = 246;
            this.lbl_ColorType.Text = "Color Type";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Color.Location = new System.Drawing.Point(12, 33);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(87, 36);
            this.lbl_Color.TabIndex = 245;
            this.lbl_Color.Text = "Color";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(186, 465);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 47);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Location = new System.Drawing.Point(12, 465);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(142, 47);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Filter_KeyDown);
            // 
            // Form_FilterDesign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(343, 538);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.cmb_Body);
            this.Controls.Add(this.cmb_ColorType);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.lbl_ColorType);
            this.Controls.Add(this.lbl_Color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FilterDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterDesign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Body;
        private System.Windows.Forms.ComboBox cmb_ColorType;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.Label lbl_ColorType;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;
    }
}