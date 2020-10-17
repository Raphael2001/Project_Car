namespace Project_Car.UI
{
    partial class Form_CarPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CarPhoto));
            this.pgb_LoadPhoto = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_PhotoCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PhotoCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_LoadPhoto
            // 
            this.pgb_LoadPhoto.Location = new System.Drawing.Point(12, 586);
            this.pgb_LoadPhoto.Name = "pgb_LoadPhoto";
            this.pgb_LoadPhoto.Size = new System.Drawing.Size(1070, 33);
            this.pgb_LoadPhoto.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_PhotoCar
            // 
            this.pb_PhotoCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_PhotoCar.Image = global::Project_Car.Properties.Resources.Loading12;
            this.pb_PhotoCar.Location = new System.Drawing.Point(0, 0);
            this.pb_PhotoCar.Name = "pb_PhotoCar";
            this.pb_PhotoCar.Size = new System.Drawing.Size(1094, 631);
            this.pb_PhotoCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PhotoCar.TabIndex = 0;
            this.pb_PhotoCar.TabStop = false;
            // 
            // Form_CarPhoto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1094, 631);
            this.Controls.Add(this.pgb_LoadPhoto);
            this.Controls.Add(this.pb_PhotoCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CarPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Photo";
            this.Load += new System.EventHandler(this.Form_CarPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PhotoCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_PhotoCar;
        private System.Windows.Forms.ProgressBar pgb_LoadPhoto;
        private System.Windows.Forms.Timer timer1;
    }
}