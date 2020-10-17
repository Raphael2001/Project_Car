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
    public partial class Form_FilterOrderCar : Form
    {
        string Status = "";

        public Form_FilterOrderCar(string str)
        {
            InitializeComponent();

            Status = str;

            ModelToForm(null);
            CompanyArrToForm(null);
            CategoryArrToForm(null);

            ComboBoxSet();
        }

        private void ComboBoxSet()
        {

            cmb_Company.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Model.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_Company.DropDownHeight = cmb_Company.Font.Height * 10;
            cmb_Category.DropDownHeight = cmb_Category.Font.Height * 10;
            cmb_Model.DropDownHeight = cmb_Model.Font.Height * 10;

            cmb_Company.SelectedIndex = -1;
            cmb_Category.SelectedIndex = -1;
            cmb_Model.SelectedIndex = -1;

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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public ProductArr GetCars()
        {
            int Id = 0;
            //אם המשתמש רשם ערך בשדה המזהה
          
            //מייצרים אוסף של כלל הלקוחות 
            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            productArr = productArr.Filter(Id, "", Status, cmb_Category.SelectedItem as Category,
                cmb_Company.SelectedItem as Company);
           

            return productArr;
        }

        private void Form_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public void CompanyArrToForm(Company curCompany)
        {
            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();

            cmb_Company.DataSource = companyArr;
            cmb_Company.ValueMember = "Id";
            cmb_Company.DisplayMember = "Name";

            if (curCompany != null)
            {
                cmb_Company.SelectedValue = curCompany.Id;
            }
        }

        public void CategoryArrToForm(Category curCategory)
        {
            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();

            cmb_Category.DataSource = categoryArr;
            cmb_Category.ValueMember = "Id";
            cmb_Category.DisplayMember = "Name";

            if (curCategory != null)
            {
                cmb_Category.SelectedValue = curCategory.Id;
            }
        }

        public void ModelToForm(Car curCar)
        {
            CarArr carArr = new CarArr();
            carArr.Fill();
            carArr.Sort();

            cmb_Model.DataSource = carArr;
            cmb_Model.ValueMember = "Id";
            cmb_Model.DisplayMember = "Model";

            if (curCar != null)
            {
                cmb_Model.SelectedValue = curCar.Id;
            }
        }

        private void cmb_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();
            categoryArr = categoryArr.Filter(0, cmb_Company.SelectedItem as Company);

            cmb_Category.DataSource = categoryArr;
            //      cmb_Category.ValueMember = "Id";
            cmb_Category.DisplayMember = "Name";

            cmb_Category.SelectedIndex = -1;

            CarArr carArr = new CarArr();
            carArr.Fill();
            carArr = carArr.Filter(0, null, cmb_Company.SelectedItem as Company);
           

            cmb_Model.DataSource = carArr;
            cmb_Model.DisplayMember = "Model";

            cmb_Model.SelectedIndex = -1;
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarArr carArr = new CarArr();
            carArr.Fill();
            carArr = carArr.Filter(0, cmb_Category.SelectedItem as Category, cmb_Company.SelectedItem as Company);
            

            cmb_Model.DataSource = carArr;
            cmb_Model.DisplayMember = "Model";

            cmb_Model.SelectedIndex = -1;
        }

     
    }
}
