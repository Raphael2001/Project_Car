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
    public partial class Form_PasswordUpdate : Form
    {
        Employee newemployee = new Employee();


        public Form_PasswordUpdate(Employee oldemployee)
        {
            InitializeComponent();

            newemployee = oldemployee.CreateEmployee();

        }

        public bool UpdatePassword()
        {
            if (txt_Old.Text == DeCrypt(newemployee.Password))
            {

                if (txt_New.Text.Length >= 6)
                {
                    newemployee.Password = Encrypt(txt_New.Text);
                }
                else
                {
                    lbl_ErrorNew.Visible = true;
                    txt_New.Clear();


                }
            }
            else
            {
                lbl_ErrorOld.Visible = true;
                txt_Old.Clear();
            }
            return lbl_ErrorOld.Visible || lbl_ErrorNew.Visible;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            if (!UpdatePassword())
            {

                if (newemployee.Update())
                {
                    MessageBox.Show("Password Updated", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_New.Clear();
                    txt_Old.Clear();

                    //Form_HomePage newform = new Form_HomePage(newemployee);
                    //Hide();
                    //newform.ShowDialog();
                    //Close();
                }
            }
        }

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_HomePage newform = new Form_HomePage(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }
    }
}
