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
    public class CarArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Car_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Car car;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                car = new Car(dataRow);

                this.Add(car);
            }
        }

        public CarArr Filter(int id, Category category, Company company)
        {
            CarArr productArr = new CarArr();

            for (int i = 0; i < this.Count; i++)
            {
                Car product = (this[i] as Car);
                if
                    (
                    (id <= 0 || product.Id == id)
                    && ((category == null) || (product.Category.Id == category.Id))
                    && ((company == null) || (product.Company.Id == company.Id))
                    )
                {
                    productArr.Add(product);
                    if (id > 0)
                        break;

                }

            }
            return productArr;
        }

        public bool DoesExist(Company curCompany)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Car).Company.Id == curCompany.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Engine curEngine)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Car).Engine.Id == curEngine.Id)
                    return true;
            }
            return false;
        }

        public new void Sort()
        {

            Car temp;
            Car c1, c2;
            for (int i = 0; i < this.Count; i++)
            {

                for (int j = i + 1; j < this.Count; j++)
                {
                    c1 = this[i] as Car;
                    c2 = this[j] as Car;

                    if ((this[i] as Car) != null && (this[j] as Car) != null)
                    {
                        if ((this[i] as Car).Compare(c1, c2) == 1)
                        {

                            temp = new Car(c1);
                            c1 = new Car(c2);
                            c2 = new Car(temp);

                            this[i] = c1;
                            this[j] = c2;

                        }
                    }
                }
            }
        }

        public Car GetCarWithMaxId()
        {
            Car maxCar = new Car();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Car).Id > maxCar.Id)
                {
                    maxCar = this[i] as Car;
                }
            }
            return maxCar;
        }

        public bool IsContains(Car car)
        {
            //מחזירה האם האוסף מכיל כבר את המוצר 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Car).Id == car.Id)
                    return true;

            }
            return false;
        }

    }
}
