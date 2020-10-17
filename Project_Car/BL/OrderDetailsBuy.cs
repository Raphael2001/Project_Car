using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class OrderDetailsBuy
    {
        private int m_Id;
        private CarExtra m_CarExtra;
        private OrderBuy m_OrderBuy;

        public int Id { get => m_Id; set => m_Id = value; }
        public OrderBuy OrderBuy { get => m_OrderBuy; set => m_OrderBuy = value; }
        public CarExtra CarExtra { get => m_CarExtra; set => m_CarExtra = value; }

        public bool Insert()
        {
            return OrderDetailsBuy_DAL.Insert(m_OrderBuy.Id, m_CarExtra.Id);
        }

        public bool Update()
        {
            return OrderDetailsBuy_DAL.Update(m_Id, m_OrderBuy.Id, m_CarExtra.Id);
        }

        public bool Delete()
        {
            return OrderDetailsBuy_DAL.Delete(m_Id);
        }

        public OrderDetailsBuy()
        {
        }

        public OrderDetailsBuy(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_OrderBuy = new OrderBuy(dataRow.GetParentRow("OrderDetailsBuyOrder"));
            this.m_CarExtra = new CarExtra(dataRow.GetParentRow("OrderDetailsBuyCarExtra"));
        }
    }
}
