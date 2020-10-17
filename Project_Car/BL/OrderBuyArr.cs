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
    public class OrderBuyArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = OrderBuy_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            OrderBuy orderBuy;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                orderBuy = new OrderBuy(dataRow);

                this.Add(orderBuy);
            }
        }

        public OrderBuyArr Filter(int id, string Client, DateTime Form, DateTime To)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);
                if
                    (
                    (id <= 0 || orderBuy.Id == id)
                    && orderBuy.Client.Fullname.Contains(Client)
                    && (orderBuy.DateOfBuy >= Form)
                    && (orderBuy.DateOfBuy <= To)
                    )
                    orderBuyArr.Add(orderBuy);



            }
            return orderBuyArr;
        }

        public DateTime GetMinDate()
        {
            DateTime min = DateTime.Now;

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderBuy).DateOfBuy < min)
                {
                    min = (this[i] as OrderBuy).DateOfBuy;
                }
            }
            return min;
        }

        public OrderBuyArr Filter(Employee employee, DateTime dateTime)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);
                if
                    (
                    ((employee == null) || (orderBuy.Employee.Id == employee.Id))
                    && ((orderBuy.DateOfBuy.Month == dateTime.Month) && (orderBuy.DateOfBuy.Year == dateTime.Year))
                    )
                    orderBuyArr.Add(orderBuy);



            }
            return orderBuyArr;
        }

        public bool DoesExist(CarDesign carDesign)

        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderBuy).CarDesign.Id == carDesign.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Client curClient)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderBuy).Client.Id == curClient.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Product curProduct)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderBuy).Product.Id == curProduct.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Employee curEmployee)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderBuy).Employee.Id == curEmployee.Id)
                    return true;
            }
            return false;
        }

        public OrderBuy GetOrderBuyWithMaxId()
        {
            OrderBuy orderBuy = new OrderBuy();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderBuy).Id > orderBuy.Id)
                {
                    orderBuy = this[i] as OrderBuy;
                }
            }
            return orderBuy;
        }

        public ProductArr GetProductArr()
        {
            ProductArr productArr = new ProductArr();

            OrderBuy orderBuy;

            for (int i = 0; i < this.Count; i++)
            {
                orderBuy = (this[i] as OrderBuy); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!productArr.IsContains(orderBuy.Product))
                    productArr.Add(orderBuy.Product);
            }

            return productArr;
        }

        public OrderBuyArr Filter(Product product)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);
                if
                    (
                    ((product == null) || (orderBuy.Product.Id == product.Id))
                    )
                    orderBuyArr.Add(orderBuy);



            }
            return orderBuyArr;
        }

        public CarDesignArr GetCarDesignArr()
        {
            CarDesignArr carDesignArr = new CarDesignArr();

            OrderBuy orderBuy;

            for (int i = 0; i < this.Count; i++)
            {
                orderBuy = (this[i] as OrderBuy); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!carDesignArr.IsContains(orderBuy.CarDesign))
                    carDesignArr.Add(orderBuy.CarDesign);
            }

            return carDesignArr;
        }

        public OrderBuyArr Filter(CarDesign carDesign, DateTime dt)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);

                if (
                    ((carDesign == null) || (orderBuy.CarDesign.Id == carDesign.Id))
                    && (orderBuy.DateOfBuy >= dt)
                    )
                {
                    orderBuyArr.Add(orderBuy);
                }
            }

            return orderBuyArr;
        }

        public OrderBuyArr Filter(Car car, DateTime dt)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);
                if
                    (
                    ((car == null) || (orderBuy.Product.Model.Id == car.Id))
                 && (orderBuy.DateOfBuy >= dt)
                    )
                    orderBuyArr.Add(orderBuy);



            }
            return orderBuyArr;
        }

        public EmployeeArr GetEmployeeArr()
        {
            EmployeeArr employeeArr = new EmployeeArr();

            OrderBuy orderBuy;

            for (int i = 0; i < this.Count; i++)
            {
                orderBuy = (this[i] as OrderBuy); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!employeeArr.IsContains(orderBuy.Employee))
                    employeeArr.Add(orderBuy.Employee);
            }

            return employeeArr;
        }

        public OrderBuyArr Filter( DateTime dt)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);
                if
                    (
                    (orderBuy.DateOfBuy.Year == dt.Year)
                    && (orderBuy.DateOfBuy.Month == dt.Month)
                    )
                    orderBuyArr.Add(orderBuy);



            }
            return orderBuyArr;
        }

        public OrderBuyArr Filter(Client client)
        {
            OrderBuyArr orderBuyArr = new OrderBuyArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderBuy orderBuy = (this[i] as OrderBuy);
                if
                    (
                    ((client == null) || (orderBuy.Client.Id == client.Id))
                    )
                    orderBuyArr.Add(orderBuy);



            }
            return orderBuyArr;
        }

        public ClientArr GetClientArr()
        {
            ClientArr clientArr = new ClientArr();

            OrderBuy orderBuy;

            for (int i = 0; i < this.Count; i++)
            {
                orderBuy = (this[i] as OrderBuy); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!clientArr.IsContains(orderBuy.Client))
                    clientArr.Add(orderBuy.Client);
            }

            return clientArr;
        }

    }
}
