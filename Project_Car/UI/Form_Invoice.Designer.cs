namespace Project_Car.UI
{
    partial class Form_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Invoice));
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.listbox_Items = new System.Windows.Forms.ListBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pd_DialogInvoice = new System.Windows.Forms.PrintDialog();
            this.pd_DocInvoice = new System.Drawing.Printing.PrintDocument();
            this.listbox_Price = new System.Windows.Forms.ListBox();
            this.Mady_by = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(345, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(220, 69);
            this.lbl_HeadLine.TabIndex = 115;
            this.lbl_HeadLine.Text = "Invoice";
            // 
            // listbox_Items
            // 
            this.listbox_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Items.FormattingEnabled = true;
            this.listbox_Items.ItemHeight = 36;
            this.listbox_Items.Location = new System.Drawing.Point(46, 99);
            this.listbox_Items.Name = "listbox_Items";
            this.listbox_Items.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbox_Items.Size = new System.Drawing.Size(422, 544);
            this.listbox_Items.TabIndex = 228;
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(399, 664);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(197, 47);
            this.btn_Print.TabIndex = 233;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btnPrintReciept_Click);
            // 
            // pd_DialogInvoice
            // 
            this.pd_DialogInvoice.UseEXDialog = true;
            // 
            // pd_DocInvoice
            // 
            this.pd_DocInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.CreateReceipt);
            // 
            // listbox_Price
            // 
            this.listbox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Price.FormattingEnabled = true;
            this.listbox_Price.ItemHeight = 36;
            this.listbox_Price.Location = new System.Drawing.Point(532, 99);
            this.listbox_Price.Name = "listbox_Price";
            this.listbox_Price.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbox_Price.Size = new System.Drawing.Size(296, 544);
            this.listbox_Price.TabIndex = 234;
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(377, 727);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 235;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // Form_Invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(935, 761);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.listbox_Price);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.listbox_Items);
            this.Controls.Add(this.lbl_HeadLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.ListBox listbox_Items;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PrintDialog pd_DialogInvoice;
        private System.Drawing.Printing.PrintDocument pd_DocInvoice;
        private System.Windows.Forms.ListBox listbox_Price;
        private System.Windows.Forms.Label Mady_by;
    }
}