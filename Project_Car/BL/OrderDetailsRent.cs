using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class OrderDetailsRent
    {
        private int m_Id;
        private CarExtra m_CarExtra;
        private OrderRent m_OrderRent;

        public int Id { get => m_Id; set => m_Id = value; }
        public OrderRent OrderRent { get => m_OrderRent; set => m_OrderRent = value; }
        public CarExtra CarExtra { get => m_CarExtra; set => m_CarExtra = value; }

        public bool Insert()
        {
            return OrderDetailsRent_DAL.Insert(m_OrderRent.Id, m_CarExtra.Id);
        }

        public bool Update()
        {
            return OrderDetailsRent_DAL.Update(m_Id, m_OrderRent.Id, m_CarExtra.Id);
        }

        public bool Delete()
        {
            return OrderDetailsRent_DAL.Delete(m_Id);
        }

        public OrderDetailsRent()
        {
        }

        public OrderDetailsRent(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_OrderRent = new OrderRent(dataRow.GetParentRow("OrderDetailsRentOrder"));
            this.m_CarExtra = new CarExtra(dataRow.GetParentRow("OrderDetailsRentCarExtra"));
        }
    }
}
