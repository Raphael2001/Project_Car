using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class PayBuy
    {
        #region Members

        private int m_Id;
        private OrderBuy m_Order;
        private DateTime m_Date;
        private string m_FullName;
        private string m_CardNumber;
        private string m_CVC;


        public int Id { get => m_Id; set => m_Id = value; }
        public OrderBuy Order { get => m_Order; set => m_Order = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public string FullName { get => m_FullName; set => m_FullName = value; }
        public string CardNumber { get => m_CardNumber; set => m_CardNumber = value; }
        public string CVC { get => m_CVC; set => m_CVC = value; }


        #endregion

        public bool Insert()
        {
            return PayBuy_DAL.Insert(m_Order.Id, m_FullName, m_CardNumber, m_Date, m_CVC);
        }

        public PayBuy()
        {

        }

        public PayBuy(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_Order = new OrderBuy(dataRow.GetParentRow("PayBuyOrderBuy"));
            this.m_Date = (DateTime)dataRow["Date"];
            this.m_FullName = dataRow["FullName"].ToString();
            this.m_CardNumber = dataRow["CardNumber"].ToString();
            this.m_CVC = dataRow["CVC"].ToString();
        }

        public override string ToString()
        {
            return m_FullName + "-" + CardNumber.Substring(CardNumber.Length - 4);
        }

        public bool Update()
        {
            return PayBuy_DAL.Update(m_Id, m_Order.Id, m_FullName, m_CardNumber, m_Date, m_CVC);
        }

        public bool Delete()
        {
            return PayBuy_DAL.Delete(Id);
        }

    }
}
