using Project_Car.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Car.UI
{
    public partial class Form_CarColor : Form
    {

        Employee employee;

        public Form_CarColor(Employee oldemployee)
        {
            InitializeComponent();

            CarColorArrToForm(null);


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
           

            btn_Save.Text = "Save Car Color";

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

        private CarColor FormToCarColor()
        {
            CarColor carColor = new CarColor();

            carColor.Id = int.Parse(lbl_Idtxt.Text);
            carColor.Price = int.Parse(txt_Price.Text);
            carColor.Name = txt_Name.Text;

            return carColor;
        }

        private void CarColorToForm(CarColor carColor)
        {
            lbl_Idtxt.Text = carColor.Id.ToString();
            txt_Price.Text = carColor.Price.ToString();
            txt_Name.Text = carColor.Name;
        }

        private void listbox_CarColor_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Car Color";
            CarColorToForm(listbox_CarColor.SelectedItem as CarColor);
        }

        private void CarColorArrToForm(CarColor curCarColor)
        {
            CarColorArr carColorArr = new CarColorArr();
            carColorArr.Fill();


            listbox_CarColor.ValueMember = "Id";
            listbox_CarColor.DisplayMember = "Name";
            listbox_CarColor.DataSource = carColorArr;

            if (curCarColor != null)
            {
                listbox_CarColor.SelectedValue = curCarColor.Id;
            }
        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                CarColor carColor = new CarColor();
                carColor = FormToCarColor();

                CarColorArr oldCarColorArr = new CarColorArr();
                oldCarColorArr.Fill();

                if (!oldCarColorArr.IsContain(carColor.Name))
                {
                    if (carColor.Id == 0)
                    {
                        if (carColor.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CarColorArr carColorArr = new CarColorArr();
                            carColorArr.Fill();
                            carColor = carColorArr.GetColorWithMaxId();

                            CarColorArrToForm(carColor);
                        }
                    }
                    else
                    {
                        if (carColor.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CarColorArr carColorArr = new CarColorArr();
                            carColorArr.Fill();
                            carColor = carColorArr.GetColorWithMaxId();
                            CarColorArrToForm(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Car color already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CarColor carColor = FormToCarColor();

            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();

            if (carColor.Id == 0)
            {

            }
            else
            {
                if (carDesignArr.DoesExist(carColor))
                {
                    MessageBox.Show("You can not delete this Car color, it is connected" +
                        " to 1 or more Orders", "Can not delete Car color",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Car color? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        carColor.Delete();
                        ClearForm();
                        CarColorArrToForm(null);
                    }
                }
            }
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



            return flag;

        }

        public bool CheckintNumber(TextBox txt)
        {
            int v;
            bool isnum = int.TryParse(txt.Text, out v);
            return isnum;
        }

        public CarColor SelectedCarColor
        {
            get { return (listbox_CarColor.SelectedItem as CarColor); }
        }
    }
}
