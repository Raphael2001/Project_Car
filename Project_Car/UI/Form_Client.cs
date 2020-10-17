using Project_Car.BL;
using Project_Car.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Project_Car
{
    public partial class Form_Client : Form
    {
        Employee newemployee;

        public Form_Client(Employee employee)
        {
            InitializeComponent();

            ClientArrToForm(null);
            CityArrToForm(null);
            StreetArrToForm(null);

            ComboBoxSet();

            FillDates();

            newemployee = employee.CreateEmployee();

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
            

            btn_Save.Text = "Save Client";

            ClientArrToForm(null);

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

        private Client FormtoClient()
        {// מעביר את הנתונים שקיבלנו ללקוח
            Client client = new Client();

            client.Id = int.Parse(lbl_Idtxt.Text);
            client.Fullname = txt_FullName.Text;
            client.PhoneNumber = cmb_AreaPhoneNumber.Text + txt_PhoneNumber.Text;
            client.City = (cmb_City.SelectedItem as City);
            client.Street = (cmb_Street.SelectedItem as Street);
            client.Number = int.Parse(txt_Number.Text);
            client.Birthday = GetBirthday();
            if (rdb_Male.Checked)
            {
                client.Gender = rdb_Male.Text;
            }
            else
            {
                client.Gender = rdb_Female.Text;
            }
            client.Email = txt_Email.Text;

            return client;
        }

        private void ClientToForm(Client client)
        {// מעביר את הלקוח לפורם

            string areacode = client.PhoneNumber.Substring(0, 3);
            string phone = client.PhoneNumber.Substring(3, 7);

            lbl_Idtxt.Text = client.Id.ToString();
            txt_FullName.Text = client.Fullname;
            cmb_AreaPhoneNumber.Text = areacode;
            txt_PhoneNumber.Text = phone;
            cmb_City.SelectedValue = client.City.Id;
            cmb_Street.SelectedValue = client.Street.Id;
            txt_Number.Text = client.Number.ToString();
            SetDate(client.Birthday);
            if (client.Gender == "Male")
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_Female.Checked = true;
            }
            txt_Email.Text = client.Email;
        }

        public void CityArrToForm(City curCity)
        {
            CityArr cityArr = new CityArr();
            cityArr.Fill();

            cmb_City.DataSource = cityArr;
            cmb_City.ValueMember = "Id";
            cmb_City.DisplayMember = "Name";

            if (curCity != null)
            {
                cmb_City.SelectedValue = curCity.Id;
            }
        }

        public void StreetArrToForm(Street street)
        {
            StreetArr streetArr = new StreetArr();
            streetArr.Fill();

            cmb_Street.DataSource = streetArr;
            cmb_Street.ValueMember = "Id";
            cmb_Street.DisplayMember = "Name";

            if (street != null)
            {
                cmb_Street.SelectedValue = street.Id;
            }
        }

        private void ClientArrToForm(Client curClient)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            listbox_Clients.DataSource = clientArr;

            listbox_Clients.ValueMember = "ID";
            listbox_Clients.DisplayMember = "FullName";

            if (curClient != null)
            {
                listbox_Clients.SelectedValue = curClient.Id;
            }
        }

        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            btn_Save.Text = "Update Client";

            ClientToForm(listbox_Clients.SelectedItem as Client);
        }



        #endregion

        #region Check Data

        private bool CheckForm()
        { //בודק האם הנתונים שהקושו חוקיים 
            bool flag = true;

            InitForm();

            ClearError();

            #region Full Name
            if (txt_FullName.Text.Length < 2)
            {
                flag = false;
                asterix_FullName.ForeColor = Color.Red;
                lbl_ErrorFullName.Visible = true;
            }
            #endregion

            #region Phone Number
            if (cmb_AreaPhoneNumber.Text.Length<3 || txt_PhoneNumber.Text.Length < 7)
            {
                flag = false;
                asterix_PhoneNumber.ForeColor = Color.Red;
                lbl_ErrorPhoneNumber.Visible = true;
            }
            #endregion

            #region City
            if (cmb_City.Text == "")
            {
                flag = false;
                asterix_City.ForeColor = Color.Red;
                lbl_ErrorCity.Visible = true;
            }
            #endregion

            #region Street
            if (cmb_Street.Text == "")
            {
                flag = false;
                asterix_Street.ForeColor = Color.Red;
                lbl_ErrorStreet.Visible = true;
            }
            #endregion

            #region Number
            if (txt_Number.Text == "" ||! CheckintNumber(txt_Number))
            {
                flag = false;
                asterix_Number.ForeColor = Color.Red;
                lbl_ErrorNumber.Visible = true;
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

            return flag;
        }

        private bool IsDataExsits(string Email, string Phone)
        {
            // מחזיר האם האיימיל כבר קיםם במערכת
            Client client = new Client();

            int Count = client.CountEmail(Email);
            int CountPhone = client.CountPhone(Phone);

            if (CountPhone > 0)
            {
                MessageBox.Show("Phone Number is already in use", "Phone Number is unvalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else { }

            if (Count > 0)
            {
                MessageBox.Show("Email is already in use", "Email is unvalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool CheckintNumber(TextBox txt)
        {
            int v;
            bool isnum = int.TryParse(txt.Text, out v);
            return isnum;
        }
        #endregion

        #region Button


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormtoClient();

            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            if (client.Id == 0)
            {

            }
            else
            {
                if (orderRentArr.DoesExist(client) || orderBuyArr.DoesExist(client))
                {
                    MessageBox.Show("You can not delete this client, it is connected" +
                       " to 1 or more orders", "Can not delete client",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (MessageBox.Show("Are you sure you want to delete this client? ", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        client.Delete();
                        ClearForm();
                        ClientArrToForm(null);
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        { // שומר את המידע שקיבלנו לטבלה
            if (CheckForm())
            {

                Client client = FormtoClient();


                if (client.Id == 0)
                {

                    if (!IsDataExsits(client.Email, client.PhoneNumber))
                    {
                        
                        if (client.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();


                            ClientArr clientArr = new ClientArr();
                            clientArr.Fill();
                            client = clientArr.GetClientWithMaxId();

                            ClientArrToForm(client);
                        }
                    }
                }
                else
                {
                    if (client.Update())
                    {
                        MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form_FilterClient newform = new Form_FilterClient();
            if (newform.ShowDialog() == DialogResult.OK)
            {
               listbox_Clients.DataSource = newform.GetClients();
            }
            newform.Close();
            newform.Dispose();


        }

        #endregion

        private void ComboBoxSet()
        {

            cmb_BirthdayDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_BirthdayMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_BirthdayYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_City.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Street.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_BirthdayDay.DropDownHeight = cmb_BirthdayDay.Font.Height * 10;
            cmb_BirthdayMonth.DropDownHeight = cmb_BirthdayMonth.Height * 10;
            cmb_BirthdayYear.DropDownHeight = cmb_BirthdayYear.Font.Height * 10;
            cmb_City.DropDownHeight = cmb_BirthdayYear.Font.Height * 10;
            cmb_Street.DropDownHeight = cmb_Street.Height * 10;

            cmb_BirthdayDay.SelectedIndex = 0;
            cmb_BirthdayMonth.SelectedIndex = 0;
            cmb_BirthdayYear.SelectedIndex = 0;
            cmb_Street.SelectedIndex = -1;
            cmb_City.SelectedIndex = -1;
            cmb_Street.SelectedIndex = -1;
        }

        private void lbl_City_Click(object sender, EventArgs e)
        {
            Form_City newform = new Form_City(null);
            newform.ShowDialog();
            CityArrToForm(newform.SelectedCity);
        }

        private void lbl_Street_Click(object sender, EventArgs e)
        {
            Form_Street newform = new Form_Street(null);
            newform.ShowDialog();
            StreetArrToForm(newform.SelectedStreet);
        }

        public Client SelectedClient
        {
            get { return (listbox_Clients.SelectedItem as Client); }
        }
    }

}
