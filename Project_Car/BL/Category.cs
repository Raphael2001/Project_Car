using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
   public class Category
    {
        private int m_Id;
        private Company m_Company;
        private string m_Name;

        public int Id { get => m_Id; set => m_Id = value; }
        public Company Company { get => m_Company; set => m_Company = value; }
        public string Name { get => m_Name; set => m_Name = value; }

        public bool Insert()
        {
            return Category_DAL.Insert(m_Company.Id,m_Name);
        }

        public bool Update()
        {
            return Category_DAL.Update(m_Id, m_Company.Id, m_Name);
        }

        public bool Delete()
        {
            return Category_DAL.Delete(m_Id);
        }

        public override string ToString()
        {
            return m_Company + " " + m_Name;
        }

        public string FullName
        {
            get
            {
                return m_Company + " " + m_Name;
            }
        }

        public Category(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Company = new Company(dataRow.GetParentRow("CategoryCompany"));
            this.m_Name = dataRow["Name"].ToString();
        }

        public Category()
        {

        }
    }
}
