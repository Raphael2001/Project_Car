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
    public partial class Form_FilterView : Form
    {
        public Form_FilterView(string MaxPrice)
        {
            InitializeComponent();
            txt_maxPrice.Text = MaxPrice;
            CompanyArrToForm(null);

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
            else
            {
                cmb_Company.SelectedIndex = -1;
            }
        }

        public ProductArr GetCars()
        {
            int minPrice = 0, maxPrice;

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            productArr.Sort();

            maxPrice = Convert.ToInt32(txt_maxPrice.Text);
            minPrice = Convert.ToInt32(txt_minPrice.Text);

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            productArr = productArr.Filter(cmb_Company.SelectedItem as Company, minPrice, maxPrice);

            return productArr;
        }

        public void SetMaxPrice()
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();

            txt_maxPrice.Text = productArr.MaxPriceBuy().ToString();
        }

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
    }
}
