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
    public partial class Form_ColorTypes : Form
    {


        Employee employee;

        public Form_ColorTypes(Employee oldemployee)
        {
            InitializeComponent();

            ColorTypesArrToForm(null);


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
            
            btn_Save.Text = "Save Color Type";

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

        private ColorType FormToColorTypes()
        {
            ColorType colorType = new ColorType();

            colorType.Id = int.Parse(lbl_Idtxt.Text);
            colorType.Price = int.Parse(txt_Price.Text);
            colorType.Name = txt_Name.Text;

            return colorType;
        }

        private void ColorTypesToForm(ColorType colorType)
        {
            lbl_Idtxt.Text = colorType.Id.ToString();
            txt_Price.Text = colorType.Price.ToString();
            txt_Name.Text = colorType.Name;
        }

        private void listbox_ColorTypes_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Color Type";
            ColorTypesToForm(listbox_ColorTypes.SelectedItem as ColorType);
        }

        private void ColorTypesArrToForm(ColorType curColorTypes)
        {
            ColorTypeArr colorTypeArr = new ColorTypeArr();
            colorTypeArr.Fill();

            listbox_ColorTypes.ValueMember = "Id";
            listbox_ColorTypes.DisplayMember = "Name";
            listbox_ColorTypes.DataSource = colorTypeArr;

            if (curColorTypes != null)
            {
                listbox_ColorTypes.SelectedValue = curColorTypes.Id;
            }
        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                ColorType colorType = new ColorType();
                colorType = FormToColorTypes();

                ColorTypeArr oldColorTypesArr = new ColorTypeArr();
                oldColorTypesArr.Fill();

                if (!oldColorTypesArr.IsContain(colorType.Name))
                {
                    if (colorType.Id == 0)
                    {
                        if (colorType.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            ColorTypeArr colorTypes = new ColorTypeArr();
                            colorTypes.Fill();
                            colorType = colorTypes.GetColorTypesWithMaxId();

                            ColorTypesArrToForm(colorType);
                        }
                    }
                    else
                    {
                        if (colorType.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            ColorTypeArr carColorArr = new ColorTypeArr();
                            carColorArr.Fill();
                            colorType = carColorArr.GetColorTypesWithMaxId();
                            ColorTypesArrToForm(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Color Type already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ColorType colorType = FormToColorTypes();

            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();

            if (colorType.Id == 0)
            {

            }
            else
            {
                if (carDesignArr.DoesExist(colorType))
                {
                    MessageBox.Show("You can not delete this Car color, it is connected" +
                        " to 1 or more Orders", "Can not delete Color Type",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Color Type? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        colorType.Delete();
                        ClearForm();
                        ColorTypesArrToForm(null);
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

            if (txt_Price.Text == "" ||!CheckintNumber(txt_Price))
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

        public ColorType SelectedColorTypes
        {
            get { return (listbox_ColorTypes.SelectedItem as ColorType); }
        }
    }
}
