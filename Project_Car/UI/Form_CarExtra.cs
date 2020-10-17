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
    public partial class Form_CarExtra : Form
    {

        Employee employee;

        public Form_CarExtra(Employee oldemployee)
        {
            InitializeComponent();

            CarExtraArrToForm(null);


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
       
            btn_Save.Text = "Save CarExtra";

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

        private CarExtra FormToCarExtra()
        {
            CarExtra carExtra = new CarExtra();

            carExtra.Id = int.Parse(lbl_Idtxt.Text);
            carExtra.Price = int.Parse(txt_Price.Text);
            carExtra.Name = txt_Name.Text;
            carExtra.Count = int.Parse(txt_Count.Text);

            return carExtra;
        }

        private void CarExtraToForm(CarExtra carExtra)
        {
            lbl_Idtxt.Text = carExtra.Id.ToString();
            txt_Price.Text = carExtra.Price.ToString();
            txt_Name.Text = carExtra.Name;
            txt_Count.Text = carExtra.Count.ToString();
        }

        private void listbox_CarExtra_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update CarExtra";
            CarExtraToForm(listbox_CarExtra.SelectedItem as CarExtra);
        }

        private void CarExtraArrToForm(CarExtra curcarExtra)
        {
            CarExtraArr carExtraArr = new CarExtraArr();
            carExtraArr.Fill();


            listbox_CarExtra.DataSource = carExtraArr;

            listbox_CarExtra.ValueMember = "Id";
            listbox_CarExtra.DisplayMember = "FullExtra";


            if (curcarExtra !=null)
            {
                listbox_CarExtra.SelectedValue = curcarExtra.Id;
            }
        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                CarExtra carExtra = new CarExtra();
                carExtra = FormToCarExtra();

                CarExtraArr oldCarExtraArr = new CarExtraArr();
                oldCarExtraArr.Fill();

                if (!oldCarExtraArr.IsContain(carExtra.Name))
                {
                    if (carExtra.Id == 0)
                    {
                        if (carExtra.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CarExtraArr carExtraArr = new CarExtraArr();
                            carExtraArr.Fill();
                            carExtra = carExtraArr.GetCarExtraWithMaxId();

                            CarExtraArrToForm(carExtra);
                        }
                    }
                    else
                    {
                        if (carExtra.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CarExtraArr carExtraArr = new CarExtraArr();
                            carExtraArr.Fill();
                            carExtra = carExtraArr.GetCarExtraWithMaxId();
                            CarExtraArrToForm(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CarExtra already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CarExtra carExtra = FormToCarExtra();

            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();
            orderDetailsBuyArr.Fill();

            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();
            orderDetailsRentArr.Fill();

            if (carExtra.Id == 0)
            {
               
            }
            else
            {
                if (orderDetailsBuyArr.DoesExist(carExtra) || orderDetailsRentArr.DoesExist(carExtra))
                {
                    MessageBox.Show("You can not delete this Car Extra, it is connected" +
                        " to 1 or more Orders", "Can not delete Car Extra",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " CarExtra? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        carExtra.Delete();
                        ClearForm();
                        CarExtraArrToForm(null);
                    }
                }
            }
        }

        private void btn_FilterExtra_Click(object sender, EventArgs e)
        {
            Form_FilterExtra newform = new Form_FilterExtra();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listbox_CarExtra.DataSource = newform.GetExtras();
            }
            newform.Close();
            newform.Dispose();
        }

        #endregion

        public bool CheckForm()
        {
            bool flag = true;

            InitForm();

            ClearError();

            #region Price
            if (txt_Price.Text == "" || !CheckintNumber(txt_Price))
            {
                flag = false;
                asterix_Price.ForeColor = Color.Red;
                lbl_ErrorPrice.Visible = true;
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

            #region Count
            if (txt_Count.Text == "" ||! CheckintNumber(txt_Count))
            {
                flag = false;
                asterix_Count.ForeColor = Color.Red;
                lbl_ErrorCount.Visible = true;
            }
            #endregion

            return flag;

        }

        public CarExtra SelectedCarExtra
        {
            get { return (listbox_CarExtra.SelectedItem as CarExtra); }
        }

        public bool CheckintNumber(TextBox txt)
        {
            int v;
            bool isnum = int.TryParse(txt.Text, out v);
            return isnum;
        }
    }
}
