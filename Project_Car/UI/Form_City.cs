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
    public partial class Form_City : Form
    {
        Employee employee;

        public Form_City(Employee oldemployee)
        {
            InitializeComponent();
            CityArrToForm(null);

            if (oldemployee != null)
            {
                employee = oldemployee.CreateEmployee();
            }
           
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
            

            btn_Save.Text = "Save City";

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

        private City FormToCity()
        {
            City city = new City();

            city.Id = int.Parse(lbl_Idtxt.Text);
            city.Name = txt_Name.Text;

            return city;
        }

        private void CityToForm(City city)
        {
            lbl_Idtxt.Text = city.Id.ToString();
            txt_Name.Text = city.Name;
        }

        private void CityArrToForm(City curCity)
        {
            CityArr cityArr = new CityArr();
            cityArr.Fill();

            listbox_City.DataSource = cityArr;
            listbox_City.ValueMember = "Id";
            listbox_City.DisplayMember = "Name";

            if (curCity != null)
            {
                listbox_City.SelectedValue = curCity.Id;
            }
        }

        private void listbox_City_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update City";
            CityToForm(listbox_City.SelectedItem as City);
        }

        #endregion

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

        #region Button

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            City city = FormToCity();
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            if (city.Id == 0)
            {

            }
            else
            {
                if (clientArr.DoesExist(city))
                {
                    MessageBox.Show("You can not delete this city, it is connected" +
                        " to 1 or more clients", "Can not delete city",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " City? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (city.Delete())
                        {
                            ClearForm();
                            CityArrToForm(null);
                        }
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

                City city = new City();
                city = FormToCity();

                CityArr oldCityArr = new CityArr();
                oldCityArr.Fill();

                if (!oldCityArr.IsContain(city.Name))
                {
                    if (city.Id == 0)
                    {
                        if (city.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            city = cityArr.GetCityWithMaxId();

                            CityArrToForm(city);
                        }
                    }
                    else
                    {
                        if (city.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            city = cityArr.GetCityWithMaxId();
                            CityArrToForm(city);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("City already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        #endregion

        public City SelectedCity { get { return (listbox_City.SelectedItem as City); } }
    }
}
