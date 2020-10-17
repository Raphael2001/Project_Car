using Eramake;
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
    public partial class Form_EmployeeAuthentication : Form
    {
         Employee employee;

        public Form_EmployeeAuthentication()
        {
            InitializeComponent();

            lbl_HeadLine.Top = this.Top - (this.Top / 5);
            lbl_HeadLine.Left = this.Width / 2 - lbl_HeadLine.Width / 2;

        }

        public Employee GetEmployee(string Username, string Password)
        {
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            employeeArr = employeeArr.FilterUsername(Username, Password);
            return employeeArr[0] as Employee;
        }

        private bool CheckEmployee(string Username, string Password)
        {
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            employeeArr = employeeArr.FilterUsername(Username, Encrypt(Password));

            if (employeeArr.Count == 1)
            {
                return true;
            }
            return false;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                if (CheckEmployee(txt_Username.Text, txt_Password.Text))
                {
                    //Form_HomePage newform = new Form_HomePage(GetEmployee(txt_Username.Text, Encrypt(txt_Password.Text)));
                    //Hide();
                    //newform.ShowDialog();
                    //Close();

                    Form_Home newform = new Form_Home(GetEmployee(txt_Username.Text, Encrypt(txt_Password.Text)));
                    Hide();
                    newform.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("The Username or the password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckForm()
        {
            InitForm();
            ClearError();
            bool flag = true;


            if (txt_Username.Text == "")
            {
                flag = false;
                lbl_ErrorUsername.Visible = true;
                asterix_Usrrname.ForeColor = Color.Red;
            }
            if (txt_Password.Text == "")
            {
                flag = false;
                lbl_ErrorPassword.Visible = true;
                asterix_Password.ForeColor = Color.Red;

            }
            return flag;
        }

        #region Clear

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

        #region Change Color

        private void btn__MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Red;
        }

        private void btn__MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void btn__Enter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Red;
        }

        private void btn__Leave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        #endregion

        #region Password
        public string Encrypt(string input)
        {
            string output;
            return output = eCryptography.Encrypt(input);

        }

        public string DeCrypt(string input)
        {
            string output;
            return output = eCryptography.Decrypt(input);
        }
        #endregion

        private void btn_Admin_Click(object sender, EventArgs e)
        {

            string Username = "Admin", Password = "Admin1";
            if (CheckEmployee(Username, Password))
            {
                Form_Home newform = new Form_Home(GetEmployee(Username, Encrypt(Password)));
                Hide();
                newform.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("The Username or the password don't match", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        

       

       
    }
}
