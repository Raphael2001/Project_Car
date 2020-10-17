using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class City
    {
        private int m_Id;
        private string m_Name;

        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }

        public bool Insert()
        {
            return City_DAL.Insert(Name);
        }

        public bool Update()
        {
            return City_DAL.Update(Id, Name);
        }

        public bool Delete()
        {
            return City_DAL.Delete(Id);
        }

        public override string ToString()
        {
            return m_Id + " " + m_Name;
        }

        public City(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Name = dataRow["Name"].ToString();
        }

        public City()
        {

        }

    }
}
