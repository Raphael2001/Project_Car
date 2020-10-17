using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class Product
    {
        private int m_Id;
        private Car m_Model;
        private string m_Status;
        private int m_Price;
        private string m_LicenseNumber;
        private string m_Doesavailable;

        public int Id { get => m_Id; set => m_Id = value; }
        public Car Model { get => m_Model; set => m_Model = value; }
        public string Status { get => m_Status; set => m_Status = value; }
        public string LicenseNumber { get => m_LicenseNumber; set => m_LicenseNumber = value; }
        public int Price { get => m_Price; set => m_Price = value; }
        public string Doesavailable { get => m_Doesavailable; set => m_Doesavailable = value; }


        public bool Insert()
        {
            return Product_DAL.Insert(m_Model.Id, m_Status, m_Price, m_LicenseNumber, m_Doesavailable);
        }

        public bool Update()
        {
            return Product_DAL.Update(m_Id, m_Model.Id, m_Status, m_Price, m_LicenseNumber, m_Doesavailable);
        }

        public bool Delete()
        {
            return Product_DAL.Delete(m_Id);
        }

        public override string ToString()
        {
            return m_Model.Company + " " + m_Model.Category.Name + " " +
                m_Model.Model + " - " + m_Status + " " + m_Doesavailable;
        }

        public Product(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Model = new Car(dataRow.GetParentRow("ProductModel"));
            this.m_Status = dataRow["Status"].ToString();
            this.m_Price = (int)dataRow["Price"];
            this.m_LicenseNumber = dataRow["LicenseNumber"].ToString();
            this.m_Doesavailable = dataRow["Doesavailable"].ToString();
        }

        public Product()
        {

        }

        public int Compare(object x, object y)
        {
            Product p1 = x as Product;
            Product p2 = y as Product;


            if (p1.Model.Company.Name.CompareTo(p2.Model.Company.Name) != 0)
                return p1.Model.Company.Name.CompareTo(p2.Model.Company.Name);
            else
            {
                if (p1.Model.Category.Name.CompareTo(p2.Model.Category.Name) != 0)
                    return p1.Model.Category.Name.CompareTo(p2.Model.Category.Name);
                else
                {
                    if (p1.Model.Model.CompareTo(p2.Model.Model) != 0)
                        return p1.Model.Model.CompareTo(p2.Model.Model);
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public Product(Product p1)
        {
            this.m_Id = p1.Id;
            this.m_Model = p1.m_Model;
            this.m_Status = p1.Status;
            this.m_Price = p1.Price;
            this.m_LicenseNumber = p1.m_LicenseNumber;
            this.m_Doesavailable = p1.m_Doesavailable;
        }

        public string FullModel
        {
            get
            {
                return m_Model.Company + " " + m_Model.Category.Name + " " +
                 m_Model.Model + " - " + m_Status + " " + m_Doesavailable;
            }
        }


        public string Model_V2
        {
            get
            {
                return m_Model.Company + " " + m_Model.Category.Name + " " +
                 m_Model.Model;
            }
        }


    }
}
