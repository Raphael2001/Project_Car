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
    public partial class Form_MidReport : Form
    {

        Employee newemployee = new Employee();
        Form_Home form;
        public Form_MidReport(Employee emplooye, Form_Home f1)
        {
            InitializeComponent();

            form = f1;

            newemployee = emplooye.CreateEmployee();
        }

        private void btn_RentCar_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(4);
            form.OpenForm(newform);

        }

        private void btn_RentCarExtra_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(2);
            form.OpenForm(newform);
        }

        private void btn_BuyCar_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(3);
            form.OpenForm(newform);

        }

        private void btn_BuyCarExtra_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(1);
            form.OpenForm(newform);
        }

        private void btn_Design_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(5);
            form.OpenForm(newform);
        }

        private void Btn_TopBuy_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(6);
            form.OpenForm(newform);
        }

        private void Btn_TopRent_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(7);
            form.OpenForm(newform);
        }

        private void Btn_MonthBuy_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(8);
            form.OpenForm(newform);
        }

        private void Btn_MonthRent_Click(object sender, EventArgs e)
        {
            Form_Report newform = new Form_Report(9);
            form.OpenForm(newform);
        }
    }
}
