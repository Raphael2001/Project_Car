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
    public partial class Form_Pay : Form
    {
        OrderBuy neworderBuy;
        OrderRent neworderRent;
        bool DoesBuy;

        public Form_Pay(OrderBuy orderBuy)
        {
            InitializeComponent();

            DoesBuy = true;

            ComboBoxSet();

            FillDates();

            neworderBuy = orderBuy;

        }

        public Form_Pay(OrderRent orderRent)
        {
            InitializeComponent();

            DoesBuy = false;

            ComboBoxSet();

            FillDates();

            neworderRent = orderRent;
        }
      
        #region Date

        private void FillDates()
        { // ממלא תאריכים 
            DateTime curretTime = DateTime.Now;

            for (int i = curretTime.Year ; i < curretTime.Year+20; i++)
            {
                cmb_DateYear.Items.Add(i);
            }



        }

        private bool IsValidDate()
        { // האם התאריך שקיבלנו תקין
            DateTime dateTime;
            string strBirthday = ConvertDateToString();

            return DateTime.TryParse(strBirthday, out dateTime);
        }

        private string ConvertDateToString()
        {// ממיר תאריך לסטרינג
            string month, year;

            month = cmb_DateMonth.SelectedIndex > 0 ? cmb_DateMonth.Text : "0";
            year = cmb_DateYear.SelectedIndex > 0 ? cmb_DateYear.Text : "0";

            return month + year;
        }

        private DateTime GetDate()
        {// מחזיר טיפוס מסוג דייטיים עם התאריך שהקישו
            DateTime birthday;

            DateTime.TryParse(ConvertDateToString(), out birthday);

            return birthday;
        }

        public bool IsDateBigger()
        {
            DateTime dt = GetDate();

            if ((dt.Month < DateTime.Now.Month) && (dt.Year <= DateTime.Now.Year))
                return false;
            return true;
        }
        #endregion

        #region Clear

        private void ClearForm()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = -1;
                }
                else if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Checked = false;
                }
                else if (ctrl is Label)
                {
                    if (ctrl.Name == "lbl_Idtxt")
                    {
                        ctrl.Text = "0";
                    }

                    else if (ctrl.Name.StartsWith("lbl_Error"))
                    {
                        ctrl.Visible = false;
                    }

                    else if (ctrl.Name.StartsWith("asterix_"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }
                }
            }
        }

        private void ClearError()
        {

            foreach (Control ctrl in this.Controls)
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
            ClearForm();
        }

        private void InitForm()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {

                    if (ctrl.Name.StartsWith("asterix_"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }
                }
            }


        }

        #endregion

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

        #region Transfer Data

        private PayBuy FormToPayBuy(OrderBuy orderBuy)
        {
            PayBuy pay = new PayBuy();

            pay.Id = int.Parse(lbl_Idtxt.Text);
            pay.FullName = txt_FullName.Text;
            pay.CardNumber = txt_Card.Text;
            pay.Date = GetDate();
            pay.CVC = txt_CVC.Text;


            pay.Order = orderBuy;
            return pay;
        }

        private PayRent FormToPayRent(OrderRent orderRent)
        {
            PayRent pay = new PayRent();

            pay.Id = int.Parse(lbl_Idtxt.Text);
            pay.FullName = txt_FullName.Text;
            pay.CardNumber = txt_Card.Text;
            pay.Date = GetDate();
            pay.CVC = txt_CVC.Text;

            pay.Order = orderRent;
            return pay;
        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        { // שומר את המידע שקיבלנו לטבלה
            if (CheckForm())
            {

                if (DoesBuy)
                {
                    PayBuy payBuy = FormToPayBuy(neworderBuy);

                    if (payBuy.Id ==0)
                    {

                        if (payBuy.Insert())
                        {
                            ClearForm();

                            Form_Invoice newform = new Form_Invoice(payBuy);
                            Hide();
                            newform.ShowDialog();
                            Close();

                        }

                    }
                }
                else
                {
                    PayRent payRent = FormToPayRent(neworderRent);

                    if (payRent.Id == 0)
                    {

                        if (payRent.Insert())
                        {
                            ClearForm();

                            Form_Invoice newform = new Form_Invoice(payRent);
                            Hide();
                            newform.ShowDialog();
                            Close();


                        }

                    }
                }
            }
        }

        #endregion

        private void ComboBoxSet()
        {

            cmb_DateMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_DateYear.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_DateMonth.DropDownHeight = cmb_DateMonth.Font.Height * 10;
            cmb_DateYear.DropDownHeight = cmb_DateYear.Height * 10;

            cmb_DateMonth.SelectedIndex = 0;
            cmb_DateYear.SelectedIndex = 0;

        }

        private bool CheckForm()
        { //בודק האם הנתונים שהקושו חוקיים 
            bool flag = true;

            InitForm();

            ClearError();

            #region Full Name
            if (txt_FullName.Text.Length < 2)
            {
                flag = false;
                asterix_FullName.ForeColor = Color.Red;
                lbl_ErrorFullName.Visible = true;
            }
            #endregion

            #region Card Number
            if (txt_Card.Text == "")
            {
                flag = false;
                asterix_Number.ForeColor = Color.Red;
                lbl_ErrorNumber.Visible = true;
            }
            #endregion

            #region CVC
            if (txt_CVC.Text == "")
            {
                flag = false;
                asterix_CVC.ForeColor = Color.Red;
                lbl_ErrorCVC.Visible = true;
            }
            #endregion

            #region Date
            if (!IsValidDate())
            {
                flag = false;
                asterix_Date.ForeColor = Color.Red;
                lbl_ErrorDate.Visible = true;
            }

            #endregion

            #region Date2
            if (!IsDateBigger())
            {
                flag = false;
                asterix_Date.ForeColor = Color.Red;
                lbl_ErrorDate.Visible = true;
            }
            #endregion

            return flag;
        }

    }
}
