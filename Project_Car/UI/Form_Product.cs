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
    public partial class Form_Product : Form
    {
        // Product = Model

        Employee newemployee = new Employee();

        public Form_Product(Employee employee)
        {
            InitializeComponent();

            newemployee = employee.CreateEmployee();

            ProductArrToForm(null);
            CompanyArrToForm(null);
            CategoryArrToForm(null);
            ModelToForm(null);

            ComboBoxSet();

        }

        public Form_Product(Employee employee, Car car)
        {
            InitializeComponent();

            newemployee = employee.CreateEmployee();

            ProductArrToForm(null);
            CompanyArrToForm(null);
            CategoryArrToForm(null);
            ModelToForm(null);

            ComboBoxSet(car);

        }

        #region Clear

        private void ClearForm()
        {


            btn_Save.Text = "Save Car";

            ProductArrToForm(null);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    if (ctrl.Name.StartsWith("cmb_Birthday"))
                    {
                        (ctrl as ComboBox).SelectedIndex = 0;
                    }
                    else
                    {
                        (ctrl as ComboBox).SelectedIndex = -1;
                    }
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

        private bool CheckForm()
        { //בודק האם הנתונים שהקושו חוקיים 
            bool flag = true;

            InitForm();

            ClearError();

            #region Model
            if (cmb_Model.SelectedIndex == -1)
            {
                flag = false;
                asterix_Model.ForeColor = Color.Red;
                lbl_ErrorModel.Visible = true;
            }
            #endregion

            #region Status
            if (!rdb_Rent.Checked && !rdb_Buy.Checked)
            {
                flag = false;
                asterix_Status.ForeColor = Color.Red;
                lbl_ErrorStatus.Visible = true;
            }
            #endregion

            #region Price

            if (txt_Price.Text == "" || !CheckintNumber(txt_Price))
            {
                flag = false;
                asterix_Price.ForeColor = Color.Red;
                lbl_ErrorPrice.Visible = true;

            }

            #endregion

            #region License
            if (txt_LicenseNumber.Text == "")
            {
                flag = false;
                asterix_License.ForeColor = Color.Red;
                lbl_ErrorLicense.Visible = true;
            }
            #endregion

            return flag;
        }

        public bool CheckintNumber(TextBox txt)
        {
            int v;
            bool isnum = int.TryParse(txt.Text, out v);
            return isnum;
        }
        private void ComboBoxSet()
        {

            cmb_Company.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Model.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;


            cmb_Company.DropDownHeight = cmb_Company.Font.Height * 10;
            cmb_Model.DropDownHeight = cmb_Model.Height * 10;
            cmb_Category.DropDownHeight = cmb_Category.Height * 10;

            cmb_Model.SelectedIndex = -1;
            cmb_Company.SelectedIndex = -1;
            cmb_Category.SelectedIndex = -1;

        }

        private void ComboBoxSet(Car product)
        {

            cmb_Company.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Model.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;


            cmb_Company.DropDownHeight = cmb_Company.Font.Height * 10;
            cmb_Model.DropDownHeight = cmb_Model.Height * 10;
            cmb_Category.DropDownHeight = cmb_Category.Height * 10;

            cmb_Model.SelectedValue = product.Id;
            cmb_Company.SelectedValue = product.Company.Id;
            cmb_Category.SelectedValue = product.Category.Id;

        }

        #region Transfer Data

        private Product FormToProduct()
        {
            Product product = new Product();

            product.Id = Convert.ToInt32(lbl_Idtxt.Text);
            product.Model = cmb_Model.SelectedItem as Car;
            if (rdb_Rent.Checked)
            {
                product.Status = "Rent";
                product.Price = Convert.ToInt32(txt_Price.Text);
            }
            else
            {
                product.Status = "Buy";
                product.Price = Convert.ToInt32(txt_Price.Text);

            }
            product.LicenseNumber = txt_LicenseNumber.Text;



            return product;
        }

        private void ProductToForm(Product product)
        {
            lbl_Idtxt.Text = product.Id.ToString();
            cmb_Company.SelectedValue = product.Model.Company.Id;
            cmb_Category.SelectedValue = product.Model.Category.Id;
            cmb_Model.SelectedValue = product.Model.Id;
            if (product.Status == "Rent")
            {
                rdb_Rent.Checked = true;
                txt_Price.Text = product.Price.ToString();
            }
            else
            {
                rdb_Buy.Checked = true;
                txt_Price.Text = product.Price.ToString();
            }
            txt_LicenseNumber.Text = product.LicenseNumber;
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
            else
            {
                cmb_Category.SelectedIndex = -1;
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
            else
            {
                cmb_Model.SelectedIndex = -1;
            }
        }

        public void ProductArrToForm(Product curProduct)
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();
            productArr.Sort();

            listbox_Cars.DataSource = productArr;

            listbox_Cars.ValueMember = "ID";
            listbox_Cars.DisplayMember = "FullModel";

            if (curProduct != null)
            {
                listbox_Cars.SelectedValue = curProduct.Id;
            }


        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Product product = FormToProduct();

                ProductArr productArr = new ProductArr();
                productArr.Fill();

                if (product.Id == 0)
                {
                    if (!productArr.IsContainLicenseNumber(txt_LicenseNumber.Text))
                    {
                        if (product.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            productArr.Fill();
                            product = productArr.GetProductWithMaxId();

                            ProductArrToForm(product);
                        }
                    }
                    else
                    {
                        MessageBox.Show("License Number already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (product.Update())
                    {
                        MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        ProductArrToForm(null);
                    }
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_Car newform = new Form_Car(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Product product = FormToProduct();

            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            if (product.Id == 0)
            {

            }
            else
            {
                if (orderRentArr.DoesExist(product) || orderBuyArr.DoesExist(product))
                {
                    MessageBox.Show("You can not delete this product, it is connected" +
                       " to 1 or more orders", "Can not delete product",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this product? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (product.Delete())
                        {
                            ClearForm();
                            ProductArrToForm(null);

                        }
                    }
                }
            }
        }



        private void btn_Filter_Click(object sender, EventArgs e)
        {

            Form_FilterProduct newform = new Form_FilterProduct();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listbox_Cars.DataSource = newform.GetCars();
            }
            newform.Close();
            newform.Dispose();
        }


        #endregion

        #region Update Data

        private void rdb_Rent_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Price.Visible = true;

            if (rdb_Rent.Checked)
            {
                lbl_Price.Text = "Price Per Day";

                txt_Price.Visible = true;
                asterix_Price.Visible = true;
            }
            else
            {
                lbl_Price.Visible = false;

                txt_Price.Visible = false;
                asterix_Price.Visible = false;
            }
        }

        private void rdb_Buy_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Price.Visible = true;

            if (rdb_Buy.Checked)
            {
                lbl_Price.Text = "Price Per Car";

                txt_Price.Visible = true;
                asterix_Price.Visible = true;
            }
            else
            {
                lbl_Price.Visible = false;

                txt_Price.Visible = false;
                asterix_Price.Visible = false;
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


            //  cmb_Model.SelectedIndex = -1;


        }


        #endregion

        private void lbl_Model_Click(object sender, EventArgs e)
        {
            Form_Car newform = new Form_Car(null);
            newform.ShowDialog();

            CompanyArrToForm(newform.SelectedCar.Company);
            CategoryArrToForm(newform.SelectedCar.Category);
            ModelToForm(newform.SelectedCar);
        }

        private void listbox_Cars_DoubleClick(object sender, EventArgs e)
        {
            btn_Save.Text = "Update Product";


            ProductToForm(listbox_Cars.SelectedItem as Product);
        }

        public Product SelectedProduct
        {
            get { return (listbox_Cars.SelectedItem as Product); }
        }

    }
}
