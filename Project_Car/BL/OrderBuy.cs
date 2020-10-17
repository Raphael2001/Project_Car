using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class OrderBuy
    {
        #region Members

        private int m_Id;
        private Client m_Client;
        private DateTime m_DateOfBuy;
        private string m_Comment;
        private Product m_Product;
        private CarDesign m_carDesign;
        private Employee m_Employee;
        private int m_TotalPrice;


        public int Id { get => m_Id; set => m_Id = value; }
        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime DateOfBuy { get => m_DateOfBuy; set => m_DateOfBuy = value; }
        public string Comment { get => m_Comment; set => m_Comment = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
        public CarDesign CarDesign { get => m_carDesign; set => m_carDesign = value; }
        public Employee Employee { get => m_Employee; set => m_Employee = value; }
        public int TotalPrice { get => m_TotalPrice; set => m_TotalPrice = value; }






        #endregion

        public bool Insert()
        {
            return OrderBuy_DAL.Insert(m_Client.Id, m_Product.Id, m_DateOfBuy, m_carDesign.Id, m_Employee.Id, m_Comment, m_TotalPrice);
        }

        public OrderBuy()
        {

        }

        public OrderBuy(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Client = new Client(dataRow.GetParentRow("OrderBuyClient"));
            this.m_Product = new Product(dataRow.GetParentRow("OrderBuyProduct"));
            this.m_DateOfBuy = (DateTime)dataRow["DateOfBuy"];
            this.m_carDesign = new CarDesign(dataRow.GetParentRow("OrderBuyCarDesign"));
            this.m_Employee = new Employee(dataRow.GetParentRow("OrderBuyEmployee"));
            this.m_Comment = dataRow["Comment"].ToString();
            this.m_TotalPrice = (int)dataRow["TotalPrice"];
        }

        public override string ToString()
        {
            return m_Client.Fullname + " - " + m_Product.Model.Company.Name + " " + m_Product.Model.Category.Name + " " +
                                            m_Product.Model.Model;
        }

        public bool Update()
        {
            return OrderBuy_DAL.Update(Id, m_Client.Id, m_Product.Id, m_DateOfBuy, m_carDesign.Id, m_Employee.Id, m_Comment, m_TotalPrice);
        }

        public bool Delete()
        {
            return OrderBuy_DAL.Delete(Id);
        }

        public string FullName
        {
            get
            {
                return m_Client.Fullname + " - " + m_Product.Model.Company.Name + " " + m_Product.Model.Category.Name + " " +
                                 m_Product.Model.Model;
            }
        }

    }
}
