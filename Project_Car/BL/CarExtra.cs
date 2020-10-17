using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class CarExtra
    {
        private int m_Id;
        private string m_Name;
        private int m_Price;
        private int m_Count;

        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public int Price { get => m_Price; set => m_Price = value; }
        public int Count { get => m_Count; set => m_Count = value; }


        public bool Insert()
        {
            return CarExtra_DAL.Insert(Name, Price, m_Count);
        }

        public bool Update()
        {
            return CarExtra_DAL.Update(Id, Name, Price, m_Count);
        }

        public bool Delete()
        {
            return CarExtra_DAL.Delete(Id);
        }

        public override string ToString()
        {
            return m_Name + " - " + m_Price + "," + " ( Left" + " " + m_Count + " )";
        }

        public CarExtra(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Name = dataRow["Name"].ToString();
            this.m_Price = (int)dataRow["Price"];
            this.m_Count = (int)dataRow["Count"];
        }

        public CarExtra()
        {

        }

        public string FullExtra
        {
            get
            {
                return m_Name + " - " + m_Price + "," + " ( Left" + " " + m_Count +" )";
            }
        }

    }
}
