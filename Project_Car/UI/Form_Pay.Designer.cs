namespace Project_Car.UI
{
    partial class Form_Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pay));
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_ErrorFullName = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.asterix_FullName = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_ErrorNumber = new System.Windows.Forms.Label();
            this.txt_Card = new System.Windows.Forms.TextBox();
            this.asterix_Number = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_ErrorDate = new System.Windows.Forms.Label();
            this.asterix_Date = new System.Windows.Forms.Label();
            this.cmb_DateMonth = new System.Windows.Forms.ComboBox();
            this.cmb_DateYear = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_ErrorCVC = new System.Windows.Forms.Label();
            this.txt_CVC = new System.Windows.Forms.TextBox();
            this.asterix_CVC = new System.Windows.Forms.Label();
            this.lbl_CVC = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(384, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(133, 69);
            this.lbl_HeadLine.TabIndex = 114;
            this.lbl_HeadLine.Text = "Pay";
            // 
            // lbl_ErrorFullName
            // 
            this.lbl_ErrorFullName.AutoSize = true;
            this.lbl_ErrorFullName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorFullName.Location = new System.Drawing.Point(41, 325);
            this.lbl_ErrorFullName.Name = "lbl_ErrorFullName";
            this.lbl_ErrorFullName.Size = new System.Drawing.Size(133, 20);
            this.lbl_ErrorFullName.TabIndex = 118;
            this.lbl_ErrorFullName.Text = "Enter Vaild Name";
            this.lbl_ErrorFullName.Visible = false;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_FullName.Location = new System.Drawing.Point(37, 267);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(374, 41);
            this.txt_FullName.TabIndex = 115;
            this.txt_FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // asterix_FullName
            // 
            this.asterix_FullName.AutoSize = true;
            this.asterix_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_FullName.Location = new System.Drawing.Point(425, 265);
            this.asterix_FullName.Name = "asterix_FullName";
            this.asterix_FullName.Size = new System.Drawing.Size(27, 36);
            this.asterix_FullName.TabIndex = 117;
            this.asterix_FullName.Text = "*";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_FullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_FullName.Location = new System.Drawing.Point(25, 218);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(149, 36);
            this.lbl_FullName.TabIndex = 116;
            this.lbl_FullName.Text = "Full Name";
            // 
            // lbl_ErrorNumber
            // 
            this.lbl_ErrorNumber.AutoSize = true;
            this.lbl_ErrorNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorNumber.Location = new System.Drawing.Point(502, 325);
            this.lbl_ErrorNumber.Name = "lbl_ErrorNumber";
            this.lbl_ErrorNumber.Size = new System.Drawing.Size(147, 20);
            this.lbl_ErrorNumber.TabIndex = 122;
            this.lbl_ErrorNumber.Text = "Enter Vaild Number";
            this.lbl_ErrorNumber.Visible = false;
            // 
            // txt_Card
            // 
            this.txt_Card.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Card.Location = new System.Drawing.Point(498, 267);
            this.txt_Card.MaxLength = 16;
            this.txt_Card.Name = "txt_Card";
            this.txt_Card.Size = new System.Drawing.Size(374, 41);
            this.txt_Card.TabIndex = 119;
            this.txt_Card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // asterix_Number
            // 
            this.asterix_Number.AutoSize = true;
            this.asterix_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Number.Location = new System.Drawing.Point(886, 265);
            this.asterix_Number.Name = "asterix_Number";
            this.asterix_Number.Size = new System.Drawing.Size(27, 36);
            this.asterix_Number.TabIndex = 121;
            this.asterix_Number.Text = "*";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Number.Location = new System.Drawing.Point(486, 218);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(192, 36);
            this.lbl_Number.TabIndex = 120;
            this.lbl_Number.Text = "Card Number";
            // 
            // lbl_ErrorDate
            // 
            this.lbl_ErrorDate.AutoSize = true;
            this.lbl_ErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorDate.Location = new System.Drawing.Point(40, 487);
            this.lbl_ErrorDate.Name = "lbl_ErrorDate";
            this.lbl_ErrorDate.Size = new System.Drawing.Size(87, 20);
            this.lbl_ErrorDate.TabIndex = 127;
            this.lbl_ErrorDate.Text = "Enter Date";
            this.lbl_ErrorDate.Visible = false;
            // 
            // asterix_Date
            // 
            this.asterix_Date.AutoSize = true;
            this.asterix_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Date.Location = new System.Drawing.Point(425, 429);
            this.asterix_Date.Name = "asterix_Date";
            this.asterix_Date.Size = new System.Drawing.Size(27, 36);
            this.asterix_Date.TabIndex = 126;
            this.asterix_Date.Text = "*";
            // 
            // cmb_DateMonth
            // 
            this.cmb_DateMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_DateMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_DateMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DateMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DateMonth.FormattingEnabled = true;
            this.cmb_DateMonth.Items.AddRange(new object[] {
            "Month",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmb_DateMonth.Location = new System.Drawing.Point(31, 429);
            this.cmb_DateMonth.MaxDropDownItems = 10;
            this.cmb_DateMonth.Name = "cmb_DateMonth";
            this.cmb_DateMonth.Size = new System.Drawing.Size(138, 44);
            this.cmb_DateMonth.TabIndex = 123;
            // 
            // cmb_DateYear
            // 
            this.cmb_DateYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_DateYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_DateYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DateYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DateYear.FormattingEnabled = true;
            this.cmb_DateYear.Items.AddRange(new object[] {
            "Year"});
            this.cmb_DateYear.Location = new System.Drawing.Point(175, 429);
            this.cmb_DateYear.MaxDropDownItems = 10;
            this.cmb_DateYear.Name = "cmb_DateYear";
            this.cmb_DateYear.Size = new System.Drawing.Size(120, 44);
            this.cmb_DateYear.TabIndex = 124;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Date.Location = new System.Drawing.Point(24, 376);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(76, 36);
            this.lbl_Date.TabIndex = 125;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_ErrorCVC
            // 
            this.lbl_ErrorCVC.AutoSize = true;
            this.lbl_ErrorCVC.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCVC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorCVC.Location = new System.Drawing.Point(502, 502);
            this.lbl_ErrorCVC.Name = "lbl_ErrorCVC";
            this.lbl_ErrorCVC.Size = new System.Drawing.Size(124, 20);
            this.lbl_ErrorCVC.TabIndex = 131;
            this.lbl_ErrorCVC.Text = "Enter Vaild CVC";
            this.lbl_ErrorCVC.Visible = false;
            // 
            // txt_CVC
            // 
            this.txt_CVC.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_CVC.Location = new System.Drawing.Point(498, 441);
            this.txt_CVC.MaxLength = 3;
            this.txt_CVC.Name = "txt_CVC";
            this.txt_CVC.Size = new System.Drawing.Size(103, 41);
            this.txt_CVC.TabIndex = 128;
            this.txt_CVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digit_KeyPress);
            // 
            // asterix_CVC
            // 
            this.asterix_CVC.AutoSize = true;
            this.asterix_CVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_CVC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_CVC.Location = new System.Drawing.Point(886, 439);
            this.asterix_CVC.Name = "asterix_CVC";
            this.asterix_CVC.Size = new System.Drawing.Size(27, 36);
            this.asterix_CVC.TabIndex = 130;
            this.asterix_CVC.Text = "*";
            // 
            // lbl_CVC
            // 
            this.lbl_CVC.AutoSize = true;
            this.lbl_CVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_CVC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_CVC.Location = new System.Drawing.Point(486, 392);
            this.lbl_CVC.Name = "lbl_CVC";
            this.lbl_CVC.Size = new System.Drawing.Size(78, 36);
            this.lbl_CVC.TabIndex = 129;
            this.lbl_CVC.Text = "CVC";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(110, 131);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 133;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(24, 133);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 132;
            this.lbl_id.Text = "ID";
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(251, 583);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 57);
            this.btn_Clear.TabIndex = 136;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(422, 583);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(231, 57);
            this.btn_Save.TabIndex = 135;
            this.btn_Save.Text = "Save Payout";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(321, 652);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 137;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // Form_Pay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(968, 695);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ErrorCVC);
            this.Controls.Add(this.txt_CVC);
            this.Controls.Add(this.asterix_CVC);
            this.Controls.Add(this.lbl_CVC);
            this.Controls.Add(this.lbl_ErrorDate);
            this.Controls.Add(this.asterix_Date);
            this.Controls.Add(this.cmb_DateMonth);
            this.Controls.Add(this.cmb_DateYear);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_ErrorNumber);
            this.Controls.Add(this.txt_Card);
            this.Controls.Add(this.asterix_Number);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_ErrorFullName);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.asterix_FullName);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.lbl_HeadLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_ErrorFullName;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label asterix_FullName;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_ErrorNumber;
        private System.Windows.Forms.TextBox txt_Card;
        private System.Windows.Forms.Label asterix_Number;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_ErrorDate;
        private System.Windows.Forms.Label asterix_Date;
        private System.Windows.Forms.ComboBox cmb_DateMonth;
        private System.Windows.Forms.ComboBox cmb_DateYear;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_ErrorCVC;
        private System.Windows.Forms.TextBox txt_CVC;
        private System.Windows.Forms.Label asterix_CVC;
        private System.Windows.Forms.Label lbl_CVC;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Mady_by;
    }
}