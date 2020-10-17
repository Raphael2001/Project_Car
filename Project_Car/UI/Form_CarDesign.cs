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
    public partial class Form_CarDesign : Form
    {
        Employee employee;

        public Form_CarDesign(Employee oldemployee)
        {
            InitializeComponent();

            if (oldemployee != null)
            {
                employee = oldemployee.CreateEmployee();
            }

            CarColorArrToForm(null);
            CarDesignArrToForm(null);
            ColorTypesArrToForm(null);
            BodyDesignArrToForm(null);

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

        private CarDesign FormToCarDesign()
        {
            CarDesign carDesign = new CarDesign();

            carDesign.Id = int.Parse(lbl_Idtxt.Text);
            carDesign.CarColor = cmb_Color.SelectedItem as CarColor;
            carDesign.ColorType = cmb_ColorType.SelectedItem as ColorType;
            carDesign.BodyDesign = cmb_Body.SelectedItem as BodyDesign;

            return carDesign;
        }

        private void CarDesignToForm(CarDesign carDesign)
        {
            lbl_Idtxt.Text = carDesign.Id.ToString();
            cmb_Color.SelectedValue = carDesign.CarColor.Id;
            cmb_ColorType.SelectedValue = carDesign.ColorType.Id;
            cmb_Body.SelectedValue = carDesign.BodyDesign.Id;
        }

        private void listbox_CarDesign_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Car Design";
            CarDesignToForm(listbox_Designs.SelectedItem as CarDesign);
        }

        private void CarDesignArrToForm(CarDesign curCarDesign)
        {
            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();

            listbox_Designs.ValueMember = "ID";
            listbox_Designs.DisplayMember = "FullDesign";
            listbox_Designs.DataSource = carDesignArr;

            if (curCarDesign != null)
            {
                listbox_Designs.SelectedValue = curCarDesign.Id;
            }
        }

        public void CarColorArrToForm(CarColor curcarColor)
        {
            CarColorArr carColorArr = new CarColorArr();
            carColorArr.Fill();

            cmb_Color.DataSource = carColorArr;
            cmb_Color.ValueMember = "Id";
            cmb_Color.DisplayMember = "Name";

            if (curcarColor != null)
            {
                cmb_Color.SelectedValue = curcarColor.Id;
            }

        }

        public void ColorTypesArrToForm(ColorType curColorType)
        {
            ColorTypeArr colrTypeArr = new ColorTypeArr();
            colrTypeArr.Fill();

            cmb_ColorType.ValueMember = "Id";
            cmb_ColorType.DisplayMember = "Name";
            cmb_ColorType.DataSource = colrTypeArr;


            if (curColorType != null)
            {
                cmb_ColorType.SelectedValue = curColorType.Id;
            }


        }

        public void BodyDesignArrToForm(BodyDesign curBodyDesign)
        {
            BodyDesignArr BodyDesignArr = new BodyDesignArr();
            BodyDesignArr.Fill();

            cmb_Body.DataSource = BodyDesignArr;
            cmb_Body.ValueMember = "Id";
            cmb_Body.DisplayMember = "Name";

            if (curBodyDesign != null)
            {
                cmb_Body.SelectedValue = curBodyDesign.Id;
            }


        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                CarDesign carDesign = new CarDesign();
                carDesign = FormToCarDesign();

                CarDesignArr oldCarDesignArr = new CarDesignArr();
                oldCarDesignArr.Fill();

                if (!oldCarDesignArr.IsContain(carDesign.ToString()))
                {
                    if (carDesign.Id == 0)
                    {
                        if (carDesign.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CarDesignArr carDesignArr = new CarDesignArr();
                            carDesignArr.Fill();
                            carDesign = carDesignArr.GetCarDesignWithMaxId();

                            CarDesignArrToForm(carDesign);
                        }
                    }
                    else
                    {
                        if (carDesign.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            CarDesignArr carDesignArr = new CarDesignArr();
                            carDesignArr.Fill();
                            carDesign = carDesignArr.GetCarDesignWithMaxId();
                            CarDesignArrToForm(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Car Design already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CarDesign carDesign = FormToCarDesign();

            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();


            if (carDesign.Id == 0)
            {

            }
            else
            {
                if (orderBuyArr.DoesExist(carDesign))
                {
                    MessageBox.Show("You can not delete this  Car Design, it is connected" +
                        " to 1 or more Orders", "Can not delete Car Design",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Car Design? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        carDesign.Delete();
                        ClearForm();
                        CarDesignArrToForm(null);
                    }
                }
            }
        }

        private void btn_FilterDesign_Click(object sender, EventArgs e)
        {
            Form_FilterDesign newform = new Form_FilterDesign();
            if (newform.ShowDialog() == DialogResult.OK)
            {

                listbox_Designs.DataSource = newform.GetDesigns();
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

            #region Color

            if (cmb_Color.SelectedIndex == -1)
            {
                flag = false;
                asterix_Color.ForeColor = Color.Red;
                lbl_ErrorColor.Visible = true;
            }
            #endregion

            #region Color Type

            if (cmb_ColorType.SelectedIndex == -1)
            {
                flag = false;
                asterix_Type.ForeColor = Color.Red;
                lbl_ErrorType.Visible = true;
            }
            #endregion

            #region Body

            if (cmb_Body.SelectedIndex == -1)
            {
                flag = false;
                asterix_Body.ForeColor = Color.Red;
                lbl_ErrorBody.Visible = true;
            }
            #endregion



            return flag;

        }

        private void ComboBoxSet()
        {
            foreach (Control c1 in this.Controls)

            {
                if (c1 is ComboBox)
                {

                    (c1 as ComboBox).DropDownStyle = ComboBoxStyle.DropDownList;

                    (c1 as ComboBox).DropDownHeight = (c1 as ComboBox).Font.Height * 10;

                    (c1 as ComboBox).SelectedIndex = -1;
                }
            }

        }

        private void lbl_Color_Click(object sender, EventArgs e)
        {
            Form_CarColor newform = new Form_CarColor(null);
            newform.ShowDialog();
            CarColorArrToForm(newform.SelectedCarColor);

        }

        private void lbl_ColorType_Click(object sender, EventArgs e)
        {
            Form_ColorTypes newform = new Form_ColorTypes(null);
            newform.ShowDialog();
            ColorTypesArrToForm(newform.SelectedColorTypes);
        }

        private void lbl_Body_Click(object sender, EventArgs e)
        {
            Form_BodyDesign newform = new Form_BodyDesign(null);
            newform.ShowDialog();
            BodyDesignArrToForm(newform.SelectedBodyDesign);
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;

            if (cmb_Color.SelectedItem != null)
                price += (cmb_Color.SelectedItem as CarColor).Price;
            if (cmb_ColorType.SelectedItem != null)
                price += (cmb_ColorType.SelectedItem as ColorType).Price;
            if (cmb_Body.SelectedItem != null)
                price += (cmb_Body.SelectedItem as BodyDesign).Price;


            lbl_AucPrice.Text = price.ToString();

        }


        public CarDesign SelectedDesign
        {
            get { return (listbox_Designs.SelectedItem as CarDesign); }
        }


    }
}
