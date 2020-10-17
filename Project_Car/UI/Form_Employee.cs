using Eramake;
using Project_Car.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Car.UI
{
    public partial class Form_Employee : Form
    {
        Employee newemployee;
        char[] Options ={'0','1','2','3','4','5','6','7','8','9','a','b','c',
            'd','e','f','g','h','i','j' ,'k','l','m','n','o','p','q','r','s','t','u',
            'v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','C','L','M',
            'N','O','P','Q','R','S','T','U','V','X','Y','Z'};

        public Form_Employee(Employee oldemployee)
        {
            InitializeComponent();

           
            EmployeeArrToForm();
            RoleArrToForm(null);

            ComboBoxSet();

            FillDates();

            newemployee = oldemployee.CreateEmployee();

            txt_Password.Text = GenratePassword();


        }

        private void ComboBoxSet()
        {

            cmb_BirthdayDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_BirthdayMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_BirthdayYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PhoneNumber.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_BirthdayDay.DropDownHeight = cmb_BirthdayDay.Font.Height * 10;
            cmb_BirthdayMonth.DropDownHeight = cmb_BirthdayMonth.Height * 10;
            cmb_BirthdayYear.DropDownHeight = cmb_BirthdayYear.Font.Height * 10;
            cmb_PhoneNumber.DropDownHeight = cmb_PhoneNumber.Height * 10;

            cmb_BirthdayDay.SelectedIndex = 0;
            cmb_BirthdayMonth.SelectedIndex = 0;
            cmb_BirthdayYear.SelectedIndex = 0;
            cmb_Role.SelectedIndex = -1;
        }

        #region Birthday

        private void FillDates()
        { // ממלא תאריכים 
            DateTime curretTime = DateTime.Now;

            for (int i = curretTime.Year - 120; i < curretTime.Year; i++)
            {
                cmb_BirthdayYear.Items.Add(i);
            }
            for (int j = 1; j <= 31; j++)
            {
                cmb_BirthdayDay.Items.Add(j);
            }


        }

        private bool IsValidBirthday()
        { // האם התאריך שקיבלנו תקין
            DateTime dateTime;
            string strBirthday = ConvertBirthdayToString();

            return DateTime.TryParse(strBirthday, out dateTime);
        }

        private string ConvertBirthdayToString()
        {// ממיר תאריך לסטרינג
            string day, month, year;

            day = cmb_BirthdayDay.SelectedIndex > 0 ? cmb_BirthdayDay.Text : "0";
            month = cmb_BirthdayMonth.SelectedIndex > 0 ? cmb_BirthdayMonth.Text : "0";
            year = cmb_BirthdayYear.SelectedIndex > 0 ? cmb_BirthdayYear.Text : "0";

            return day + month + year;
        }

        private DateTime GetBirthday()
        {// מחזיר טיפוס מסוג דייטיים עם התאריך שהקישו
            DateTime birthday;

            DateTime.TryParse(ConvertBirthdayToString(), out birthday);

            return birthday;
        }

        private void SetDate(DateTime birthday)
        {
            // מסדר את התאריך המקובל בפורם
            cmb_BirthdayDay.Text = birthday.Day.ToString();
            cmb_BirthdayMonth.SelectedIndex = birthday.Month;
            cmb_BirthdayYear.Text = birthday.Year.ToString();

        }

        #endregion

        #region Clear

        private void ClearForm()
        {

            btn_Save.Text = "Save Employee";

            EmployeeArrToForm();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    if (ctrl.Name.StartsWith("cmb_Birthday"))
                    {
                        (ctrl as ComboBox).SelectedIndex = 0;
                    }
                    else
                    {
                        (ctrl as ComboBox).SelectedIndex = -1;
                    }
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

            txt_Password.Text = GenratePassword();
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

        #region Check Data

        public bool CheckintNumber(TextBox txt)
        {
            int v;
            bool isnum = int.TryParse(txt.Text, out v);
            return isnum;
        }

        private bool CheckForm()
        { //בודק האם הנתונים שהקושו חוקיים 
            bool flag = true;

            InitForm();

            ClearError();

            #region Full Name

            if (txt_FullName.Text == "")
            {
                flag = false;
                asterix_FullName.ForeColor = Color.Red;
                lbl_ErrorFullName.Visible = true;
            }
            #endregion

            #region Phone Number
            if (cmb_PhoneNumber.SelectedIndex == -1 || txt_PhoneNumber.Text.Length < 7)
            {
                flag = false;
                asterix_PhoneNumber.ForeColor = Color.Red;
                lbl_ErrorPhoneNumber.Visible = true;
            }
            #endregion

            #region Birthday
            if (!IsValidBirthday())
            {
                flag = false;
                asterix_Birthday.ForeColor = Color.Red;
                lbl_ErrorBirthDay.Visible = true;
            }
            #endregion

            #region Gender
            if (!rdb_Male.Checked && !rdb_Female.Checked)
            {
                flag = false;
                asterix_Gender.ForeColor = Color.Red;
                lbl_ErrorGender.Visible = true;
            }
            #endregion

            #region E-Mail
            if (!IsValidEmail(txt_Email.Text))
            {
                flag = false;
                asterix_Email.ForeColor = Color.Red;
                lbl_ErrorEmail.Visible = true;
            }
            #endregion

            #region Role
            if (cmb_Role.SelectedIndex == -1)
            {
                flag = false;
                asterix_Role.ForeColor = Color.Red;
                lbl_ErrorRole.Visible = true;
            }
            #endregion

            #region Salary
            if (txt_Salary.Text == "" || !CheckintNumber(txt_Salary))
            {
                flag = false;
                asterix_Salary.ForeColor = Color.Red;
                lbl_ErrorSalary.Visible = true;
            }
            #endregion

            #region Username
            if (txt_Username.Text == "")
            {
                flag = false;
                asterix_Username.ForeColor = Color.Red;
                lbl_ErrorUsername.Visible = true;
            }
            #endregion


            return flag;
        }

        private bool IsDataExsits(string Email, string Phone, string Username)
        {
            // מחזיר האם האיימיל כבר קיםם במערכת

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            if (employeeArr.IsContainPhone(Phone))
            {
                MessageBox.Show("Phone Number is already in use", "Phone Number is unvalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else { }

            if (employeeArr.IsContainEmail(Email))
            {
                MessageBox.Show("Email is already in use", "Email is unvalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }
            else { }

            if (employeeArr.IsContainUsername(Username))
            {
                MessageBox.Show("Username is already in use", "Username is unvalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }
            else { }

            return false;




        }

        public bool IsValidEmail(string email)
        { // בודק האם האיימל תקין
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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

        private Employee FormtoEmployee()
        {// מעביר את הנתונים שקיבלנו ללקוח
            Employee employee = new Employee();

            employee.Id = int.Parse(lbl_Idtxt.Text);
            employee.Fullname = txt_FullName.Text;
            employee.Phonenumber = cmb_PhoneNumber.Text + txt_PhoneNumber.Text;
            employee.Birthday = GetBirthday();
            if (rdb_Male.Checked)
            {
                employee.Gender = rdb_Male.Text;
            }
            else
            {
                employee.Gender = rdb_Female.Text;
            }
            employee.Email = txt_Email.Text;
            employee.Role = (cmb_Role.SelectedItem as Role);
            employee.Salary = Convert.ToInt32(txt_Salary.Text);
            employee.Username = txt_Username.Text;
            employee.Password = Encrypt(txt_Password.Text);

            return employee;
        }

        private void EmployeeToForm(Employee employee)
        {// מעביר את הלקוח לפורם

            string areacode = employee.Phonenumber.Substring(0, 3);
            string phone = employee.Phonenumber.Substring(3, 7);

            lbl_Idtxt.Text = employee.Id.ToString();
            txt_FullName.Text = employee.Fullname;
            cmb_PhoneNumber.Text = areacode;
            txt_PhoneNumber.Text = phone;
            SetDate(employee.Birthday);
            if (employee.Gender == "Male")
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_Female.Checked = true;
            }
            txt_Email.Text = employee.Email;
            cmb_Role.SelectedValue = employee.Role.Id;
            txt_Salary.Text = employee.Salary.ToString();
            txt_Username.Text = employee.Username;
            txt_Password.Text = DeCrypt(employee.Password);
        }

        private void EmployeeArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס 
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            listbox_Employees.DataSource = employeeArr;

        }

        public void RoleArrToForm(Role role)
        {
            RoleArr roleArr = new RoleArr();
            roleArr.Fill();

            cmb_Role.DataSource = roleArr;
            cmb_Role.ValueMember = "Id";
            cmb_Role.DisplayMember = "JobTitle";

            if (role != null)
            {
                cmb_Role.SelectedValue = role.Id;
            }
        }

        private void listBox_Employee_DoubleClick(object sender, EventArgs e)
        {
            btn_Save.Text = "Update Employee";


            EmployeeToForm(listbox_Employees.SelectedItem as Employee);
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

        public string GenratePassword()
        {
            Random rand = new Random();
            string Password = "";
            for (int i = 0; i < 6; i++)
            {
                Password += Options[rand.Next(0, Options.Length)];
            }
            return Password;
        }

        #endregion

        #region Button

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Employee employee = FormtoEmployee();

            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            if (employee.Id == 0)
            {

            }
            else
            {
                if (orderRentArr.DoesExist(employee) || orderBuyArr.DoesExist(employee))
                {
                    MessageBox.Show("You can not delete this employee, it is connected" +
                       " to 1 or more orders", "Can not delete employee",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this employee? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        employee.Delete();
                        ClearForm();
                        EmployeeArrToForm();

                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        { // שומר את המידע שקיבלנו לטבלה
            if (CheckForm())
            {

                Employee employee = FormtoEmployee();

                if (employee.Id == 0)
                {

                    if (!IsDataExsits(employee.Email, employee.Phonenumber, employee.Username))
                    {
                        if (employee.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                    }
                }
                else
                {

                    if (employee.Update())
                    {
                        MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();

                        if (employee.Id == newemployee.Id)
                        {
                            newemployee = employee.CreateEmployee();
                        }

                    }
                }
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
         

            Form_FilterEmployee newform = new Form_FilterEmployee();
            if (newform.ShowDialog() == DialogResult.OK)
            {
                listbox_Employees.DataSource = newform.GetEmployees();
               
            }
            newform.Close();
            newform.Dispose();


        }

        #endregion

    }
}
