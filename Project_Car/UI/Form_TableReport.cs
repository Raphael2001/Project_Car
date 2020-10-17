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
    public partial class Form_TableReport : Form
    {
        int num;
        public Form_TableReport(int i)
        {
            InitializeComponent();

            num = i;
            GetFun(num);

            lbl_HeadLine.Left = (this.Width / 4);
            btn_Filter.Left = (this.Width / 4);
        }


        #region Client
        public void PhoneClients()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterClient_Click);
            lbl_HeadLine.Text = "Clients";
            ClientArrToForm(null);
        }

        private void ClientArrToForm(Client curClient)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            listBox_Data.DataSource = clientArr;

            listBox_Data.ValueMember = "ID";
            listBox_Data.DisplayMember = "PhoneName";

            if (curClient != null)
            {
                listBox_Data.SelectedValue = curClient.Id;
            }
        }

        private void btn_FilterClient_Click(object sender, EventArgs e)
        {
            Form_FilterClient newform = new Form_FilterClient();
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listBox_Data.DataSource = newform.GetClients(listBox_Data.DataSource as ClientArr);
            }
            newform.Close();
            newform.Dispose();


        }


        public void TopClients(bool flg)
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterClient_Click);
            lbl_HeadLine.Text = "Top Clients";
            if (flg)
            {
                TopOrderBuyClients();

            }
            else
            {
                TopOrderRentClients();
            }
        }

        private void TopOrderBuyClients()
        {

            ClientArr clientArr_new = new ClientArr();
            OrderBuyArr orderArr = new OrderBuyArr();
            orderArr.Fill();

            ClientArr clientArr = orderArr.GetClientArr();
            foreach (Client c in clientArr)
            {
                c.Count = orderArr.Filter(c).Count;
                clientArr_new.Add(c);
            }
            clientArr_new.Sort();

            clientArr = new ClientArr();
            for (int i = 0; i < 5; i++)
            {
                clientArr.Add(clientArr_new[i]);
            }
            listBox_Data.DataSource = clientArr;
        }

        private void TopOrderRentClients()
        {
            ClientArr clientArr_new = new ClientArr();
            OrderRentArr orderArr = new OrderRentArr();
            orderArr.Fill();

            ClientArr clientArr = orderArr.GetClientArr();
            foreach (Client c in clientArr)
            {
                c.Count = orderArr.Filter(c).Count;
                clientArr_new.Add(c);
            }
            clientArr_new.Sort();

            clientArr = new ClientArr();
            for (int i = 0; i < 5; i++)
            {
                clientArr.Add(clientArr_new[i]);
            }
            listBox_Data.DataSource = clientArr;
        }

        #endregion

        #region CarExtra
        public void CarExtraCount()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterExtra_Click);
            lbl_HeadLine.Text = "CarExtra";
            CarExtraArrToForm(null);
        }

        private void CarExtraArrToForm(CarExtra curcarExtra)
        {
            CarExtraArr carExtraArr = new CarExtraArr();
            carExtraArr.Fill();

            carExtraArr = carExtraArr.Filter(40);

            listBox_Data.DataSource = carExtraArr;

            listBox_Data.ValueMember = "Id";
            listBox_Data.DisplayMember = "FullExtra";


            if (curcarExtra != null)
            {
                listBox_Data.SelectedValue = curcarExtra.Id;
            }
        }

        private void btn_FilterExtra_Click(object sender, EventArgs e)
        {
            Form_FilterExtra newform = new Form_FilterExtra(listBox_Data.DataSource as CarExtraArr);
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listBox_Data.DataSource = newform.GetExtras(listBox_Data.DataSource as CarExtraArr);
            }
            newform.Close();
            newform.Dispose();
        }

        #endregion

        #region Products
        public void ProductsBuy()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterBuy_Click);
            lbl_HeadLine.Text = "Available Cars (Buy)";
            ProductArrBuyToForm();
        }

        private void ProductArrBuyToForm()
        {
            ProductArr productArr = new ProductArr();
            productArr.FillBuy();

            productArr = productArr.Filter("");

            listBox_Data.DataSource = productArr;

            listBox_Data.DisplayMember = "Model_V2";



        }

        public void ProductsRent()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterRent_Click);
            lbl_HeadLine.Text = "Available Cars (Rent)";
            ProductArrRentToForm();
        }

        private void ProductArrRentToForm()
        {
            ProductArr productArr = new ProductArr();
            productArr.FillRent();

            productArr = productArr.Filter("");

            listBox_Data.DataSource = productArr;

            listBox_Data.DisplayMember = "Model_V2";

        }

        private void btn_FilterRent_Click(object sender, EventArgs e)
        {
            Form_FilterProduct newform = new Form_FilterProduct("Rent");
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listBox_Data.DataSource = newform.GetCars();
            }
            newform.Close();
            newform.Dispose();


        }

        private void btn_FilterBuy_Click(object sender, EventArgs e)
        {
            Form_FilterProduct newform = new Form_FilterProduct("Buy");
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listBox_Data.DataSource = newform.GetCars();
            }
            newform.Close();
            newform.Dispose();


        }

        public void ProductsInRent()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterInRent_Click);
            lbl_HeadLine.Text = "Cars In Rent";
            CarsArrToForm(null);
        }

        private void CarsArrToForm(OrderRent curCar)
        {

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();
            orderRentArr = orderRentArr.FilterNoReturned();


            listBox_Data.DataSource = orderRentArr;


            if (orderRentArr.Count > 0)
            {

                if (listBox_Data.DataSource != null)
                {
                    listBox_Data.ValueMember = "ID";
                    listBox_Data.DisplayMember = "FullOrderRent";
                }

                if (curCar != null)
                {
                    listBox_Data.SelectedValue = curCar.Product.Id;
                }
            }

        }

        private void btn_FilterInRent_Click(object sender, EventArgs e)
        {
            Form_FilterCarsInRent newform = new Form_FilterCarsInRent();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listBox_Data.DataSource = newform.GetCars();

                if (newform.GetCars().Count > 0)
                {
                    if (listBox_Data.DataSource != null)
                    {
                        listBox_Data.ValueMember = "ID";
                        listBox_Data.DisplayMember = "FullOrderRent";
                    }
                }
            }
            newform.Close();
            newform.Dispose();
        }

        #endregion

        #region Employee
        public void EmployeeSalary()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterEmployee_Click);
            lbl_HeadLine.Text = "Employee";
            EmployeeArrToForm();
        }
        private void EmployeeArrToForm()
        {
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.FillNew();


            listBox_Data.DataSource = employeeArr;

            listBox_Data.ValueMember = "Id";
            listBox_Data.DisplayMember = "FullEmployee";


        }

        private void btn_FilterEmployee_Click(object sender, EventArgs e)
        {


            Form_FilterEmployee newform = new Form_FilterEmployee();
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listBox_Data.DataSource = newform.GetEmployees_V2();

            }
            newform.Close();
            newform.Dispose();


        }
        #endregion

        #region Design
        public void Designs()
        {
            btn_Filter.Click += new EventHandler(this.btn_FilterDesign_Click);
            lbl_HeadLine.Text = "Designs";
            CarDesignArrToForm(null);
        }

        private void CarDesignArrToForm(CarDesign curCarDesign)
        {
            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();

            listBox_Data.ValueMember = "ID";
            listBox_Data.DisplayMember = "FullDesign";
            listBox_Data.DataSource = carDesignArr;

            if (curCarDesign != null)
            {
                listBox_Data.SelectedValue = curCarDesign.Id;
            }
        }

        private void btn_FilterDesign_Click(object sender, EventArgs e)
        {
            Form_FilterDesign newform = new Form_FilterDesign();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listBox_Data.DataSource = newform.GetDesigns();
            }
            newform.Close();
            newform.Dispose();
        }

        #endregion

        public void GetFun(int Num)
        {

            switch (Num)
            {
                case 1:
                    PhoneClients();
                    break;
                case 2:
                    CarExtraCount();
                    break;
                case 3:
                    ProductsBuy();
                    break;
                case 4:
                    ProductsRent();
                    break;
                case 5:
                    EmployeeSalary();
                    break;
                case 6:
                    Designs();
                    break;
                case 7:
                    ProductsInRent();
                    break;
                case 8:
                    TopClients(true);
                    break;
                case 9:
                    TopClients(false);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;

            }


        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            GetFun(num);
        }

        private void Form_TableReport_Load(object sender, EventArgs e)
        {

        }
    }
}
