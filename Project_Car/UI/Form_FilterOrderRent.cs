﻿using Project_Car.BL;
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
    public partial class Form_FilterOrderRent : Form
    {
        public Form_FilterOrderRent()
        {
            InitializeComponent();
            SetMinDate();
        }

        public void SetMinDate()
        {
            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            dtp_Form.Value = orderRentArr.GetMinDate();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public OrderRentArr GetOrderRent()
        {
            int Id = 0;
            if (txt_Id.Text != "")
                Id = int.Parse(txt_Id.Text);
            //אם המשתמש רשם ערך בשדה המזהה
            DateTime Form, To;

            Form = dtp_Form.Value;
            To = dtp_To.Value;

            //מייצרים אוסף של כלל הלקוחות 
            OrderRentArr orderRent = new OrderRentArr();
            orderRent.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            orderRent = orderRent.Filter(Id, txt_Name.ToString(), Form, To);


            return orderRent;
        }
    }
}
