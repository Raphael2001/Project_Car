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
    public partial class Form_MidReports : Form
    {
        public Form_MidReports()
        {
            InitializeComponent();
        }

        private void Btn_Table_Click(object sender, EventArgs e)
        {
            Form_MidTableReport newform = new Form_MidTableReport(newemployee, form);
            form.OpenForm(newform);
        }

        private void Btn_Graphic_Click(object sender, EventArgs e)
        {
            Form_MidReport newform = new Form_MidReport(newemployee, form);
            form.OpenForm(newform);
        }

        Employee newemployee;
        Panel panel3;
        Form_Home form;
        public Form_MidReports(Employee employee, Form_Home f1)
        {
            InitializeComponent();

            panel3 = f1.pnl_Background;
            form = f1;


            newemployee = employee.CreateEmployee();
        }

        


    }
}
