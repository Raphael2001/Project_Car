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
    public partial class Form_CarsInRent : Form
    {
        Employee newemployee;

        public Form_CarsInRent(Employee employee)
        {
            InitializeComponent();

            if (employee != null)
            {
                newemployee = employee.CreateEmployee();
            }

            CarsArrToForm(null, DateTime.Now.Date);
        }

        private void OrderRentToForm(OrderRent orderRent)
        {
            lbl_Idtxt.Text = orderRent.Id.ToString();
            txt_Type.Text = orderRent.Product.Model.Company.Name + " " +
                orderRent.Product.Model.Category.Name + " " + orderRent.Product.Model.Model;
            txt_LicenseNumber.Text = orderRent.Product.LicenseNumber;
            txt_FullName.Text = orderRent.Client.Fullname;

        }

        private void CarsArrToForm(OrderRent curCar)
        {

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();
            orderRentArr = orderRentArr.FilterNoReturned();


            listbox_Cars.DataSource = orderRentArr;

            if (listbox_Cars.DataSource != null)
            {
                listbox_Cars.ValueMember = "ID";
                listbox_Cars.DisplayMember = "FullOrderRent";
            }


            if (curCar != null)
            {
                listbox_Cars.SelectedValue = curCar.Product.Id;
            }

        }

        private void CarsArrToForm(OrderRent curCar, DateTime dateTime)
        {

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();
            orderRentArr = orderRentArr.FilterNoReturned();
            orderRentArr = orderRentArr.Filter(null, null, dateTime);

            listbox_Cars.DataSource = orderRentArr;

            if (orderRentArr.Count > 0)
            {

                if (listbox_Cars.DataSource != null)
                {
                    listbox_Cars.ValueMember = "ID";
                    listbox_Cars.DisplayMember = "FullOrderRent";
                }

                if (curCar != null)
                {
                    listbox_Cars.SelectedValue = curCar.Product.Id;
                }
            }

        }

        private void listbox_Cars_DoubleClick(object sender, EventArgs e)
        {
            OrderRentToForm(listbox_Cars.SelectedItem as OrderRent);
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form_FilterCarsInRent newform = new Form_FilterCarsInRent();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listbox_Cars.DataSource = newform.GetCars();

                if (newform.GetCars().Count > 0)
                {
                    if (listbox_Cars.DataSource != null)
                    {
                        listbox_Cars.ValueMember = "ID";
                        listbox_Cars.DisplayMember = "FullOrderRent";
                    }
                }
            }
            newform.Close();
            newform.Dispose();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            OrderRent orderRent = (listbox_Cars.SelectedItem as OrderRent);

            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();
            orderDetailsRentArr.Fill();

            CarExtraArr carExtraArr = orderDetailsRentArr.GetCarExtraArrByOrder(orderRent);

            foreach (CarExtra carExtra in carExtraArr)
            {
                carExtra.Count += 1;
            }

            orderRent.Product.Doesavailable = "";
            if (MessageBox.Show("Are you sure you want to return this car?", "Returnning car",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (orderRent.Product.Update())
                {
                    carExtraArr.Update();
                    CarsArrToForm(null);
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {


            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is Label)
                {
                    if (ctrl.Name.StartsWith("lbl_Idtxt"))
                    {
                        ctrl.Text = "0";
                    }

                    if (ctrl.Name.StartsWith("txt_"))
                    {
                        ctrl.Text = "";
                    }
                }

                else if (ctrl is DateTimePicker)
                {
                    (ctrl as DateTimePicker).Value = DateTime.Now;
                }
            }
        }


    }
}
