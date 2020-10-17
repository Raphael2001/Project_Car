using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Role
    {
        private int m_Id;
        private string m_JobTitle;

        public int Id { get => m_Id; set => m_Id = value; }
        public string JobTitle { get => m_JobTitle; set => m_JobTitle = value; }


        public bool Insert()
        {
            return Role_DAL.Insert(m_JobTitle);
        }

        public bool Update()
        {
            return Role_DAL.Update(m_Id, m_JobTitle);
        }

        public bool Delete()
        {
            return Role_DAL.Delete(m_Id);
        }

        public override string ToString()
        {
            return m_Id + " " + m_JobTitle;
        }

        public Role(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_JobTitle = dataRow["Job Title"].ToString();
        }

        public Role()
        {

        }
    }
}
