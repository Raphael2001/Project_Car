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
    public partial class Form_Role : Form
    {
        Employee newemployee;
        public Form_Role(Employee employee)
        {
            InitializeComponent();

            newemployee = employee.CreateEmployee();

            RoleArrToForm(null);
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

            btn_Save.Text = "Save Role";

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

        public bool CheckForm()
        {
            bool flag = true;

            InitForm();

            ClearError();

            #region Name
            if (txt_Title.Text.Length < 2)
            {
                flag = false;
                asterix_Title.ForeColor = Color.Red;
                lbl_ErrorTitle.Visible = true;
            }
            #endregion



            return flag;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_HomePage newform = new Form_HomePage(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void RoleArrToForm(Role curRole)
        {
            RoleArr roleArr = new RoleArr();
            roleArr.Fill();

            listbox_Role.DataSource = roleArr;
            listbox_Role.ValueMember = "Id";
            listbox_Role.DisplayMember = "JobTitle";

            if (curRole != null)
            {
                listbox_Role.SelectedValue = curRole.Id;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                Role role = new Role();
                role = FormToRole();

                RoleArr oldRoleArr = new RoleArr();
                oldRoleArr.Fill();

                if (!oldRoleArr.IsContain(role.JobTitle))
                {
                    if (role.Id == 0)
                    {
                        if (role.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            RoleArr roleArr = new RoleArr();
                            roleArr.Fill();
                            role = roleArr.GetRoleWithMaxId();

                            RoleArrToForm(role);
                        }
                    }
                    else
                    {
                        if (role.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            RoleArr roleArr = new RoleArr();
                            roleArr.Fill();
                            role = roleArr.GetRoleWithMaxId();
                            RoleArrToForm(role);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Role already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        #region Transfer Data

        private Role FormToRole()
        {
            Role role = new Role();

            role.Id = int.Parse(lbl_Idtxt.Text);
            role.JobTitle = txt_Title.Text;

            return role;
        }

        private void RoleToForm(Role role)
        {
            lbl_Idtxt.Text = role.Id.ToString();
            txt_Title.Text = role.JobTitle;
        }

        #endregion

        private void listbox_Role_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Role";
            RoleToForm(listbox_Role.SelectedItem as Role);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Role role = FormToRole();
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            if (role.Id == 0)
            {

            }
            else
            {
                if (employeeArr.DoesExist(role))
                {
                    MessageBox.Show("You can not delete this role, it is connected" +
                        " to 1 or more Employee", "Can not delete role",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Role? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        role.Delete();
                        ClearForm();
                        RoleArrToForm(null);
                    }
                }
            }
        }
    }
}
