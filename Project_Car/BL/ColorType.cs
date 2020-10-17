using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
   public class ColorType
    {
        private int m_Id;
        private string m_Name;
        private int m_Price;

        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public int Price { get => m_Price; set => m_Price = value; }

        public bool Insert()
        {
            return ColorTypes_DAL.Insert(Name, Price);
        }

        public bool Update()
        {
            return ColorTypes_DAL.Update(Id, Name, Price);
        }

        public bool Delete()
        {
            return ColorTypes_DAL.Delete(Id);
        }

        public override string ToString()
        {
            return m_Name + " - " + m_Price;
        }

        public ColorType(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Name = dataRow["Name"].ToString();
            this.m_Price = (int)dataRow["Price"];
        }

        public ColorType()
        {

        }

    }
}
