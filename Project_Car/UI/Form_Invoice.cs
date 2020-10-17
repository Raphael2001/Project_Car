using Project_Car.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Car.UI
{
    public partial class Form_Invoice : Form
    {
        PayBuy newpayBuy;
        PayRent newpayRent;
        Client client;
        string digits;
        int Id;
        string status;

        bool DoesBuy;

        public Form_Invoice()
        {
            InitializeComponent();

        }

        public Form_Invoice(PayBuy payBuy)
        {
            InitializeComponent();
            newpayBuy = payBuy;

            DoesBuy = true;
            AddItemToList(newpayBuy.Order.Product, 1);
            AddItemToList(newpayBuy.Order.CarDesign, 1);

            AddItemsToList(GetCarExtraBuy(newpayBuy));

            client = newpayBuy.Order.Client;

            digits = newpayBuy.CardNumber.Substring(newpayBuy.CardNumber.Length - 4);

            Id = newpayBuy.Order.Id;
            status = "Buy";

        }

        public Form_Invoice(PayRent payRent)
        {
            double days;
            InitializeComponent();
            newpayRent = payRent;

            DoesBuy = false;

            days = (payRent.Order.DateTo - payRent.Order.DateFrom).TotalDays;

            AddItemToList(newpayRent.Order.Product, Convert.ToInt32(days));

            AddItemsToList(GetCarExtraRent(newpayRent));

            client = newpayRent.Order.Client;

            digits = newpayRent.CardNumber.Substring(newpayRent.CardNumber.Length - 4);

            Id = newpayRent.Order.Id;

            status = "Rent";
        }


        private void btnPrintReciept_Click(object sender, EventArgs e)
        {

            pd_DialogInvoice.Document = pd_DocInvoice; //add the document to the dialog box...        

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = pd_DialogInvoice.ShowDialog();

            if (result == DialogResult.OK)
            {
                pd_DocInvoice.Print();

            }
            Close();
        }

        public void CreateReceipt(object sender, PrintPageEventArgs e)
        {

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;
            int space = 47;

            graphic.DrawString("New York Motors".PadRight(space) + status, new Font("Courier New", 18), new SolidBrush(Color.Red), startX, startY);
            string top = "Item Name".PadRight(space) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------------------------",
                font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            int totalprice = 0;

            int i = 0;
            foreach (string item in listbox_Items.Items)
            {
                string productDescription = item.PadRight(space) + Convert.ToInt32(listbox_Price.Items[i]);
                //MessageBox.Show(item.Substring(item.Length - 5, 5) + "PROD TOTAL: " + productTotal);
                int productPrice = Convert.ToInt32(listbox_Price.Items[i]);

                totalprice += productPrice;


                string productLine = productDescription;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5; //make the spacing consistent

                i++;
            }



            //when we have drawn all of the items add the total

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Total to pay ".PadRight(space) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            graphic.DrawString("Order No.".PadRight(space) + Id, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            graphic.DrawString("Client's Name".PadRight(space) + client.Fullname, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            graphic.DrawString("4 Last Digits of Credit Card".PadRight(space) + digits, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            offset = offset + 15;
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("     Thank-you,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);

        }

        public CarExtraArr GetCarExtraBuy(PayBuy payBuy)
        {
            OrderBuy order = payBuy.Order;
            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();
            orderDetailsBuyArr.Fill();
            orderDetailsBuyArr = orderDetailsBuyArr.Filter(order);

            return orderDetailsBuyArr.GetCarExtraArr();
        }

        public CarExtraArr GetCarExtraRent(PayRent payRent)
        {
            OrderRent order = payRent.Order;
            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();
            orderDetailsRentArr.Fill();
            orderDetailsRentArr = orderDetailsRentArr.Filter(order);

            return orderDetailsRentArr.GetCarExtraArr();
        }

        public void AddItemsToList(CarExtraArr carExtraArr)
        {
            foreach (CarExtra extra in carExtraArr)
            {
                listbox_Items.Items.Add(extra.Name);
                listbox_Price.Items.Add(extra.Price);

            }
        }

        public void AddItemToList(object item, int quantity)
        {
            if (item is Product)
            {
                string Name = (item as Product).Model.Category + " " + (item as Product).Model.Model;
                listbox_Items.Items.Add(Name);
                listbox_Price.Items.Add((item as Product).Price * quantity);
            }

            else if (item is CarDesign)
            {
                string Name = (item as CarDesign).FullDesign;
                int Price = (item as CarDesign).BodyDesign.Price + (item as CarDesign).CarColor.Price + (item as CarDesign).ColorType.Price;
                listbox_Items.Items.Add(Name);
                listbox_Price.Items.Add(Price);

            }

        }
    }
}
