using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Employee
    {
        #region Members

        private int m_Id;
        private string m_Fullname;
        private string m_Phonenumber;
        private DateTime m_Birthday;
        private string m_Gender;
        private string m_Email;
        private Role m_Role;
        private int m_Salary;
        private string m_Username;
        private string m_Password;

        public string Username { get => m_Username; set => m_Username = value; }
        public string Password { get => m_Password; set => m_Password = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public string Fullname { get => m_Fullname; set => m_Fullname = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public int Salary { get => m_Salary; set => m_Salary = value; }
        public string Phonenumber { get => m_Phonenumber; set => m_Phonenumber = value; }
        public DateTime Birthday { get => m_Birthday; set => m_Birthday = value; }
        public string Gender { get => m_Gender; set => m_Gender = value; }
        public Role Role { get => m_Role; set => m_Role = value; }
        #endregion


        public bool Insert()
        {
            return Employee_DAL.Insert(m_Fullname, m_Phonenumber, m_Birthday, m_Gender, m_Email, m_Role.Id, m_Salary, m_Username, m_Password);
        }

        public bool Update()
        {
            return Employee_DAL.Update(m_Id, m_Fullname, m_Phonenumber, m_Birthday, m_Gender, m_Email, m_Role.Id, m_Salary, m_Username, m_Password);
        }

        public bool Delete()
        {
            return Employee_DAL.Delete(m_Id);
        }

        public override string ToString()
        {
            return m_Fullname + " - "+ m_Role.JobTitle;
        }

        public string FullRole
        {
            get
            {
                return m_Fullname + " - " + m_Role.JobTitle;
            }
        }

        public string FullEmployee
        {
            get
            {
                return m_Fullname + " - " + m_Salary;
            }
        }

        public Employee(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Fullname = dataRow["Fullname"].ToString();
            this.m_Phonenumber = dataRow["Phone number"].ToString();
            this.m_Birthday = (DateTime)dataRow["Birthday"];
            this.m_Gender = dataRow["Gender"].ToString();
            this.m_Email = dataRow["Email"].ToString();
            this.m_Role = new Role(dataRow.GetParentRow("EmployeeRole"));
            this.m_Salary = (int)dataRow["Salary"];
            this.m_Username = dataRow["Username"].ToString();
            this.m_Password = dataRow["Password"].ToString();
        }

        public Employee()
        {

        }

        public Employee CreateEmployee()
        {
            Employee newemployee = new Employee();

            newemployee.Id = this.m_Id;
            newemployee.Fullname = this.m_Fullname;
            newemployee.Phonenumber = this.m_Phonenumber;
            newemployee.Birthday = this.m_Birthday;
            newemployee.Gender = this.m_Gender;
            newemployee.Email = this.m_Email;
            newemployee.Role=this.Role;
            newemployee.Salary = this.m_Salary;
            newemployee.Username = this.m_Username;
            newemployee.Password = this.m_Password;

            return newemployee;
        }
    }
}
