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
    public partial class Form_OrderBuy : Form
    {
        Employee newemployee;

        public Form_OrderBuy(Employee employee)
        {
            InitializeComponent();

            tbc_Order.ItemSize = new Size(0, 1);
            tbc_Order.SizeMode = TabSizeMode.Fixed;

            ClientArrToForm(null);
            OrderBuyArrToForm();
            ProductArrToForm(null);
            CarDesignArrToForm(null);
            CarExtraArrToForm(null, listbox_Potential);

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

        private void btn_FilterCar_Click(object sender, EventArgs e)
        {
            Form_FilterOrderCar newform = new Form_FilterOrderCar("Buy");
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
                OrderBuy orderBuy = FormToOrderBuy();
                OrderDetailsBuyArr orderDetailsBuyArr_New;
                OrderDetailsBuyArr orderDetailsBuyArr_Old = new OrderDetailsBuyArr();

                OrderBuyArr orderBuyArr_New = new OrderBuyArr();
                orderBuyArr_New.Fill();


                if (orderBuy.Id == 0)
                {
                    if (!orderBuyArr_New.DoesExist(orderBuy.Product))
                    {

                        if (orderBuy.Insert() && orderBuy.Product.Update())
                        {
                            OrderBuyArr orderBuyArr = new OrderBuyArr();
                            orderBuyArr.Fill();
                            orderBuy = orderBuyArr.GetOrderBuyWithMaxId();

                            orderDetailsBuyArr_New = FormToOrderDetailsBuyArr(orderBuy);
                            orderDetailsBuyArr_New.Insert();


                            CarExtraArr carExtraArrInOrder = orderDetailsBuyArr_New.GetCarExtraArr();
                            carExtraArrInOrder.Update();



                            foreach (TabPage tp in this.tbc_Order.Controls)
                            {
                                ClearForm(tp);
                            }
                            LoadNew();

                            Form_Pay newform = new Form_Pay(orderBuy);
                            newform.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("This car already sold", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (orderBuy.Update() && orderBuy.Product.Update())
                    {
                        orderDetailsBuyArr_New = FormToOrderDetailsBuyArr(orderBuy);
                        orderDetailsBuyArr_Old.Fill();
                        orderDetailsBuyArr_Old = orderDetailsBuyArr_Old.Filter(orderBuy);

                        orderDetailsBuyArr_Old.Delete();
                        orderDetailsBuyArr_New.Insert();

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

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form_FilterOrderBuy newform = new Form_FilterOrderBuy();
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listbox_Orders.DataSource = newform.GetOrderBuy();
            }
            newform.Close();
            newform.Dispose();
        }

        private void btn_FilterDesign_Click(object sender, EventArgs e)
        {
            Form_FilterDesign newform = new Form_FilterDesign();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listbox_Designs.DataSource = newform.GetDesigns();
            }
            newform.Close();
            newform.Dispose();
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

        private void btn_Design_Click(object sender, EventArgs e)
        {
            MovePanel(sender as Button);

            tbc_Order.SelectedIndex = 4;

        }

        #endregion

        #region Transfer Data

        private OrderBuy FormToOrderBuy()
        {
            OrderBuy orderBuy = new OrderBuy();

            orderBuy.Id = int.Parse(lbl_Idtxt.Text);
            orderBuy.DateOfBuy = dtp_DateBuy.Value.Date;
            orderBuy.Comment = txt_Comment.Text;

            orderBuy.Client = listbox_Clients.SelectedItem as Client;
            orderBuy.Product = listbox_Cars.SelectedItem as Product;
            if (orderBuy.Product == null)
            {
                orderBuy.Product = (listbox_Orders.SelectedItem as OrderBuy).Product;
            }
            orderBuy.Product.Doesavailable = "Sold";
            orderBuy.Employee = newemployee;
            orderBuy.CarDesign = listbox_Designs.SelectedItem as CarDesign;

            orderBuy.TotalPrice = orderBuy.Product.Price + orderBuy.CarDesign.BodyDesign.Price + orderBuy.CarDesign.CarColor.Price +
                orderBuy.CarDesign.ColorType.Price + GetPriceCarExtra();

            return orderBuy;
        }

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

            txt_Client.Text = client.Fullname;
            txt_Address.Text = client.City.Name + " " + client.Street.Name + " " + client.Number;

        }

        private void OrderBuyToForm(OrderBuy orderBuy)
        {
            lbl_Idtxt.Text = orderBuy.Id.ToString();
            dtp_DateBuy.Value = orderBuy.DateOfBuy;
            txt_Comment.Text = orderBuy.Comment;

        }

        private void DesignToForm(CarDesign carDesign)
        {
            lbl_IdtxtDesign.Text = carDesign.Id.ToString();
            txt_CarColor.Text = carDesign.CarColor.Name;
            txt_ColorType.Text = carDesign.ColorType.Name;
            txt_BodyDesign.Text = carDesign.BodyDesign.Name;
        }

        private void CarDesignArrToForm(CarDesign curCarDesign)
        {
            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();
            listbox_Designs.DataSource = carDesignArr;

            listbox_Designs.ValueMember = "Id";
            listbox_Designs.DisplayMember = "FullDesign";

            if (curCarDesign != null)
            {
                listbox_Designs.SelectedValue = curCarDesign.Id;
            }
        }

        private void ProductArrToForm(Product curProduct)
        {

            ProductArr productArr = new ProductArr();
            productArr.FillBuyAvailable();
            productArr.Sort();

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

        private void OrderBuyArrToForm()
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();

            listbox_Orders.DataSource = orderBuyArr;

            listbox_Orders.ValueMember = "Id";
            listbox_Orders.DisplayMember = "FullName";

        }

        private void listbox_Clients_DoubleClick(object sender, EventArgs e)
        {


            ClientToForm(listbox_Clients.SelectedItem as Client);
        }

        private void listbox_Cars_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listbox_Cars.SelectedItem as Product);
        }

        private void listbox_Orders_DoubleClick(object sender, EventArgs e)
        {
            OrderBuy orderBuy = listbox_Orders.SelectedItem as OrderBuy;
            OrderBuyToForm(orderBuy);
            ClientToForm(orderBuy.Client);
            ProductToForm(orderBuy.Product);
            DesignToForm(orderBuy.CarDesign);

            listbox_Clients.SelectedValue = orderBuy.Client.Id;
            listbox_Cars.SelectedValue = orderBuy.Product.Id;
            listbox_Designs.SelectedValue = orderBuy.CarDesign.Id;

            CarExtraArr carExtraArrInOrder = new CarExtraArr();

            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();
            orderDetailsBuyArr.Fill();

            orderDetailsBuyArr = orderDetailsBuyArr.Filter(orderBuy);

            carExtraArrInOrder = orderDetailsBuyArr.GetCarExtraArr();
            CarExtraArrToForm(carExtraArrInOrder, listbox_InOrder);

            CarExtraArr carExtraArrNotInOrder = new CarExtraArr();
            carExtraArrNotInOrder.Fill();

            carExtraArrNotInOrder.Remove(carExtraArrInOrder);
            CarExtraArrToForm(carExtraArrNotInOrder, listbox_Potential);

        }

        private void listbox_Potential_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listbox_Potential, listbox_InOrder, true);
        }

        private void listbox_InOrder_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listbox_InOrder, listbox_Potential, false);
        }

        private void listbox_Designs_DoubleClick(object sender, EventArgs e)
        {
            DesignToForm(listbox_Designs.SelectedItem as CarDesign);
        }

        private OrderDetailsBuyArr FormToOrderDetailsBuyArr(OrderBuy curOrder)
        {
            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();

            OrderDetailsBuy orderDetailsBuy;

            for (int i = 0; i < listbox_InOrder.Items.Count; i++)
            {
                orderDetailsBuy = new OrderDetailsBuy();
                orderDetailsBuy.OrderBuy = curOrder;
                orderDetailsBuy.CarExtra = listbox_InOrder.Items[i] as CarExtra;

                orderDetailsBuyArr.Add(orderDetailsBuy);
            }

            return orderDetailsBuyArr;
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
            CarDesignArrToForm(null);
            ProductArrToForm(null);
            OrderBuyArrToForm();

            CarExtraArrToForm(null, listbox_Potential);

            listbox_InOrder.DataSource = null;
        }
        #endregion

        #region Label

        private void lbl_HeadlineDesign_Click(object sender, EventArgs e)
        {
            Form_CarDesign newform = new Form_CarDesign(newemployee);
            newform.ShowDialog();
            CarDesignArrToForm(newform.SelectedDesign);
        }

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


            #region DateofBuy
            if (dtp_DateBuy.Checked == false)

            {
                flag = false;
                asterix_DateBuy.ForeColor = Color.Red;
                lbl_ErrorDateBuy.Visible = true;
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

            #region CarDesign
            if (lbl_IdtxtDesign.Text == "0")
            {
                flag = false;
                lbl_HeadlineDesign.ForeColor = Color.Red;
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

        public int GetPriceCarExtra()
        {
            CarExtraArr carExtraArr = FormToCarExtraArr();
            if (carExtraArr != null)
            {
                return carExtraArr.Price();
            }
            return 0;
        }

        public CarExtraArr FormToCarExtraArr()
        {
            CarExtraArr carExtraArr = listbox_InOrder.DataSource as CarExtraArr;
            return carExtraArr;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            Form_Pay newform = new Form_Pay(listbox_Orders.SelectedItem as OrderBuy);
            newform.ShowDialog();
        }
    }
}
