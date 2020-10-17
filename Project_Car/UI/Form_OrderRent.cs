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
    public partial class Form_OrderRent : Form
    {

        Employee newemployee;

        public Form_OrderRent(Employee employee)
        {
            InitializeComponent();

            tbc_Order.ItemSize = new Size(0, 1);
            tbc_Order.SizeMode = TabSizeMode.Fixed;

            ClientArrToForm(null);
            OrderRentArrToForm();
            ProductArrToForm(null);
            CarExtraArrToForm(null);

            dtp_To.Value = DateTime.Now.AddDays(1);
            newemployee = employee.CreateEmployee();
        }

        #region Button

        private void btn_FilterClient_Click(object sender, EventArgs e)
        {
            Form_FilterClient newform = new Form_FilterClient();
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listbox_Clients.DataSource = newform.GetClients();
            }
            newform.Close();
            newform.Dispose();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form_FilterOrderRent newform = new Form_FilterOrderRent();

            if (newform.ShowDialog() == DialogResult.OK)
            {
                listbox_Orders.DataSource = newform.GetOrderRent();
            }
            newform.Close();
            newform.Dispose();

        }

        private void btn_FilterCar_Click(object sender, EventArgs e)
        {
            Form_FilterOrderCar newform = new Form_FilterOrderCar("Rent");
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listbox_Cars.DataSource = newform.GetCars();
            }
            newform.Close();
            newform.Dispose();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                OrderRent orderRent = FormToOrderRent();

                OrderDetailsRentArr orderDetailsRentArr_New;
                OrderDetailsRentArr orderDetailsRentArr_Old = new OrderDetailsRentArr();

                ProductArr productArr = new ProductArr();
                productArr.FillRentAvailable(dtp_From.Value.Date, dtp_To.Value.Date);


                if (orderRent.Id == 0)
                {

                    if (productArr.IsContains(orderRent.Product))
                    {

                        orderRent.Product.Doesavailable = "InRent";

                        if (orderRent.Insert() && orderRent.Product.Update())
                        {
                            OrderRentArr orderRentArr = new OrderRentArr();
                            orderRentArr.Fill();
                            orderRent = orderRentArr.GetOrderRentWithMaxId();

                            orderDetailsRentArr_New = FormToOrderDetailsRentArr(orderRent);
                            orderDetailsRentArr_New.Insert();

                            CarExtraArr carExtraArrInOrder = orderDetailsRentArr_New.GetCarExtraArr();

                            carExtraArrInOrder.Update();

                            foreach (TabPage tp in this.tbc_Order.Controls)
                            {
                                ClearForm(tp);
                            }
                            LoadNew();

                            Form_Pay newform = new Form_Pay(orderRent);
                            Hide();
                            newform.ShowDialog();
                            Close();


                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("This car already in use", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (orderRent.Update())
                    {
                        orderDetailsRentArr_New = FormToOrderDetailsRentArr(orderRent);
                        orderDetailsRentArr_Old.Fill();
                        orderDetailsRentArr_Old = orderDetailsRentArr_Old.Filter(orderRent);

                        orderDetailsRentArr_Old.Delete();
                        orderDetailsRentArr_New.Insert();

                        (listbox_InOrder.DataSource as CarExtraArr).Update();
                        (listbox_Potential.DataSource as CarExtraArr).Update();


                        MessageBox.Show("Your Cerdit Card will be charged accordingly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (TabPage tp in this.tbc_Order.Controls)
                        {
                            ClearForm(tp);
                        }

                        LoadNew();


                    }
                }
            }
        }

        private void btn_FilterExtra_Click(object sender, EventArgs e)
        {
            Form_FilterExtra newform = new Form_FilterExtra();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listbox_Potential.DataSource = newform.GetExtras();
            }
            newform.Close();
            newform.Dispose();
        }

        private void btn_Extra_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            tbc_Order.SelectedIndex = 3;

        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            tbc_Order.SelectedIndex = 0;
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            tbc_Order.SelectedIndex = 1;

        }

        private void btn_Car_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            tbc_Order.SelectedIndex = 2;

        }

        #endregion

        #region Transfer Data

        private void ProductToForm(Product product)
        {
            lbl_IdtxtCar.Text = product.Id.ToString();
            txt_Type.Text = product.Model.Company.Name + " " + product.Model.Category.Name + " " + product.Model.Model;
            txt_LicenseNumber.Text = product.LicenseNumber;
            txt_Price.Text = product.Price.ToString();
        }

        private void ClientToForm(Client client)
        {
            string areacode = client.PhoneNumber.Substring(0, 3);
            string phone = client.PhoneNumber.Substring(3, 7);

            lbl_IdtxtClient.Text = client.Id.ToString();
            txt_FullName.Text = client.Fullname;
            txt_PhoneNumber.Text = areacode + "-" + phone;
            txt_Email.Text = client.Email;


            txt_Address.Text = client.City.Name + " " + client.Street.Name + " " + client.Number;

        }

        private void OrderRentToFrom(OrderRent orderRent)
        {
            lbl_Idtxt.Text = orderRent.Id.ToString();
            dtp_From.Value = orderRent.DateFrom.Date;
            dtp_To.Value = orderRent.DateTo.Date;
            txt_Comment.Text = orderRent.Comment;

        }

        private OrderRent FormToOrderRent()
        {
            OrderRent orderRent = new OrderRent();


            orderRent.Id = int.Parse(lbl_Idtxt.Text);
            orderRent.DateFrom = dtp_From.Value.Date;
            orderRent.DateTo = dtp_To.Value.Date;
            orderRent.Comment = txt_Comment.Text;

            double NumDays = (orderRent.DateTo.Date - orderRent.DateFrom.Date).TotalDays;

            orderRent.Client = listbox_Clients.SelectedItem as Client;
            orderRent.Product = listbox_Cars.SelectedItem as Product;
            if (orderRent.Product == null)
            {
                orderRent.Product = (listbox_Orders.SelectedItem as OrderRent).Product;
            }
            orderRent.Employee = newemployee;


            orderRent.TotalPrice = orderRent.Product.Price * (int)NumDays + GetPriceCarExtra();

            return orderRent;
        }

        private void ProductArrToForm(Product curProduct)
        {

            ProductArr productArr = new ProductArr();
            // productArr.FillRentAvailableNew();
            //productArr.FillRent();
            productArr.FillRentAvailable(dtp_From.Value.Date, dtp_To.Value.Date);


            listbox_Cars.DataSource = productArr;

            if (productArr != null)
            {
                listbox_Cars.ValueMember = "ID";
                listbox_Cars.DisplayMember = "FullModel";
            }

            if (curProduct != null)
            {
                listbox_Cars.SelectedValue = curProduct.Id;
            }

        }

        private void ClientArrToForm(Client curClient)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            listbox_Clients.DataSource = clientArr;

            listbox_Clients.ValueMember = "ID";
            listbox_Clients.DisplayMember = "FullName";

            if (curClient != null)
            {
                listbox_Clients.SelectedValue = curClient.Id;
            }
        }

        private void OrderRentArrToForm()
        {
            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            listbox_Orders.DataSource = orderRentArr;

            listbox_Orders.ValueMember = "Id";
            listbox_Orders.DisplayMember = "FullName";
        }

        private void CarExtraArrToForm(CarExtraArr carExtraArr, ListBox listBox)
        {
            listBox.DataSource = null;


            if (carExtraArr == null)
            {
                carExtraArr = new CarExtraArr();
                carExtraArr.Fill();
            }

            listBox.DataSource = carExtraArr;

        }

        private void CarExtraArrToForm(CarExtra curCarExtra)
        {
            CarExtraArr carExtraArr = new CarExtraArr();
            carExtraArr.Fill();

            listbox_Potential.DataSource = carExtraArr;

            listbox_Potential.ValueMember = "Id";
            listbox_Potential.DisplayMember = "FullExtra";

            if (curCarExtra != null)
            {
                listbox_Potential.SelectedValue = curCarExtra.Id;
            }
        }

        private void listbox_Clients_DoubleClick(object sender, EventArgs e)
        {


            ClientToForm(listbox_Clients.SelectedItem as Client);
        }

        private void listbox_Cars_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listbox_Cars.SelectedItem as Product);
        }

        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            CarExtraArr carExtraArr = null;

            //מוצאים את הפריט הנבחר

            object selectedItem = listBox_From.SelectedItem;

            if (isToOrder)
            {
                (selectedItem as CarExtra).Count--;
            }

            else
            {
                (selectedItem as CarExtra).Count++;
            }

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים

            if (listBox_To.DataSource != null)
                carExtraArr = listBox_To.DataSource as CarExtraArr;
            else
                carExtraArr = new CarExtraArr();

            carExtraArr.Add(selectedItem);
            CarExtraArrToForm(carExtraArr, listBox_To);


            ///הסרת הפריט הנבחרים מרשימת הפריטים הנבחרים

            carExtraArr = listBox_From.DataSource as CarExtraArr;
            carExtraArr.Remove(selectedItem);
            CarExtraArrToForm(carExtraArr, listBox_From);
        }

        private void listbox_Potential_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listbox_Potential, listbox_InOrder, true);
        }

        private void listbox_InOrder_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listbox_InOrder, listbox_Potential, false);


        }

        private void listbox_Orders_DoubleClick(object sender, EventArgs e)
        {
            OrderRent orderRent = listbox_Orders.SelectedItem as OrderRent;
            OrderRentToFrom(orderRent);
            ClientToForm(orderRent.Client);
            ProductToForm(orderRent.Product);

            listbox_Clients.SelectedValue = orderRent.Client.Id;
            listbox_Cars.SelectedValue = orderRent.Product.Id;

            CarExtraArr carExtraArrInOrder = new CarExtraArr();

            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();
            orderDetailsRentArr.Fill();

            orderDetailsRentArr = orderDetailsRentArr.Filter(orderRent);

            carExtraArrInOrder = orderDetailsRentArr.GetCarExtraArr();
            CarExtraArrToForm(carExtraArrInOrder, listbox_InOrder);

            CarExtraArr carExtraArrNotInOrder = new CarExtraArr();
            carExtraArrNotInOrder.Fill();

            carExtraArrNotInOrder.Remove(carExtraArrInOrder);
            CarExtraArrToForm(carExtraArrNotInOrder, listbox_Potential);
        }

        private OrderDetailsRentArr FormToOrderDetailsRentArr(OrderRent curOrder)
        {
            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();

            OrderDetailsRent orderDetailsRent;

            for (int i = 0; i < listbox_InOrder.Items.Count; i++)
            {
                orderDetailsRent = new OrderDetailsRent();
                orderDetailsRent.OrderRent = curOrder;
                orderDetailsRent.CarExtra = listbox_InOrder.Items[i] as CarExtra;

                orderDetailsRentArr.Add(orderDetailsRent);
            }

            return orderDetailsRentArr;
        }

        public CarExtraArr FormToCarExtraArr()
        {
            CarExtraArr carExtraArr = listbox_InOrder.DataSource as CarExtraArr;
            return carExtraArr;
        }

        #endregion

        #region Clear
        private void ClearForm(TabPage tp)
        {


            foreach (Control ctrl in tp.Controls)
            {

                if (ctrl is Label)
                {
                    if (ctrl.Name.StartsWith("lbl_Idtxt"))
                    {
                        ctrl.Text = "0";
                    }

                    else if (ctrl.Name.StartsWith("txt_"))
                    {
                        ctrl.Text = "";
                    }


                    else if (ctrl.Name.StartsWith("lbl_Error"))
                    {
                        ctrl.Visible = false;
                    }

                    else if (ctrl.Name.StartsWith("asterix_") || ctrl.Name.StartsWith("lbl_Headline"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }


                }

                else if (ctrl is DateTimePicker)
                {

                    dtp_From.MinDate = DateTimePicker.MinimumDateTime;
                    dtp_From.MaxDate = DateTimePicker.MaximumDateTime;
                    dtp_To.MinDate = DateTimePicker.MinimumDateTime;
                    dtp_To.MaxDate = DateTimePicker.MaximumDateTime;
                    (ctrl as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

        private void ClearError(TabPage tp)
        {

            foreach (Control ctrl in tp.Controls)
            {
                if (ctrl is Label)
                {

                    if (ctrl.Name.StartsWith("lbl_Error"))
                    {
                        ctrl.Visible = false;
                    }
                }
            }




        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in this.tbc_Order.Controls)
            {
                ClearForm(tp);
            }

            LoadNew();

            //ClearForm(tp_Car);
            //ClearForm(tp_Client);
            //ClearForm(tp_Design);
            //ClearForm(tp_OrderDetails);

        }

        private void InitForm(TabPage tp)
        {

            foreach (Control ctrl in tp.Controls)
            {
                if (ctrl is Label)
                {

                    if (ctrl.Name.StartsWith("asterix_"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }

                    else if (ctrl.Name.StartsWith("lbl_Headline"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }


                }
            }


        }

        private void LoadNew()
        {
            ClientArrToForm(null);
            ProductArrToForm(null);
            OrderRentArrToForm();

            CarExtraArrToForm(null, listbox_Potential);

            listbox_InOrder.DataSource = null;

            dtp_To.Value = DateTime.Now.AddDays(1);

        }

        #endregion

        #region Label

        private void lbl_HeadlineExtra_Click(object sender, EventArgs e)
        {
            Form_CarExtra newform = new Form_CarExtra(newemployee);
            newform.ShowDialog();
            CarExtraArrToForm(newform.SelectedCarExtra);
        }

        private void lbl_HeadlineCar_Click(object sender, EventArgs e)
        {
            Form_Product newform = new Form_Product(newemployee);
            newform.ShowDialog();
            ProductArrToForm(newform.SelectedProduct);
        }

        private void lbl_HeadlineClient_Click(object sender, EventArgs e)
        {
            Form_Client newform = new Form_Client(newemployee);
            newform.ShowDialog();
            ClientArrToForm(newform.SelectedClient);
        }

        #endregion

        private bool CheckForm()
        { //בודק האם הנתונים שהקושו חוקיים 
            bool flag = true;

            foreach (TabPage tp in this.tbc_Order.Controls)
            {
                InitForm(tp);
                ClearError(tp);
            }


            #region DateFrom
            if (dtp_From.Checked == false)
            {
                flag = false;
                asterix_DateFrom.ForeColor = Color.Red;
                lbl_ErrorDateFrom.Visible = true;
            }

            #endregion

            #region DateTo
            if (dtp_To.Checked == false)
            {
                flag = false;
                asterix_DateTo.ForeColor = Color.Red;
                lbl_ErrorDateTo.Visible = true;
            }
            #endregion

            #region Dates
            if (dtp_From.Value > dtp_To.Value)
            {
                flag = false;
                asterix_DateTo.ForeColor = Color.Red;
                lbl_ErrorDateTo.Visible = true;
                asterix_DateFrom.ForeColor = Color.Red;
                lbl_ErrorDateFrom.Visible = true;
            }

            #endregion

            #region Car
            if (lbl_IdtxtCar.Text == "0")
            {
                flag = false;
                lbl_HeadlineCar.ForeColor = Color.Red;
            }
            #endregion

            #region Client
            if (lbl_IdtxtClient.Text == "0")
            {
                flag = false;
                lbl_HeadlineClient.ForeColor = Color.Red;

            }
            #endregion


            return flag;
        }

        public void MovePanel(Button b1)
        {
            pnl_Options.Focus();

            pnl_Cur.Visible = true;
            pnl_Cur.Width = b1.Width;
            pnl_Cur.Left = b1.Left;


        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            //  dtp_To.MinDate = dtp_From.Value;
            ProductArrToForm(null);

        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            //  dtp_From.MaxDate = dtp_To.Value;
            ProductArrToForm(null);

        }

        public int GetPriceCarExtra()
        {
            CarExtraArr carExtraArr = FormToCarExtraArr();
            if (carExtraArr != null)
            {
                return carExtraArr.Price();
            }
            return 0;
        }


        private void btn_Pay_Click(object sender, EventArgs e)
        {
            Form_Pay newform = new Form_Pay(listbox_Orders.SelectedItem as OrderRent);
            newform.ShowDialog();
        }
    }
}
