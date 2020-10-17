using Project_Car.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class OrderDetailsBuyArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = OrderDetailsBuy_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            OrderDetailsBuy orderDetailsBuy;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                orderDetailsBuy = new OrderDetailsBuy(dataRow);

                this.Add(orderDetailsBuy);
            }
        }

        public bool Insert()
        {

            //מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            bool flag = true;
            OrderDetailsBuy orderDetailsBuy = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsBuy = (this[i] as OrderDetailsBuy);
                if (!orderDetailsBuy.Insert())
                    flag = false;

            }
            return flag;
        }

        public bool DoesExist(CarExtra curCarExtra)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderDetailsBuy).CarExtra.Id == curCarExtra.Id)
                    return true;
            }
            return false;
        }

        public OrderDetailsBuy GetOrderDetailsBuyWithMaxId()
        {
            OrderDetailsBuy orderDetailsBuy = new OrderDetailsBuy();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderDetailsBuy).Id > orderDetailsBuy.Id)
                {
                    orderDetailsBuy = this[i] as OrderDetailsBuy;
                }
            }
            return orderDetailsBuy;
        }

        public OrderDetailsBuyArr Filter(OrderBuy orderBuy)
        {
            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderDetailsBuy orderDetailsBuy = (this[i] as OrderDetailsBuy);

                if ((orderBuy == null) || (orderDetailsBuy.OrderBuy.Id == orderBuy.Id))
                {
                    orderDetailsBuyArr.Add(orderDetailsBuy);
                }
            }

            return orderDetailsBuyArr;
        }

        public OrderDetailsBuyArr Filter(CarExtra carExtra)
        {
            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderDetailsBuy orderDetailsBuy = (this[i] as OrderDetailsBuy);

                if ((carExtra == null) || (orderDetailsBuy.CarExtra.Id == carExtra.Id))
                {
                    orderDetailsBuyArr.Add(orderDetailsBuy);
                }
            }

            return orderDetailsBuyArr;
        }

        public OrderDetailsBuyArr Filter(CarExtra carExtra, DateTime dt)
        {
            OrderDetailsBuyArr orderDetailsBuyArr = new OrderDetailsBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderDetailsBuy orderDetailsBuy = (this[i] as OrderDetailsBuy);

                if (
                    ((carExtra == null) || (orderDetailsBuy.CarExtra.Id == carExtra.Id))
                    && (orderDetailsBuy.OrderBuy.DateOfBuy >= dt)
                    )
                {
                    orderDetailsBuyArr.Add(orderDetailsBuy);
                }
            }

            return orderDetailsBuyArr;
        }

        public CarExtraArr GetCarExtraArr()
        {
            CarExtraArr carExtraArr = new CarExtraArr();

            OrderDetailsBuy orderDetailsBuy;

            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsBuy = (this[i] as OrderDetailsBuy); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!carExtraArr.IsContains(orderDetailsBuy.CarExtra))
                    carExtraArr.Add(orderDetailsBuy.CarExtra);
            }

            return carExtraArr;
        }

        public bool Delete()
        {
            OrderDetailsBuy orderDetailsBuy = null;

            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsBuy = (this[i] as OrderDetailsBuy);

                if (!orderDetailsBuy.Delete())
                {
                    return false;
                }
            }
            return true;
        }


    }

}

