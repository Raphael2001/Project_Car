namespace Project_Car.UI
{
    partial class Form_CarDesign
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CarDesign));
            this.lbl_HeadLine = new System.Windows.Forms.Label();
            this.lbl_Idtxt = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ColorType = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.cmb_ColorType = new System.Windows.Forms.ComboBox();
            this.cmb_Body = new System.Windows.Forms.ComboBox();
            this.listbox_Designs = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Mady_by = new System.Windows.Forms.Label();
            this.asterix_Type = new System.Windows.Forms.Label();
            this.asterix_Color = new System.Windows.Forms.Label();
            this.lbl_ErrorType = new System.Windows.Forms.Label();
            this.lbl_ErrorColor = new System.Windows.Forms.Label();
            this.asterix_Body = new System.Windows.Forms.Label();
            this.lbl_ErrorBody = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_AucPrice = new System.Windows.Forms.Label();
            this.btn_FilterDesign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_HeadLine
            // 
            this.lbl_HeadLine.AutoSize = true;
            this.lbl_HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_HeadLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_HeadLine.Location = new System.Drawing.Point(275, 9);
            this.lbl_HeadLine.Name = "lbl_HeadLine";
            this.lbl_HeadLine.Size = new System.Drawing.Size(275, 58);
            this.lbl_HeadLine.TabIndex = 233;
            this.lbl_HeadLine.Text = "Car Design";
            // 
            // lbl_Idtxt
            // 
            this.lbl_Idtxt.AutoSize = true;
            this.lbl_Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtxt.Location = new System.Drawing.Point(228, 133);
            this.lbl_Idtxt.Name = "lbl_Idtxt";
            this.lbl_Idtxt.Size = new System.Drawing.Size(32, 36);
            this.lbl_Idtxt.TabIndex = 235;
            this.lbl_Idtxt.Text = "0";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(0, 133);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(44, 36);
            this.lbl_id.TabIndex = 234;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ColorType
            // 
            this.lbl_ColorType.AutoSize = true;
            this.lbl_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorType.Location = new System.Drawing.Point(-3, 368);
            this.lbl_ColorType.Name = "lbl_ColorType";
            this.lbl_ColorType.Size = new System.Drawing.Size(161, 36);
            this.lbl_ColorType.TabIndex = 240;
            this.lbl_ColorType.Text = "Color Type";
            this.toolTip1.SetToolTip(this.lbl_ColorType, "Click to add a new Color Type");
            this.lbl_ColorType.Click += new System.EventHandler(this.lbl_ColorType_Click);
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Color.Location = new System.Drawing.Point(0, 242);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(87, 36);
            this.lbl_Color.TabIndex = 239;
            this.lbl_Color.Text = "Color";
            this.toolTip1.SetToolTip(this.lbl_Color, "Click to add a new Car Color");
            this.lbl_Color.Click += new System.EventHandler(this.lbl_Color_Click);
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Body.Location = new System.Drawing.Point(0, 494);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(185, 36);
            this.lbl_Body.TabIndex = 241;
            this.lbl_Body.Text = "Body Design";
            this.toolTip1.SetToolTip(this.lbl_Body, "Click to add a new Body Design");
            this.lbl_Body.Click += new System.EventHandler(this.lbl_Body_Click);
            // 
            // cmb_Color
            // 
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(234, 234);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(316, 44);
            this.cmb_Color.TabIndex = 0;
            this.cmb_Color.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // cmb_ColorType
            // 
            this.cmb_ColorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ColorType.FormattingEnabled = true;
            this.cmb_ColorType.Location = new System.Drawing.Point(234, 360);
            this.cmb_ColorType.Name = "cmb_ColorType";
            this.cmb_ColorType.Size = new System.Drawing.Size(316, 44);
            this.cmb_ColorType.TabIndex = 1;
            this.cmb_ColorType.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // cmb_Body
            // 
            this.cmb_Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Body.FormattingEnabled = true;
            this.cmb_Body.Location = new System.Drawing.Point(234, 486);
            this.cmb_Body.Name = "cmb_Body";
            this.cmb_Body.Size = new System.Drawing.Size(316, 44);
            this.cmb_Body.TabIndex = 2;
            this.cmb_Body.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // listbox_Designs
            // 
            this.listbox_Designs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Designs.FormattingEnabled = true;
            this.listbox_Designs.HorizontalScrollbar = true;
            this.listbox_Designs.ItemHeight = 36;
            this.listbox_Designs.Location = new System.Drawing.Point(687, 120);
            this.listbox_Designs.Name = "listbox_Designs";
            this.listbox_Designs.Size = new System.Drawing.Size(503, 544);
            this.listbox_Designs.TabIndex = 245;
            this.listbox_Designs.DoubleClick += new System.EventHandler(this.listbox_CarDesign_DoubleClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.Location = new System.Drawing.Point(175, 793);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(491, 57);
            this.btn_Delete.TabIndex = 249;
            this.btn_Delete.Text = "Delete Car Design";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(175, 730);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(209, 57);
            this.btn_Clear.TabIndex = 247;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Save.Location = new System.Drawing.Point(400, 730);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(266, 57);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save Car Design";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(322, 862);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 248;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // asterix_Type
            // 
            this.asterix_Type.AutoSize = true;
            this.asterix_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Type.Location = new System.Drawing.Point(563, 360);
            this.asterix_Type.Name = "asterix_Type";
            this.asterix_Type.Size = new System.Drawing.Size(27, 36);
            this.asterix_Type.TabIndex = 253;
            this.asterix_Type.Text = "*";
            // 
            // asterix_Color
            // 
            this.asterix_Color.AutoSize = true;
            this.asterix_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Color.Location = new System.Drawing.Point(563, 237);
            this.asterix_Color.Name = "asterix_Color";
            this.asterix_Color.Size = new System.Drawing.Size(27, 36);
            this.asterix_Color.TabIndex = 252;
            this.asterix_Color.Text = "*";
            // 
            // lbl_ErrorType
            // 
            this.lbl_ErrorType.AutoSize = true;
            this.lbl_ErrorType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ErrorType.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorType.Location = new System.Drawing.Point(230, 418);
            this.lbl_ErrorType.Name = "lbl_ErrorType";
            this.lbl_ErrorType.Size = new System.Drawing.Size(166, 20);
            this.lbl_ErrorType.TabIndex = 251;
            this.lbl_ErrorType.Text = "Enter Vaild Color Type";
            this.lbl_ErrorType.Visible = false;
            // 
            // lbl_ErrorColor
            // 
            this.lbl_ErrorColor.AutoSize = true;
            this.lbl_ErrorColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ErrorColor.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorColor.Location = new System.Drawing.Point(230, 290);
            this.lbl_ErrorColor.Name = "lbl_ErrorColor";
            this.lbl_ErrorColor.Size = new System.Drawing.Size(128, 20);
            this.lbl_ErrorColor.TabIndex = 250;
            this.lbl_ErrorColor.Text = "Enter Vaild Color";
            this.lbl_ErrorColor.Visible = false;
            // 
            // asterix_Body
            // 
            this.asterix_Body.AutoSize = true;
            this.asterix_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asterix_Body.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asterix_Body.Location = new System.Drawing.Point(563, 489);
            this.asterix_Body.Name = "asterix_Body";
            this.asterix_Body.Size = new System.Drawing.Size(27, 36);
            this.asterix_Body.TabIndex = 255;
            this.asterix_Body.Text = "*";
            // 
            // lbl_ErrorBody
            // 
            this.lbl_ErrorBody.AutoSize = true;
            this.lbl_ErrorBody.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ErrorBody.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorBody.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorBody.Location = new System.Drawing.Point(230, 552);
            this.lbl_ErrorBody.Name = "lbl_ErrorBody";
            this.lbl_ErrorBody.Size = new System.Drawing.Size(181, 20);
            this.lbl_ErrorBody.TabIndex = 254;
            this.lbl_ErrorBody.Text = "Enter Vaild Body Design";
            this.lbl_ErrorBody.Visible = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(0, 611);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(83, 36);
            this.lbl_Price.TabIndex = 256;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_AucPrice
            // 
            this.lbl_AucPrice.AutoSize = true;
            this.lbl_AucPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AucPrice.Location = new System.Drawing.Point(228, 620);
            this.lbl_AucPrice.Name = "lbl_AucPrice";
            this.lbl_AucPrice.Size = new System.Drawing.Size(32, 36);
            this.lbl_AucPrice.TabIndex = 257;
            this.lbl_AucPrice.Text = "0";
            // 
            // btn_FilterDesign
            // 
            this.btn_FilterDesign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_FilterDesign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_FilterDesign.Location = new System.Drawing.Point(687, 57);
            this.btn_FilterDesign.Name = "btn_FilterDesign";
            this.btn_FilterDesign.Size = new System.Drawing.Size(503, 57);
            this.btn_FilterDesign.TabIndex = 258;
            this.btn_FilterDesign.Text = "Filter By";
            this.btn_FilterDesign.UseVisualStyleBackColor = true;
            this.btn_FilterDesign.Click += new System.EventHandler(this.btn_FilterDesign_Click);
            // 
            // Form_CarDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1202, 916);
            this.Controls.Add(this.btn_FilterDesign);
            this.Controls.Add(this.lbl_AucPrice);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.asterix_Body);
            this.Controls.Add(this.lbl_ErrorBody);
            this.Controls.Add(this.asterix_Type);
            this.Controls.Add(this.asterix_Color);
            this.Controls.Add(this.lbl_ErrorType);
            this.Controls.Add(this.lbl_ErrorColor);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.listbox_Designs);
            this.Controls.Add(this.cmb_Body);
            this.Controls.Add(this.cmb_ColorType);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.lbl_ColorType);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.lbl_Idtxt);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_HeadLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CarDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarDesign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HeadLine;
        private System.Windows.Forms.Label lbl_Idtxt;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ColorType;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.ComboBox cmb_ColorType;
        private System.Windows.Forms.ComboBox cmb_Body;
        private System.Windows.Forms.ListBox listbox_Designs;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Mady_by;
        private System.Windows.Forms.Label asterix_Type;
        private System.Windows.Forms.Label asterix_Color;
        private System.Windows.Forms.Label lbl_ErrorType;
        private System.Windows.Forms.Label lbl_ErrorColor;
        private System.Windows.Forms.Label asterix_Body;
        private System.Windows.Forms.Label lbl_ErrorBody;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_AucPrice;
        private System.Windows.Forms.Button btn_FilterDesign;
    }
}