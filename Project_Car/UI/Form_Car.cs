using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Car.BL;
using Project_Car.Properties;
using System.IO;

namespace Project_Car.UI
{
    public partial class Form_Car : Form
    {
        Employee newemployee = new Employee();

        public Form_Car(Employee employee)
        {
            InitializeComponent();

            if (employee != null)
            {
                newemployee = employee.CreateEmployee();
            }


            CarArrToForm(null);
            CompanyArrToForm(null);
            EngineArrToForm(null);
            CategoryArrToForm(null);

            btn_Photo.Visible = false;

            ComboBoxSet();
        }

        #region Clear

        private void ClearForm()
        {


            btn_Save.Text = "Save Car";
            btn_Photo.Visible = false;

            CarArrToForm(null);

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

        private Car FormToCar()
        {
            Car car = new Car();

            car.Id = Convert.ToInt32(lbl_Idtxt.Text);
            car.Model = txt_Model.Text;
            car.Company = (cmb_Company.SelectedItem as Company);
            car.Category = cmb_Category.SelectedItem as Category;
            car.Engine = (cmb_Engine.SelectedItem as Engine);
            car.HorsePower = Convert.ToInt32(txt_HorsePower.Text);

            return car;
        }

        private void CarToForm(Car car)
        {
            lbl_Idtxt.Text = car.Id.ToString();
            txt_Model.Text = car.Model;
            cmb_Company.SelectedValue = car.Company.Id;
            cmb_Category.SelectedValue = car.Category.Id;
            cmb_Engine.SelectedValue = car.Engine.Id;
            txt_HorsePower.Text = car.HorsePower.ToString();
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

        public void EngineArrToForm(Engine curEngine)
        {
            EngineArr engineArr = new EngineArr();
            engineArr.Fill();

            cmb_Engine.DataSource = engineArr;
            cmb_Engine.ValueMember = "Id";
            cmb_Engine.DisplayMember = "Name";

            if (curEngine != null)
            {
                cmb_Engine.SelectedValue = curEngine.Id;
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

        public void CarArrToForm(Car car)
        {
            CarArr carArr = new CarArr();
            carArr.Fill();
            carArr.Sort();

            listbox_Product.ValueMember = "Id";
            listbox_Product.DisplayMember = "FullModel";
            listbox_Product.DataSource = carArr;

            if (car != null)
            {
                listbox_Product.SelectedValue = car.Id;
            }
        }
        #endregion

        #region Button

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form_FilterCar newform = new Form_FilterCar();
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listbox_Product.DataSource = newform.GetCars();
            }
            newform.Close();
            newform.Dispose();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Car car = FormToCar();

                if (car.Id == 0)
                {
                    if (car.Insert())
                    {
                        MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        CarArr carArr = new CarArr();
                        carArr.Fill();
                        car = carArr.GetCarWithMaxId();
                        CarArrToForm(car);
                    }
                }
                else
                {
                    if (car.Update())
                    {
                        MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        CarArr carArr = new CarArr();
                        carArr.Fill();
                        car = carArr.GetCarWithMaxId();
                        CarArrToForm(car);
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Car product = FormToCar();

            if (product.Id == 0)
            {

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this Car? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (product.Delete())
                    {
                        ClearForm();
                        CarArrToForm(null);
                    }
                }
            }
        }

        #endregion

        private bool CheckForm()
        { //בודק האם הנתונים שהקושו חוקיים 
            bool flag = true;

            InitForm();

            ClearError();

            #region Company
            if (cmb_Company.Text == "")
            {
                flag = false;
                asterix_Company.ForeColor = Color.Red;
                lbl_ErrorCompany.Visible = true;
            }
            #endregion

            #region Category
            if (cmb_Category.Text == "")
            {
                flag = false;
                lbl_ErrorCategory.Visible = true;
                asterix_Category.ForeColor = Color.Red;
            }
            #endregion

            #region Engine
            if (cmb_Engine.SelectedIndex == -1)
            {
                flag = false;
                asterix_Engine.ForeColor = Color.Red;
                lbl_ErrorEngine.Visible = true;
            }
            #endregion

            #region Horse Power
            if (txt_HorsePower.Text == "" || !CheckintNumber(txt_HorsePower))
            {
                flag = false;
                asterix_HorsePower.ForeColor = Color.Red;
                lbl_ErrorHorsePower.Visible = true;
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
            cmb_Engine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;


            cmb_Company.DropDownHeight = cmb_Company.Font.Height * 10;
            cmb_Engine.DropDownHeight = cmb_Engine.Height * 10;
            cmb_Category.DropDownHeight = cmb_Category.Height * 10;

            cmb_Engine.SelectedIndex = -1;
            cmb_Company.SelectedIndex = -1;
            cmb_Category.SelectedIndex = -1;

        }

        private void listbox_Product_DoubleClick(object sender, EventArgs e)
        {
            btn_Save.Text = "Update Car";
            btn_Photo.Visible = true;
            CarToForm((Car)listbox_Product.SelectedItem);
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
        }

        private void btn_Photo_Click(object sender, EventArgs e)
        {
            if (InternetMessageBox())
            {
                try
                {
                    Form_CarPhoto newform = new Form_CarPhoto(GetName());
                    newform.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Couldn't load the photo", "Error in loading the photo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool InternetMessageBox()
        {


            if (!CheckForInternetConnection())
            {
                if (MessageBox.Show("No Internet connection. Please try again later", "Internet connection is poor",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop) == DialogResult.Cancel)
                {

                }
                else
                {
                    InternetMessageBox();

                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetName()
        {
            return cmb_Company.Text + " " + cmb_Category.Text + " " + txt_Model.Text;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.co.il/?hl=iw"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public Car SelectedCar
        {
            get { return (listbox_Product.SelectedItem as Car); }
        }

        private void lbl_Company_Click(object sender, EventArgs e)
        {
            Form_Company newform = new Form_Company(null);
            newform.ShowDialog();
            CompanyArrToForm(newform.SelectedCompany);

        }

        private void lbl_Category_Click(object sender, EventArgs e)
        {
            Form_Category newform = new Form_Category(null);
            newform.ShowDialog();

            CompanyArrToForm(newform.SelectedCategory.Company);

            CategoryArrToForm(newform.SelectedCategory);
        }

        private void lbl_Engine_Click(object sender, EventArgs e)
        {
            Form_Engine newform = new Form_Engine(null);
            newform.ShowDialog();
            EngineArrToForm(newform.SelectedEngine);
        }
    }
}
