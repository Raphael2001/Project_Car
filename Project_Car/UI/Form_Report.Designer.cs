namespace Project_Car.UI
{
    partial class Form_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Report));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rb_Month = new System.Windows.Forms.RadioButton();
            this.rb_Two = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_Year = new System.Windows.Forms.RadioButton();
            this.Mady_by = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1100, 724);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // rb_Month
            // 
            this.rb_Month.AutoSize = true;
            this.rb_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Month.Location = new System.Drawing.Point(1126, 78);
            this.rb_Month.Name = "rb_Month";
            this.rb_Month.Size = new System.Drawing.Size(188, 40);
            this.rb_Month.TabIndex = 1;
            this.rb_Month.TabStop = true;
            this.rb_Month.Text = "Last Month";
            this.rb_Month.UseVisualStyleBackColor = true;
            this.rb_Month.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Two
            // 
            this.rb_Two.AutoSize = true;
            this.rb_Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Two.Location = new System.Drawing.Point(1126, 136);
            this.rb_Two.Name = "rb_Two";
            this.rb_Two.Size = new System.Drawing.Size(268, 40);
            this.rb_Two.TabIndex = 2;
            this.rb_Two.TabStop = true;
            this.rb_Two.Text = "Last Two Months";
            this.rb_Two.UseVisualStyleBackColor = true;
            this.rb_Two.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_All.Location = new System.Drawing.Point(1126, 249);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(162, 40);
            this.rb_All.TabIndex = 4;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "All Times";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Year
            // 
            this.rb_Year.AutoSize = true;
            this.rb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Year.Location = new System.Drawing.Point(1126, 191);
            this.rb_Year.Name = "rb_Year";
            this.rb_Year.Size = new System.Drawing.Size(166, 40);
            this.rb_Year.TabIndex = 3;
            this.rb_Year.TabStop = true;
            this.rb_Year.Text = "Last Year";
            this.rb_Year.UseVisualStyleBackColor = true;
            this.rb_Year.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Mady_by
            // 
            this.Mady_by.AutoSize = true;
            this.Mady_by.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.Mady_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mady_by.Location = new System.Drawing.Point(1138, 679);
            this.Mady_by.Name = "Mady_by";
            this.Mady_by.Size = new System.Drawing.Size(266, 34);
            this.Mady_by.TabIndex = 236;
            this.Mady_by.Text = "Made by Raphael Aboohi";
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1434, 722);
            this.Controls.Add(this.Mady_by);
            this.Controls.Add(this.rb_All);
            this.Controls.Add(this.rb_Year);
            this.Controls.Add(this.rb_Two);
            this.Controls.Add(this.rb_Month);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rb_Month;
        private System.Windows.Forms.RadioButton rb_Two;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.RadioButton rb_Year;
        private System.Windows.Forms.Label Mady_by;
    }
}