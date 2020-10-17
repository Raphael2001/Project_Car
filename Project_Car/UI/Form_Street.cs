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
    public partial class Form_Street : Form
    {
        Employee newemployee;
        public Form_Street(Employee oldemployee)
        {
            InitializeComponent();

            StreetArrToForm(null);

            if (oldemployee != null)
            {
                newemployee = oldemployee.CreateEmployee();
            }
            else
            {
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Street street = FormToStreet();
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();


            if (street.Id == 0)
            {

            }
            else
            {
                if (clientArr.DoesExist(street))
                {
                    MessageBox.Show("You can not delete this street, it is connected" +
                        " to 1 or more clients", "Can not delete street",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this Street? ",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        street.Delete();
                        ClearForm();
                        StreetArrToForm(null);
                    }
                }
            }
        }

        private void StreetArrToForm(Street street)
        {
            StreetArr addressArr = new StreetArr();
            addressArr.Fill();

            listbox_Streets.DataSource = addressArr;
            listbox_Streets.ValueMember = "Id";
            listbox_Streets.DisplayMember = "Name";

            if(street!=null)
            {
                listbox_Streets.SelectedValue = street.Id;
            }
        }

        public bool CheckForm()
        {
            bool flag = true;

            InitForm();

            ClearError();

            #region Adress
            if (txt_NewAddrees.Text.Length < 2)
            {
                flag = false;
                asterix_Name.ForeColor = Color.Red;
                lbl_ErrorName.Visible = true;
            }
            #endregion



            return flag;

        }

        #region Clear

        private void ClearForm()
        {

            btn_Save.Text = "Save Street";

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

        private Street FormToStreet()
        {
            Street address = new Street();

            address.Id = int.Parse(lbl_Idtxt.Text);
            address.Name = txt_NewAddrees.Text;

            return address;
        }

        private void StreetToForm(Street address)
        {
            lbl_Idtxt.Text = address.Id.ToString();
            txt_NewAddrees.Text = address.Name;
        }

        #endregion

        private void listbox_Street_DoubleClick(object sender, EventArgs e)
        {
            btn_Save.Text = "Update Street";
            StreetToForm(listbox_Streets.SelectedItem as Street);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Street street = new Street();
                street = FormToStreet();

                StreetArr oldStreetArr = new StreetArr();
                oldStreetArr.Fill();

                if (!oldStreetArr.IsContain(street.Name))
                {
                    if (street.Id == 0)
                    {
                        if (street.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            StreetArr streetArr = new StreetArr();
                            streetArr.Fill();
                            street = streetArr.GetStreetWithMaxId();
                            StreetArrToForm(street);
                        }
                    }
                    else
                    {
                        if (street.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            StreetArr streetArr = new StreetArr();
                            streetArr.Fill();
                            street = streetArr.GetStreetWithMaxId();
                            StreetArrToForm(street);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Street already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void txt_NewStreet_KeyUp(object sender, KeyEventArgs e)
        {
            StreetArr addressArr = new StreetArr();
            addressArr.Fill();

            addressArr = addressArr.Filter(txt_NewAddrees.Text);

            listbox_Streets.DataSource = addressArr;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_HomePage newform = new Form_HomePage(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        public Street SelectedStreet { get { return (listbox_Streets.SelectedItem as Street); } }





        public int GetStreet()
        {
            StreetArr addressArr = new StreetArr();

            if (txt_NewAddrees.Text != "")
            {
                return addressArr.GetId(txt_NewAddrees.Text);
            }
            else
            {
                return -1;
            }

        }
    }
}