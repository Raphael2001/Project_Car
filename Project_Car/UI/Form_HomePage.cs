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

namespace Project_Car.UI
{
    public partial class Form_HomePage : Form
    {
        Employee newemployee = new Employee();

        public Form_HomePage()
        {
            InitializeComponent();
        }

        private void pb_Client_Click(object sender, EventArgs e)
        {
            Form_Client newform = new Form_Client(newemployee);
            Hide();
            newform.ShowDialog();
            Close();

        }

        private void pb_City_Click(object sender, EventArgs e)
        {
            Form_City newform = new Form_City(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        public Form_HomePage(Employee employee)
        {
            InitializeComponent();
           

            newemployee = employee.CreateEmployee();
            if (IsManager(newemployee))
            {
                pb_City.Enabled = true;
                pb_Employee.Enabled = true;
                pb_Role.Enabled = true;
                pb_Street.Enabled = true;
            }
            else
            {
                pb_City.Enabled = false;
                pb_Employee.Enabled = false;
                pb_Role.Enabled = false;
                pb_Street.Enabled = false;

            }

            lbl_HeadLine.Text = "Hello" + " " + newemployee.Fullname;
            lbl_HeadLine.Top = this.Top - (this.Top / 5);
            lbl_HeadLine.Left = this.Width / 2 - lbl_HeadLine.Width / 2;

        }

        private void pb_Password_Click(object sender, EventArgs e)
        {
            Form_PasswordUpdate newform = new Form_PasswordUpdate(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_Employee_Click(object sender, EventArgs e)
        {
            Form_Employee newform = new Form_Employee(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_Street_Click(object sender, EventArgs e)
        {
            Form_Street newform = new Form_Street(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_Role_Click(object sender, EventArgs e)
        {
            Form_Role newform = new Form_Role(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private bool IsManager(Employee employee)
        {
            if (employee.Role.JobTitle == "Manager" || employee.Role.JobTitle == "CEO")
            {
                return true;
            }
            return false;
        }

        private void pb_Car_Click(object sender, EventArgs e)
        {
            Form_Product newform = new Form_Product(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_Company_Click(object sender, EventArgs e)
        {
            Form_Company newform = new Form_Company(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_Engine_Click(object sender, EventArgs e)
        {
            Form_Engine newform = new Form_Engine(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_Category_Click(object sender, EventArgs e)
        {
            Form_Category newform = new Form_Category(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void pb_AllCars_Click(object sender, EventArgs e)
        {
            //Form_MidView newform = new Form_MidView(newemployee);
            //Hide();
            //newform.ShowDialog();
            //Close();
        }

        private void pb_Sale_Click(object sender, EventArgs e)
        {
            Form_OrderBuy newform = new Form_OrderBuy(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }
    }
}
