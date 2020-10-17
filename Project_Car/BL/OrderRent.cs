using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class OrderRent
    {
        private int m_Id;
        private Client m_Client;
        private DateTime m_DateFrom;
        private DateTime m_DateTo;
        private string m_Comment;
        private Product m_Product;
        private Employee m_Employee;
        private int m_TotalPrice;

        public int Id { get => m_Id; set => m_Id = value; }
        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime DateFrom { get => m_DateFrom; set => m_DateFrom = value; }
        public DateTime DateTo { get => m_DateTo; set => m_DateTo = value; }
        public string Comment { get => m_Comment; set => m_Comment = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
        public Employee Employee { get => m_Employee; set => m_Employee = value; }
        public int TotalPrice { get => m_TotalPrice; set => m_TotalPrice = value; }


        public OrderRent(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Client = new Client(dataRow.GetParentRow("OrderRentClient"));
            this.m_Product = new Product(dataRow.GetParentRow("OrderRentProduct"));
            this.m_DateFrom = (DateTime)dataRow["DateFrom"];
            this.m_DateTo = (DateTime)dataRow["DateTo"];
            this.m_Employee = new Employee(dataRow.GetParentRow("OrderRentEmployee"));
            this.m_Comment = dataRow["Comment"].ToString();
            this.m_TotalPrice = (int)dataRow["TotalPrice"];
        }

        public OrderRent()
        {

        }

        public override string ToString()
        {
            return m_Client.Fullname + " - " + m_Product.Model.Company.Name + " " + m_Product.Model.Category.Name + " " +
                    m_Product.Model.Model;
        }

        public bool Update()
        {
            return OrderRent_DAL.Update(Id, m_Client.Id, m_Product.Id, m_DateFrom, m_DateTo, m_Employee.Id, m_Comment, m_TotalPrice);
        }

        public bool Delete()
        {
            return OrderRent_DAL.Delete(Id);
        }
        public bool Insert()
        {
            return OrderRent_DAL.Insert(m_Client.Id, m_Product.Id, m_DateFrom, m_DateTo, m_Employee.Id, m_Comment, m_TotalPrice);
        }

        public string FullName
        {
            get
            {
                return m_Client.Fullname + " - " + m_Product.Model.Company.Name + " " + m_Product.Model.Category.Name + " " +
                                                m_Product.Model.Model;
            }
        }

        public string FullOrderRent
        {
            get
            {
                return m_Product.Model.Company.Name + " " + m_Product.Model.Category.Name + " " +
                        m_Product.Model.Model + " - " + m_Client.Fullname + " - " + m_DateTo.ToShortDateString();
            }
        }

    }
}
