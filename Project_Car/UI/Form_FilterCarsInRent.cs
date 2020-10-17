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
    public partial class Form_FilterCarsInRent : Form
    {
        public Form_FilterCarsInRent()
        {
            InitializeComponent();

            ProductArrToForm(null);
            ClientArrToForm(null);
        }

        #region KeyBorad
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsengsLetter(e.KeyChar) && !IsENGBLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
                e.KeyChar = char.MinValue;
        }

        private bool IsengsLetter(char c)
        {// אותיות קטנות באנגלית
            return (c >= 'a' && c <= 'z');
        }

        private bool IsENGBLetter(char c)
        {// אותיות גדולות באנגלית
            return (c >= 'A' && c <= 'Z');
        }

        private void textBox_Digit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        #endregion

        private void Form_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            Close();
        }

        public OrderRentArr GetCars()
        {
            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();
            orderRentArr = orderRentArr.FilterNoReturned();
            orderRentArr = orderRentArr.GetProductsWithLastDate();
            

            Client client = null;
            Product product = null;
            DateTime dateTime = dtp_DateTo.Value;

            if (cmb_Client.SelectedIndex != -1)
            {
                client = cmb_Client.SelectedItem as Client;
            }

            if (cmb_Product.SelectedIndex != -1)
            {
                product = cmb_Product.SelectedItem as Product;
            }

            if (rdb_Dates.Checked == true)
            {
                orderRentArr = orderRentArr.Filter(client, product);

                return orderRentArr;
            }

            orderRentArr = orderRentArr.Filter(client, product, dateTime);

            return orderRentArr;
        }

        private void ProductArrToForm(Product curProduct)
        {
            ProductArr productArr = new ProductArr();
            productArr.FillRent();


            cmb_Product.DataSource = productArr;

            cmb_Product.ValueMember = "ID";
            cmb_Product.DisplayMember = "FullModel";

            if (curProduct != null)
            {
                cmb_Product.SelectedValue = curProduct.Id;
            }
            else
            {
                cmb_Product.SelectedIndex = -1;

            }
        }

        private void ClientArrToForm(Client curClient)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            cmb_Client.DataSource = clientArr;

            cmb_Client.ValueMember = "ID";
            cmb_Client.DisplayMember = "FullName";

            if (curClient != null)
            {
                cmb_Client.SelectedValue = curClient.Id;
            }
            else
            {
                cmb_Client.SelectedIndex = -1;

            }
        }

    }
}
