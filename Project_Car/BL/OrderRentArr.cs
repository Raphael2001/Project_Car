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
    public class OrderRentArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = OrderRent_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            OrderRent orderRent;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                orderRent = new OrderRent(dataRow);

                this.Add(orderRent);
            }
        }

        public OrderRentArr Filter(int id, string Client, DateTime From, DateTime To)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    (id <= 0 || orderRent.Id == id)
                    && orderRent.Client.Fullname.Contains(Client)
                    && (orderRent.DateFrom >= From)
                    && (orderRent.DateTo <= To)
                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

        public DateTime GetMinDate()
        {
            DateTime min = DateTime.Now;

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).DateFrom < min)
                {
                    min = (this[i] as OrderRent).DateFrom;
                }
            }
            return min;
        }

        public OrderRentArr Filter(Employee employee, DateTime dateTime)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    ((employee == null) || (orderRent.Employee.Id == employee.Id))
                    && ((orderRent.DateFrom.Month == dateTime.Month) && (orderRent.DateFrom.Year == dateTime.Year))

                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

        public OrderRentArr Filter(Client client, Product product)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    ((client == null) || (orderRent.Client.Id == client.Id))
                    && ((product == null) || (orderRent.Product.Id == product.Id))


                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

        public OrderRentArr Filter(Client client, Product product, DateTime dateTime)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    ((client == null) || (orderRent.Client.Id == client.Id))
                    && ((product == null) || (orderRent.Product.Id == product.Id))
                    && (orderRent.DateTo.Date == dateTime.Date)


                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

        public OrderRent GetOrderRentWithMaxId()
        {
            OrderRent orderRent = new OrderRent();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Id > orderRent.Id)
                {
                    orderRent = this[i] as OrderRent;
                }
            }
            return orderRent;
        }

        public bool DoesExist(Client curClient)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Client.Id == curClient.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Product curProduct)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Product.Id == curProduct.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Employee curEmployee)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Employee.Id == curEmployee.Id)
                    return true;
            }
            return false;
        }


        public OrderRentArr FilterNoReturned()
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    (orderRent.Product.Doesavailable == "InRent")
                    )

                    orderRentArr.Add(orderRent);

            }
            return orderRentArr;
        }


        public OrderRentArr Filter(DateTime dt)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    (orderRent.DateFrom.Year == dt.Year)
                    && (orderRent.DateFrom.Month == dt.Month)
                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }


        public OrderRentArr Filter(Product product)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    ((product == null) || (orderRent.Product.Id == product.Id))
                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

        public ProductArr GetProductArr()
        {
            ProductArr productArr = new ProductArr();

            OrderRent orderRent;

            for (int i = 0; i < this.Count; i++)
            {
                orderRent = (this[i] as OrderRent); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!productArr.IsContains(orderRent.Product))
                    productArr.Add(orderRent.Product);
            }

            return productArr;
        }

        public ProductArr Filter(Car car, DateTime dt)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    ((car == null) || (orderRent.Product.Model.Id == car.Id))
                    && (orderRent.DateFrom > dt)
                    )
                    productArr.Add(orderRent);



            }
            return productArr;
        }

        public EmployeeArr GetEmployeeArr()
        {
            EmployeeArr employeeArr = new EmployeeArr();

            OrderRent orderRent;

            for (int i = 0; i < this.Count; i++)
            {
                orderRent = (this[i] as OrderRent);
                if (!employeeArr.IsContains(orderRent.Employee))
                    employeeArr.Add(orderRent.Employee);
            }

            return employeeArr;
        }

        public OrderRentArr GetProductsWithLastDate()
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                   (
                   (!orderRentArr.IsContains(orderRent.Product))
                   )
                    orderRentArr.Add(orderRent);
                else
                {
                    OrderRent new_OrderRent = Contain(orderRent.Product);
                    if (orderRent.DateTo > new_OrderRent.DateTo)
                    {
                        orderRentArr.Remove(new_OrderRent);
                        orderRentArr.Add(orderRent);

                    }
                }



            }
            return orderRentArr;
        }

        public bool IsContains(Product product)
        {
            //מחזירה האם האוסף מכיל כבר את המוצר 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Product.Id == product.Id)
                    return true;

            }
            return false;
        }

        public OrderRent Contain(Product product)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Product.Id == product.Id)
                    return this[i] as OrderRent;

            }
            return null;
        }

        public void Remove(OrderRent orderRent)
        {
            //מסירה מהאוסף הנוכחי את הפריט המתקבל 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderRent).Id == orderRent.Id)
                {
                    this.RemoveAt(i);
                    break;
                }
            }
        }

        public OrderRentArr Filter(DateTime From, DateTime To)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (

                    (orderRent.DateFrom >= From)
                    && (orderRent.DateTo <= To)
                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

        public ClientArr GetClientArr()
        {
            ClientArr clientArr = new ClientArr();

            OrderRent orderRent;

            for (int i = 0; i < this.Count; i++)
            {
                orderRent = (this[i] as OrderRent); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!clientArr.IsContains(orderRent.Client))
                    clientArr.Add(orderRent.Client);
            }

            return clientArr;
        }

        public OrderRentArr Filter(Client client)
        {
            OrderRentArr orderRentArr = new OrderRentArr();

            for (int i = 0; i < this.Count; i++)
            {
                OrderRent orderRent = (this[i] as OrderRent);
                if
                    (
                    ((client == null) || (orderRent.Client.Id == client.Id))
                    )
                    orderRentArr.Add(orderRent);



            }
            return orderRentArr;
        }

    }
}
