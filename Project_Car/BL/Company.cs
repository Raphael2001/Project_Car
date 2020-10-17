using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Company
    {
        private int m_Id;
        private string m_Name;

        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }

        public bool Insert()
        {
            return Company_DAL.Insert(Name);
        }

        public bool Update()
        {
            return Company_DAL.Update(Id, Name);
        }

        public bool Delete()
        {
            return Company_DAL.Delete(Id);
        }

        public override string ToString()
        {
            return  m_Name;
        }

        public Company(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Name = dataRow["Name"].ToString();
        }

        public Company()
        {

        }
    }
}
