using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Street
    {
        private int m_Id;
        private string m_Name;
        private int m_Number;

        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public int Number { get => m_Number; set => m_Number = value; }

        public bool Insert()
        {
            return Street_DAL.Insert(m_Name);
        }

        public bool Update()
        {
            return Street_DAL.Update(m_Id, m_Name);
        }

        public bool Delete()
        {
            return Street_DAL.Delete(Id);
        }

        public override string ToString()
        {
            return m_Name;
        }

        public Street(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["Id"];
            this.m_Name = dataRow["Name"].ToString();
        }

        public Street()
        {

        }
    }
}
