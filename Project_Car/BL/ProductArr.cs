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
    public class ProductArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Product product;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                product = new Product(dataRow);

                this.Add(product);
            }
        }

        public ProductArr Filter(int Id, string LicenseNumber, string Status, Category category, Company company)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                Product car = (this[i] as Product);
                if
                    (
                    (Id <= 0 || car.Id == Id)
                    && (car.LicenseNumber.Contains(LicenseNumber))
                    && (car.Status.Contains(Status))
                    && ((category == null) || (car.Model.Category.Id == category.Id))
                    && ((company == null) || (car.Model.Company.Id == company.Id))
                    )
                {
                    productArr.Add(car);
                    if (Id > 0)
                        break;

                }

            }
            productArr.Sort();
            return productArr;
        }

        public ProductArr Filter(string Does)
        {
            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
            {
                Product car = (this[i] as Product);
                if (car.Doesavailable == Does)
                {
                    productArr.Add(car);
                }

            }
            productArr.Sort();
            return productArr;
        }

        public bool IsContainLicenseNumber(string ProductNumber)
        {
            string curProductNumber;

            for (int i = 0; i < this.Count; i++)
            {
                curProductNumber = (this[i] as Product).LicenseNumber;

                if (curProductNumber == ProductNumber)
                    return true;
            }
            return false;
        }

        public ProductArr Filter(Company company, int minPrice, int maxPrice)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                Product car = (this[i] as Product);
                if
                    (
                    (car.Price >= minPrice) && (car.Price <= maxPrice)
                    && ((company == null) || (car.Model.Company.Id == company.Id))
                    )
                {
                    productArr.Add(car);

                }

            }
            return productArr;
        }

        public ProductArr Filter(Company company)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                Product car = (this[i] as Product);
                if
                    
                     ((company == null) || (car.Model.Company.Id == company.Id))
                    
                {
                    productArr.Add(car);

                }

            }
            return productArr;
        }

        public int MaxPriceBuy()
        {
            int MaxPrice = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (((this[i] as Product).Price > MaxPrice) && ((this[i] as Product).Status == "Buy"))
                {
                    MaxPrice = (this[i] as Product).Price;
                }
            }
            return MaxPrice;

        }

        public int MaxPriceRent()
        {
            int MaxPrice = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (((this[i] as Product).Price > MaxPrice) && ((this[i] as Product).Status == "Rent"))
                {
                    MaxPrice = (this[i] as Product).Price;
                }
            }
            return MaxPrice;

        }

        public Product GetProduct(string Number)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).LicenseNumber == Number)
                {
                    return this[i] as Product;
                }
            }
            return null;
        }

        public new void Sort()
        {

            Product temp;
            Product p1, p2;
            for (int i = 0; i < this.Count; i++)
            {

                for (int j = i + 1; j < this.Count; j++)
                {
                    p1 = this[i] as Product;
                    p2 = this[j] as Product;

                    if ((this[i] as Product) != null && (this[j] as Product) != null)
                    {
                        if ((this[i] as Product).Compare(p1, p2) == 1)
                        {

                            temp = new Product(p1);
                            p1 = new Product(p2);
                            p2 = new Product(temp);

                            this[i] = p1;
                            this[j] = p2;

                        }
                    }
                }
            }
        }

        public void FillRent()
        {
            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Product product;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];



                product = new Product(dataRow);

                if (product.Status == "Rent")
                {
                    this.Add(product);
                }
            }
        }

        public void FillBuy()
        {
            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Product product;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];



                product = new Product(dataRow);

                if (product.Status == "Buy")
                {
                    this.Add(product);
                }
            }
        }

        public void FillRentAvailable(DateTime From, DateTime To)
        {
            DataTable dataTable = Product_DAL.GetDataTable();


            DataRow dataRow;
            Product product;

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            //  orderRentArr = orderRentArr.FilterNoReturned();
            orderRentArr = orderRentArr.Filter(From, To);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                product = new Product(dataRow);



                if (
                    (product.Status == "Rent")
                    && (!orderRentArr.DoesExist(product))
                    )
                {
                    this.Add(product);
                }

            }
        }

        public Product GetProductWithMaxId()
        {
            Product product = new Product();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Id > product.Id)
                {
                    product = this[i] as Product;
                }
            }
            return product;
        }

        public bool IsContains(Product product)
        {
            //מחזירה האם האוסף מכיל כבר את המוצר 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Id == product.Id)
                    return true;

            }
            return false;
        }

        public CarArr GetCarArr()
        {
            CarArr carArr = new CarArr();

            Product product;

            for (int i = 0; i < this.Count; i++)
            {
                product = (this[i] as Product); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!carArr.IsContains(product.Model))
                    carArr.Add(product.Model);
            }

            return carArr;
        }

        public ProductArr Filter(Car car)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                Product product = (this[i] as Product);
                if
                    (
                    ((car == null) || (product.Model.Id == car.Id))
                    )
                    productArr.Add(product);



            }
            return productArr;
        }

        public ProductArr Filter(Car car, DateTime dt)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                Product product = (this[i] as Product);
                if
                    (
                    ((car == null) || (product.Model.Id == car.Id))
                    )
                    productArr.Add(product);



            }
            return productArr;
        }

        public void FillRentAvailable()
        {
            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Product product;
            OrderRent orderRent;

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            // orderRentArr = orderRentArr.FilterNoReturned();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                product = new Product(dataRow);

                for (int j = 0; j < orderRentArr.Count; j++)
                {
                    orderRent = orderRentArr[j] as OrderRent;

                    if (
                        (product.Status == "Rent")
                        && (orderRent.Product.Id != product.Id)
                        && (orderRent.Product.Doesavailable == "InRent")
                        )
                    {
                        this.Add(product);
                    }
                }
            }
        }

        public void FillRentAvailableNew()
        {
            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Product product;


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                product = new Product(dataRow);

                if (
                    (product.Status == "Rent")
                    && (product.Doesavailable != "InRent")
                    )
                {
                    this.Add(product);
                }

            }
        }

        public void FillBuyAvailable()
        {
            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Product product;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                product = new Product(dataRow);

                if (
                    (product.Status == "Buy")
                    && (product.Doesavailable == "")
                    )
                {
                    this.Add(product);
                }
            }
        }

    }
}
