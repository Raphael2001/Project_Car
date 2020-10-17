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
    public partial class Form_Company : Form
    {
        Employee newemployee;

        public Form_Company(Employee employee)
        {
            InitializeComponent();
            if (employee != null)
            {
                newemployee = employee.CreateEmployee();
            }
            

            CompanyArrToForm(null);
        }

        public bool CheckForm()
        {
            bool flag = true;

            InitForm();

            ClearError();

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
        

            btn_Save.Text = "Save Compnay";

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_HomePage newform = new Form_HomePage(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void CompanyArrToForm(Company curCompany)
        {
            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();

            listbox_Company.DataSource = companyArr;
            listbox_Company.ValueMember = "Id";
            listbox_Company.DisplayMember = "Name";

            if (curCompany != null)
            {
                listbox_Company.SelectedValue = curCompany.Id;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                Company company = new Company();
                company = FormToCompany();

                CompanyArr oldCompanyArr = new CompanyArr();
                oldCompanyArr.Fill();

                if (!oldCompanyArr.IsContain(company.Name))
                {
                    if (company.Id == 0)
                    {
                        if (company.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CompanyArr companyArr = new CompanyArr();
                            companyArr.Fill();
                            company = companyArr.GetCompanyWithMaxId();

                            CompanyArrToForm(company);
                        }
                    }
                    else
                    {
                        if (company.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CompanyArr companyArr = new CompanyArr();
                            companyArr.Fill();
                            company = companyArr.GetCompanyWithMaxId();
                            CompanyArrToForm(company);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Company already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        #region Transfer Data

        private Company FormToCompany()
        {
            Company company = new Company();

            company.Id = int.Parse(lbl_Idtxt.Text);
            company.Name = txt_Name.Text;

            return company;
        }

        private void CompanyToForm(Company company)
        {
            lbl_Idtxt.Text = company.Id.ToString();
            txt_Name.Text = company.Name;
        }

        #endregion

        private void listbox_Company_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Company";
            CompanyToForm(listbox_Company.SelectedItem as Company);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Company company = FormToCompany();
            CarArr carArr = new CarArr();
            carArr.Fill();
            

            if (company.Id == 0)
            {

            }
            else
            {
                if (carArr.DoesExist(company))
                {
                    MessageBox.Show("You can not delete this company, it is connected" +
                        " to 1 or more cars", "Can not delete company",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Company? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        company.Delete();
                        ClearForm();
                        CompanyArrToForm(null);
                    }
                }
            }
        }

        public Company SelectedCompany
        {
            get { return (listbox_Company.SelectedItem as Company); }
        }
    }
}
