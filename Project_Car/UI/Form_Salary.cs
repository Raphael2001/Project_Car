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
    public partial class Form_Salary : Form
    {
        Employee newemployee;
        public Form_Salary(Employee employee)
        {
            InitializeComponent();

            dtp_Time.CustomFormat = "MM/yyyy";

            newemployee = employee.CreateEmployee();

            EmployeeToForm(newemployee);

            EmployeeArrToForm(newemployee);

            if (employee.Role.JobTitle == "Manager" || employee.Role.JobTitle == "CEO")
            {
                cmb_Employee.Enabled = true;

            }
            else
            {
                cmb_Employee.Enabled = false;
            }
        }

        private void EmployeeToForm(Employee employee)
        {// מעביר את עובד לפורם

            lbl_Idtxt.Text = employee.Id.ToString();
            lbl_FullName.Text = "Full Name : " + employee.Fullname;
            lbl_Role.Text = "Role : " + employee.Role.JobTitle;
            lbl_Salary.Text = "Salary : " + employee.Salary.ToString();
            lbl_Bonus.Text = "Bonus : " + GetBonus(dtp_Time.Value, employee);
            lbl_Total.Text = "Total :" + GetTotal(employee);

        }

        private void EmployeeArrToForm(Employee curemployee)
        {
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            cmb_Employee.ValueMember = "Id";
            cmb_Employee.DisplayMember = "FullRole";

            cmb_Employee.DataSource = employeeArr;

            if (curemployee != null)
            {
                cmb_Employee.SelectedValue = curemployee.Id;
            }
        }

        public double GetBonus(DateTime dateTime, Employee employee)
        {
            double Bonus = 0;
            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            orderBuyArr = orderBuyArr.Filter(employee, dateTime);
            orderRentArr = orderRentArr.Filter(employee, dateTime);

            for (int i = 0; i < orderBuyArr.Count; i++)
            {
                Bonus += (orderBuyArr[i] as OrderBuy).TotalPrice * 0.01;
            }
            for (int i = 0; i < orderRentArr.Count; i++)
            {
                Bonus += (orderRentArr[i] as OrderRent).TotalPrice * 0.01;
            }


            return Bonus;
        }

        private void dtp_Time_ValueChanged(object sender, EventArgs e)
        {
            lbl_Bonus.Text = "Bonus : " + GetBonus(dtp_Time.Value, cmb_Employee.SelectedItem as Employee);
            lbl_Total.Text = "Total :" + GetTotal(cmb_Employee.SelectedItem as Employee);


        }

        private void cmb_Employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EmployeeToForm(cmb_Employee.SelectedItem as Employee);

        }
        public int GetTotal(Employee employee)
        {
            return (int)GetBonus(dtp_Time.Value, employee) + employee.Salary;
        }
    }
}
