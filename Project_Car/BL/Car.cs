using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Car
    {
        private int m_Id;
        private string m_Model;
        private Company m_Company;
        private Category m_Category;
        private Engine m_Engine;
        private int m_HorsePower;

        public string Model { get => m_Model; set => m_Model = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        internal Engine Engine { get => m_Engine; set => m_Engine = value; }
        internal Company Company { get => m_Company; set => m_Company = value; }
        public int HorsePower { get => m_HorsePower; set => m_HorsePower = value; }
        internal Category Category { get => m_Category; set => m_Category = value; }



        public Car()
        {

        }

        public bool Insert()
        {
            return Car_DAL.Insert(m_Model, m_Company.Id, Category.Id, m_Engine.Id, m_HorsePower);
        }

        public bool Update()
        {
            return Car_DAL.Update(m_Id, m_Model, m_Company.Id, Category.Id, m_Engine.Id, m_HorsePower);
        }

        public bool Delete()
        {
            return Car_DAL.Delete(m_Id);
        }

        public Car(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Model = dataRow["Model"].ToString();
            this.m_Company = new Company(dataRow.GetParentRow("CarCompany"));
            this.Category = new Category(dataRow.GetParentRow("CarCategory"));
            this.m_Engine = new Engine(dataRow.GetParentRow("CarEngine"));
            this.m_HorsePower = (int)dataRow["Horse Power"];


        }

        public int Compare(object x, object y)
        {
            Car c1 = x as Car;
            Car c2 = y as Car;
            if (c1.Company.Name.CompareTo(c2.Company.Name) != 0)
                return c1.Company.Name.CompareTo(c2.Company.Name);
            else
            {
                if (c1.Category.Name.CompareTo(c2.Category.Name) != 0)
                    return c1.Category.Name.CompareTo(c2.Category.Name);
                else
                {
                    if (c1.Model.CompareTo(c2.Model) != 0)
                        return c1.Model.CompareTo(c2.Model);
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public override string ToString()
        {
            return Category + " " + m_Model;
        }

        public Car(Car c1)
        {
            
            this.m_Model = c1.Model;
            this.m_Id = c1.Id;
            this.m_Engine = c1.Engine;
            this.m_Company = c1.Company;
            this.m_HorsePower = c1.HorsePower;
            this.m_Category = c1.Category;


        }

        public string FullModel
        {
            get
            {
                return m_Company + " " + m_Category.Name + " " +
                 m_Model;
            }
        }
    }
}
