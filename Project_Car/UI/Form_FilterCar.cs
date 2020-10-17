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
    public partial class Form_FilterCar : Form
    {
        public Form_FilterCar()
        {
            InitializeComponent();

            CompanyArrToForm(null);
            CategoryArrToForm(null);

            ComboBoxSet();
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

        private void ComboBoxSet()
        {

            cmb_Company.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_Company.DropDownHeight = cmb_Company.Font.Height * 10;
            cmb_Category.DropDownHeight = cmb_Category.Font.Height * 10;

            cmb_Company.SelectedIndex = -1;
            cmb_Category.SelectedIndex = -1;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            Close();
        }

        public CarArr GetCars()
        {
            int id = 0;
            //אם המשתמש רשם ערך בשדה המזהה
            if (txt_Id.Text != "")
                id = int.Parse(txt_Id.Text);

            //מייצרים אוסף של כלל הלקוחות 
            CarArr carArr = new CarArr();
            carArr.Fill();
            carArr.Sort();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            carArr = carArr.Filter(id, cmb_Category.SelectedItem as Category , (cmb_Company.SelectedItem as Company));

            return carArr;
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

        public void ProductArrToForm(CarArr productArr)
        {
            cmb_Category.DataSource = productArr;
            //    cmb_Model.ValueMember = "Id";
            cmb_Category.DisplayMember = "Category ";
        }

      

        private void cmb_Company_SelectedValueChanged(object sender, EventArgs e)
        {
            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();
            categoryArr = categoryArr.Filter(0, cmb_Company.SelectedItem as Company);

            cmb_Category.DataSource = categoryArr;
            cmb_Category.DisplayMember = "Name";

            cmb_Category.SelectedIndex = -1;
        }
    }
}
