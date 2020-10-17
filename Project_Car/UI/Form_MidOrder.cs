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
    public partial class Form_MidOrder : Form
    {
        Employee newemployee;
        Panel panel3;
        Form_Home form;
        public Form_MidOrder(Employee employee, Form_Home f1)
        {
            InitializeComponent();

            panel3 = f1.pnl_Background;
            form = f1;


            newemployee = employee.CreateEmployee();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            
            Form_OrderBuy newform = new Form_OrderBuy(newemployee);
            form.OpenForm(newform);
            
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            Form_OrderRent newform = new Form_OrderRent(newemployee);
            form.OpenForm(newform); 

        }



    }
}
