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
    public class OrderDetailsRentArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = OrderDetailsRent_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            OrderDetailsRent orderDetailsRent;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                orderDetailsRent = new OrderDetailsRent(dataRow);

                this.Add(orderDetailsRent);
            }
        }

        public bool Insert()
        {

            //מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            bool flag = true;
            OrderDetailsRent orderDetailsRent = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsRent = (this[i] as OrderDetailsRent);
                if (!orderDetailsRent.Insert())
                    flag = false;

            }
            return flag;
        }

        public bool DoesExist(CarExtra curCarExtra)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderDetailsRent).CarExtra.Id == curCarExtra.Id)
                    return true;
            }
            return false;
        }

        public OrderDetailsRent GetOrderDetailsRentWithMaxId()
        {
            OrderDetailsRent orderDetailsRent = new OrderDetailsRent();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderDetailsRent).Id > orderDetailsRent.Id)
                {
                    orderDetailsRent = this[i] as OrderDetailsRent;
                }
            }
            return orderDetailsRent;
        }

        public OrderDetailsRentArr Filter(OrderRent orderRent)
        {
            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderDetailsRent orderDetailsRent = (this[i] as OrderDetailsRent);

                if ((orderRent == null) || (orderDetailsRent.OrderRent.Id == orderRent.Id))
                {
                    orderDetailsRentArr.Add(orderDetailsRent);
                }
            }

            return orderDetailsRentArr;
        }

        public OrderDetailsRentArr Filter(CarExtra carExtra)
        {
            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderDetailsRent orderDetailsRent = (this[i] as OrderDetailsRent);

                if ((carExtra == null) || (orderDetailsRent.CarExtra.Id == carExtra.Id))
                {
                    orderDetailsRentArr.Add(orderDetailsRent);
                }
            }

            return orderDetailsRentArr;
        }

        public CarExtraArr GetCarExtraArr()
        {
            CarExtraArr carExtraArr = new CarExtraArr();

            OrderDetailsRent orderDetailsRent;

            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsRent = (this[i] as OrderDetailsRent); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!carExtraArr.IsContains(orderDetailsRent.CarExtra))
                    carExtraArr.Add(orderDetailsRent.CarExtra);
            }

            return carExtraArr;
        }

        public OrderDetailsRentArr Filter(CarExtra carExtra, DateTime dt)
        {
            OrderDetailsRentArr orderDetailsRentArr = new OrderDetailsRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderDetailsRent orderDetailsRent = (this[i] as OrderDetailsRent);

                if (
                    ((carExtra == null) || (orderDetailsRent.CarExtra.Id == carExtra.Id))
                    && (orderDetailsRent.OrderRent.DateFrom >= dt)
                    )
                {
                    orderDetailsRentArr.Add(orderDetailsRent);
                }
            }

            return orderDetailsRentArr;
        }


        public bool Delete()
        {
            OrderDetailsRent orderDetailsRent = null;

            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsRent = (this[i] as OrderDetailsRent);

                if (!orderDetailsRent.Delete())
                {
                    return false;
                }
            }
            return true;
        }

        public CarExtraArr GetCarExtraArrByOrder(OrderRent orderRent)
        {
            CarExtraArr carExtraArr = new CarExtraArr();

            OrderDetailsRent orderDetailsRent;

            for (int i = 0; i < this.Count; i++)
            {
                orderDetailsRent = (this[i] as OrderDetailsRent); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if ((!carExtraArr.IsContains(orderDetailsRent.CarExtra))
                    && (orderDetailsRent.OrderRent.Id == orderRent.Id))
                {
                    carExtraArr.Add(orderDetailsRent.CarExtra);
                }
            }

            return carExtraArr;
        }

    }
}
