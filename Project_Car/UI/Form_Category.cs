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
    public partial class Form_Category : Form
    {

        Employee employee;

        public Form_Category(Employee oldemployee)
        {
            InitializeComponent();

            CategoryArrToForm(null);

            CompanyArrToForm(null);

            if (oldemployee != null)
            {
                employee = oldemployee.CreateEmployee();
            }
          

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

        #region Clear

        private void ClearForm()
        {
           

            btn_Save.Text = "Save Category";

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

        #region Transfer Data

        private Category FormToCategory()
        {
            Category category = new Category();

            category.Id = int.Parse(lbl_Idtxt.Text);
            category.Company = cmb_Company.SelectedItem as Company;
            category.Name = txt_Name.Text;

            return category;
        }

        private void CategoryToForm(Category category)
        {
            lbl_Idtxt.Text = category.Id.ToString();
            cmb_Company.SelectedValue = category.Company.Id;
            txt_Name.Text = category.Name;
        }

        private void listbox_Category_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Category";
            CategoryToForm(listbox_Category.SelectedItem as Category);
        }

        private void CategoryArrToForm(Category curCategory)
        {
            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();

            listbox_Category.DisplayMember = "FullName";
            listbox_Category.ValueMember = "Id";

            listbox_Category.DataSource = categoryArr;

            if (curCategory != null)
            {
                listbox_Category.SelectedValue = curCategory.Id;
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


        #endregion

        #region Button

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Category category = FormToCategory();
            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();

            if (category.Id == 0)
            {

            }
            else
            {
                if (companyArr.DoesExist(category))
                {
                    MessageBox.Show("You can not delete this category, it is connected" +
                        " to 1 or more Companies", "Can not delete category",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Category? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        category.Delete();
                        ClearForm();
                        CategoryArrToForm(null);
                    }
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            Form_HomePage newform = new Form_HomePage(employee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                Category category = new Category();
                category = FormToCategory();

                CategoryArr oldCategoryArr = new CategoryArr();
                oldCategoryArr.Fill();

                if (!oldCategoryArr.IsContain(category.Name))
                {
                    if (category.Id == 0)
                    {
                        if (category.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CategoryArr categoryArr = new CategoryArr();
                            categoryArr.Fill();
                            category = categoryArr.GetCategoryWithMaxId();

                            CategoryArrToForm(category);
                        }
                    }
                    else
                    {
                        if (category.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CategoryArr categoryArr = new CategoryArr();
                            categoryArr.Fill();
                            category = categoryArr.GetCategoryWithMaxId();
                            CategoryArrToForm(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Category already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        #endregion
        
        public bool CheckForm()
        {
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

            #region Name
            if (txt_Name.Text.Length < 2)
            {
                flag = false;
                asterix_Name.ForeColor = Color.Red;
                lbl_ErrorName.Visible = true;
            }
            #endregion



            return flag;

        }
        
        private void ComboBoxSet()
        {

            cmb_Company.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_Company.DropDownHeight = cmb_Company.Font.Height * 10;

            cmb_Company.SelectedIndex = -1;

        }

        public Category SelectedCategory
        {
            get { return (listbox_Category.SelectedItem as Category); }
        }

        private void Lbl_Company_Click(object sender, EventArgs e)
        {
            Form_Company newform = new Form_Company(null);
            newform.ShowDialog();
            CompanyArrToForm(newform.SelectedCompany);
        }
    }
}
