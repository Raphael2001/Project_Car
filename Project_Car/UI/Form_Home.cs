using Project_Car.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Project_Car.UI
{
    public partial class Form_Home : Form
    {
        Employee newemployee = new Employee();

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();


        public Form_Home(Employee employee)
        {
            InitializeComponent();

            newemployee = employee.CreateEmployee();

            pnl_Options.BackColor = Color.FromArgb(41, 44, 51);

            lbl_HeadLine.Top = pnl_Background.Top - (pnl_Background.Top / 5);
            lbl_HeadLine.Left = (pnl_Background.Width / 5);
            lbl_HeadLine.Text = "Hello" + " " + newemployee.Fullname;

            if (IsManager(newemployee))
            {
                btn_CarExtra.Enabled = true;
                btn_Employee.Enabled = true;
                btn_Role.Enabled = true;

            }
            else
            {
                btn_CarExtra.Enabled = false;
                btn_Employee.Enabled = false;
                btn_Role.Enabled = false;

            }

            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            synthesizer.SpeakAsync("Hello" + " " + newemployee.Fullname);
            //     synthesizer.SpeakAsync("Welcome Yoni");

        }

        public Form_Home(Employee employee, bool b1)
        {
            MovePanel(btn_Product);

            Form_Product newform = new Form_Product(newemployee);
            //this.IsMdiContainer = true;
            newform.TopLevel = false;
            pnl_Background.Controls.Clear();
            pnl_Background.Controls.Add(newform);
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            newform.Show();

        }

        #region Button

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_Salary newform = new Form_Salary(newemployee);
            OpenForm(newform);
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_Client newform = new Form_Client(newemployee);
            OpenForm(newform);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_Product newform = new Form_Product(newemployee);
            OpenForm(newform);

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_Employee newform = new Form_Employee(newemployee);
            OpenForm(newform);

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_MidOrder newform = new Form_MidOrder(newemployee, this);
            OpenForm(newform);

        }

        private void btn_Password_Click(object sender, EventArgs e)
        {

            MovePanel(sender as Button);

            Form_PasswordUpdate newform = new Form_PasswordUpdate(newemployee);
            OpenForm(newform);
        }

        private void btn_Cars_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_MidView newform = new Form_MidView(newemployee, this);
            OpenForm(newform);

        }

        private void btn_Role_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_Role newform = new Form_Role(newemployee);
            OpenForm(newform);

        }

        private void btn_CarExtra_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_CarExtra newform = new Form_CarExtra(newemployee);
            OpenForm(newform);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            pnl_Options.Focus();

            Application.Exit();
        }

        private void btn_Design_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_CarDesign newform = new Form_CarDesign(newemployee);
            OpenForm(newform);
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_CarsInRent newform = new Form_CarsInRent(newemployee);
            OpenForm(newform);
        }

        private void btn_AddOns_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            Form_MidReports newform = new Form_MidReports(newemployee, this);
            OpenForm(newform);
        }
        #endregion

        private bool mouseDown;
        private Point lastLocation;

        private void pnl_Options_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnl_Options_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnl_Options_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, 
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();

            }
        }

        public void MovePanel(Button b1)
        {
            pnl_Options.Focus();

            pnl_Cur.Visible = true;
            pnl_Cur.Height = b1.Height;
            pnl_Cur.Top = b1.Top;


        }

        public void OpenForm(Form newform)
        {
            newform.TopLevel = false;
            pnl_Background.Controls.Clear();
            pnl_Background.Controls.Add(newform);
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Left = pnl_Background.Width / 2 - newform.Width / 2;
            newform.Top = pnl_Background.Height / 2 - newform.Height / 2;
            pnl_Background.BackColor = newform.BackColor;
            pnl_Background.BackgroundImage = null;
            newform.Show();
        }

        private bool IsManager(Employee employee)
        {
            if (employee.Role.JobTitle == "Manager" || employee.Role.JobTitle == "CEO")
            {
                return true;
            }
            return false;
        }

        Form_EmployeeDetails newform = new Form_EmployeeDetails();

        private void timer1_Tick(object sender, EventArgs e)
        {
            newform.Left += 10;
            if (newform.Left >= this.Right + 25)
            {
                timer1.Stop();
                this.TopMost = false;
            }
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            newform.Show();
            newform.lbl_User.Text = newemployee.Username.ToString();
            newform.lbl_Name.Text = newemployee.Fullname.ToString();
            newform.lbl_Email.Text = newemployee.Email.ToString();
            ChangeLoc(newform.lbl_User, newform);
            ChangeLoc(newform.lbl_Name, newform);
            ChangeLoc(newform.lbl_Email, newform);





            timer1.Start();
            this.TopMost = true;

        }

        public void ChangeLoc(Label l1, Form_EmployeeDetails f1)
        {
            l1.Left = f1.ClientSize.Width / 2 - l1.Width / 2;
        }

        private void Form_Home_LocationChanged(object sender, EventArgs e)
        {
            if (newform != null)
            {
                newform.Top = this.Top / 2 + newform.Top / 2;
                newform.Left = this.Left + 1250;
            }

        }


    }
}
