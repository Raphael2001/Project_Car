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
    public partial class Form_FilterExtra : Form
    {
       
        

        public Form_FilterExtra()
        {
            InitializeComponent();

            CarExtraArr carExtraArr = new CarExtraArr();
            carExtraArr.Fill();

            txt_MinPrice.Text = "0";
            txt_MaxPrice.Text = carExtraArr.GetMaxPrice().ToString();
            txt_Count.Text = carExtraArr.GetMaxCount().ToString();

        }

        public Form_FilterExtra(CarExtraArr carExtraArr)
        {
            InitializeComponent();

            txt_MinPrice.Text = "0";
            txt_MaxPrice.Text = carExtraArr.GetMaxPrice().ToString();
            txt_Count.Text = carExtraArr.GetMaxCount().ToString();

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

        private void btn_Cancel_Click_1(object sender, EventArgs e)
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

        public CarExtraArr GetExtras()
        {
            CarExtraArr carExtraArrNew = new CarExtraArr();
            carExtraArrNew.Fill();

            int Id = 0;
            int MinPrice = 0;
            int MaxPrice = carExtraArrNew.GetMaxPrice();
            string Name = "";
            int Count = Convert.ToInt32(txt_Count.Text);

            if(txt_MinPrice.Text != "")
            {
                MinPrice = Convert.ToInt32(txt_MinPrice.Text);
            }

            if(txt_MaxPrice.Text !="")
            {
                MaxPrice = Convert.ToInt32(txt_MaxPrice.Text);
            }

            if (txt_Name.Text != "")
            {
                Name = txt_Name.Text.ToString();
            }

            if (txt_Id.Text != "")
            {
                Id = int.Parse(txt_Id.Text);
            }

            CarExtraArr carExtraArr = new CarExtraArr();
            carExtraArr.Fill();

            carExtraArr = carExtraArr.Filter(Id, Name, MinPrice, MaxPrice,Count);

            return carExtraArr;
        }

        public CarExtraArr GetExtras(CarExtraArr carExtraArrNew)
        {
           
            int Id = 0;
            int MinPrice = 0;
            int MaxPrice = carExtraArrNew.GetMaxPrice();
            string Name = "";
            int Count = Convert.ToInt32(txt_Count.Text);

            if (txt_MinPrice.Text != "")
            {
                MinPrice = Convert.ToInt32(txt_MinPrice.Text);
            }

            if (txt_MaxPrice.Text != "")
            {
                MaxPrice = Convert.ToInt32(txt_MaxPrice.Text);
            }

            if (txt_Name.Text != "")
            {
                Name = txt_Name.Text.ToString();
            }

            if (txt_Id.Text != "")
            {
                Id = int.Parse(txt_Id.Text);
            }

            CarExtraArr carExtraArr = new CarExtraArr();
            carExtraArr.Fill();

            carExtraArr = carExtraArr.Filter(Id, Name, MinPrice, MaxPrice, Count);

            return carExtraArr;
        }

    }
}
