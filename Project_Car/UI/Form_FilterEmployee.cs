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
    public partial class Form_FilterEmployee : Form
    {
        public Form_FilterEmployee()
        {
            InitializeComponent();
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

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;
            //אם המשתמש רשם ערך בשדה המזהה
            if (txt_Id.Text != "")
                id = int.Parse(txt_Id.Text);

            //מייצרים אוסף של כלל הלקוחות 
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            employeeArr = employeeArr.Filter(id, txt_Name.Text, txt_PhoneNumber.Text);

            //מציבים בתיבת הרשימה את אוסף הלקוחות 

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            Close();
        }

        public EmployeeArr GetEmployees()
        {
            int id = 0;
            //אם המשתמש רשם ערך בשדה המזהה
            if (txt_Id.Text != "")
                id = int.Parse(txt_Id.Text);

            //מייצרים אוסף של כלל הלקוחות 
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            employeeArr = employeeArr.Filter(id, txt_Name.Text, txt_PhoneNumber.Text);

            return employeeArr;
        }

        public EmployeeArr GetEmployees_V2()
        {
            int id = 0;
            //אם המשתמש רשם ערך בשדה המזהה
            if (txt_Id.Text != "")
                id = int.Parse(txt_Id.Text);

            //מייצרים אוסף של כלל הלקוחות 
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.FillNew();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש 
            employeeArr = employeeArr.Filter(id, txt_Name.Text, txt_PhoneNumber.Text);

            return employeeArr;
        }

        private void Form_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
