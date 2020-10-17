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
    public partial class Form_BodyDesign : Form
    {

        Employee employee;

        public Form_BodyDesign(Employee oldemployee)
        {
            InitializeComponent();

            BodyDesignArrToForm(null);


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


            btn_Save.Text = "Save Body Design";

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

        private BodyDesign FormToBodyDesign()
        {
            BodyDesign bodyDesign = new BodyDesign();

            bodyDesign.Id = int.Parse(lbl_Idtxt.Text);
            bodyDesign.Price = int.Parse(txt_Price.Text);
            bodyDesign.Name = txt_Name.Text;

            return bodyDesign;
        }

        private void BodyDesignToForm(BodyDesign bodDesign)
        {
            lbl_Idtxt.Text = bodDesign.Id.ToString();
            txt_Price.Text = bodDesign.Price.ToString();
            txt_Name.Text = bodDesign.Name;
        }

        private void listbox_BodyDesign_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Body Design";
            BodyDesignToForm(listbox_BodyDesign.SelectedItem as BodyDesign);
        }

        private void BodyDesignArrToForm(BodyDesign curBodyDesign)
        {
            BodyDesignArr bodyDesignArr = new BodyDesignArr();
            bodyDesignArr.Fill();


            listbox_BodyDesign.DataSource = bodyDesignArr;


            listbox_BodyDesign.ValueMember = "Id";
            listbox_BodyDesign.DisplayMember = "Name";

            if (curBodyDesign != null)
            {
                listbox_BodyDesign.SelectedValue = curBodyDesign.Id;
            }
        }

        #endregion

        #region Button

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                BodyDesign bodyDesign = new BodyDesign();
                bodyDesign = FormToBodyDesign();

                BodyDesignArr oldBodyDesignArr = new BodyDesignArr();
                oldBodyDesignArr.Fill();

                if (!oldBodyDesignArr.IsContain(bodyDesign.Name))
                {
                    if (bodyDesign.Id == 0)
                    {
                        if (bodyDesign.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            BodyDesignArr bodyDesignArr = new BodyDesignArr();
                            bodyDesignArr.Fill();
                            bodyDesign = bodyDesignArr.GetBodyDesignWithMaxId();

                            BodyDesignArrToForm(bodyDesign);
                        }
                    }
                    else
                    {
                        if (bodyDesign.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            BodyDesignArr bodyDesignArr = new BodyDesignArr();
                            bodyDesignArr.Fill();
                            bodyDesign = bodyDesignArr.GetBodyDesignWithMaxId();
                            BodyDesignArrToForm(null);
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
            BodyDesign bodyDesign = FormToBodyDesign();

            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();

            if (bodyDesign.Id == 0)
            {

            }
            else
            {
                if (carDesignArr.DoesExist(bodyDesign))
                {
                    MessageBox.Show("You can not delete this Body Design, it is connected" +
                        " to 1 or more Orders", "Can not delete Car color",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Body Design? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        bodyDesign.Delete();
                        ClearForm();
                        BodyDesignArrToForm(null);
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


        public BodyDesign SelectedBodyDesign
        {
            get { return (listbox_BodyDesign.SelectedItem as BodyDesign); }
        }

    }
}
