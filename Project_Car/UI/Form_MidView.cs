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
    public partial class Form_MidView : Form
    {
        Employee newemployee = new Employee();
        Form_Home form;
        public Form_MidView(Employee emplooye, Form_Home f1)
        {
            InitializeComponent();

            form = f1;

            newemployee = emplooye.CreateEmployee();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            Form_ViewCarForBuy newform = new Form_ViewCarForBuy(newemployee, form);
            form.OpenForm(newform);
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            Form_ViewCarForRent newform = new Form_ViewCarForRent(newemployee, form);
            form.OpenForm(newform);
        }
    }
}
