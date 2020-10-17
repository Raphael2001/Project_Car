using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Client
    {
        #region Members

        private int m_Id;
        private string m_Fullname;
        private string m_PhoneNumber;
        private City m_City;
        private Street m_Street;
        private int m_Number;
        private DateTime m_Birthday;
        private string m_Gender;
        private string m_Email;
        private int m_Count;


        public string Fullname { get => m_Fullname; set => m_Fullname = value; }
        public string PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public DateTime Birthday { get => m_Birthday; set => m_Birthday = value; }
        public string Gender { get => m_Gender; set => m_Gender = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public City City { get => m_City; set => m_City = value; }
        public Street Street { get => m_Street; set => m_Street = value; }
        public int Number { get => m_Number; set => m_Number = value; }
        public int Count { get => m_Count; set => m_Count = value; }


        #endregion

        public bool Insert()
        {
            return Client_DAL.Insert(m_Fullname, m_PhoneNumber, m_City.Id, m_Street.Id, m_Number,
                m_Birthday, m_Gender, m_Email);
        }

        public int CountEmail(string Email)
        {
            return Client_DAL.CountEmail(Email);
        }

        public int CountPhone(string Phone)
        {
            return Client_DAL.CountPhone(Phone);
        }

        public Client()
        {

        }

        public Client(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Fullname = dataRow["Fullname"].ToString();
            this.m_PhoneNumber = dataRow["PhoneNumber"].ToString();
            this.m_Birthday = (DateTime)dataRow["Birthday"];
            this.m_Gender = dataRow["Gender"].ToString();
            this.m_Email = dataRow["Email"].ToString();
            this.m_City = new City(dataRow.GetParentRow("ClientCity"));
            this.m_Street = new Street(dataRow.GetParentRow("ClientStreet"));
            this.m_Number = (int)dataRow["Number"];
        }

        public override string ToString()
        {
            return m_Fullname + " - " + m_PhoneNumber;
        }

        public bool Update()
        {
            return Client_DAL.Update(m_Id, m_Fullname, m_PhoneNumber, m_City.Id, m_Street.Id, m_Number, m_Birthday, m_Gender, m_Email);
        }

        public bool Delete()
        {
            return Client_DAL.Delete(m_Id);
        }


        public string PhoneName
        {
            get
            {
                return Fullname + " " + PhoneNumber;
            }
        }

    }
}
