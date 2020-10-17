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
    public partial class Form_MidTableReport : Form
    {

        Employee newemployee = new Employee();
        Form_Home form;
        public Form_MidTableReport(Employee emplooye, Form_Home f1)
        {
            InitializeComponent();

            form = f1;

            newemployee = emplooye.CreateEmployee();
        }
       

        private void Btn_PhoneClients_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(1);
            form.OpenForm(newform);

        }

        private void Btn_CarExtraCount_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(2);
            form.OpenForm(newform);
        }

        private void Btn_CarsBuy_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(3);
            form.OpenForm(newform);
        }

        private void Btn_CarsRent_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(4);
            form.OpenForm(newform);

        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(5);
            form.OpenForm(newform);


        }

        private void Btn_Design_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(6);
            form.OpenForm(newform);

        }

        private void Btn_Rent_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(7);
            form.OpenForm(newform);
        }

        private void Btn_TopRent_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(9);
            form.OpenForm(newform);
        }

        private void Btn_TopBuy_Click(object sender, EventArgs e)
        {
            Form_TableReport newform = new Form_TableReport(8);
            form.OpenForm(newform);
        }
    }
}
