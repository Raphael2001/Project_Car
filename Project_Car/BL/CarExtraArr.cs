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
    public class CarExtraArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = CarExtra_DAL.GetDataTable();
            CarExtra carExtra = new CarExtra();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                carExtra = new CarExtra(dataRow);

                this.Add(carExtra);
            }
        }

        public bool IsContain(string CarExtraName)
        {
            string curCarExtraName;

            for (int i = 0; i < this.Count; i++)
            {
                curCarExtraName = (this[i] as CarExtra).Name;

                if (curCarExtraName == CarExtraName)
                    return true;
            }
            return false;
        }

        public CarExtra GetCarExtraWithMaxId()
        {
            CarExtra maxCarExtra = new CarExtra();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarExtra).Id > maxCarExtra.Id)
                {
                    maxCarExtra = this[i] as CarExtra;
                }
            }
            return maxCarExtra;
        }

        public CarExtraArr Filter(int Id, string Name, int MinPrice,
            int MaxPrice, int MaxCount)
        {
            CarExtraArr carExtraArr = new CarExtraArr();

            for (int i = 0; i < this.Count; i++)
            {
                CarExtra carExtra = (this[i] as CarExtra);


                if (
                    (Id <= 0 || carExtra.Id == Id)
                    && (carExtra.Name.Contains(Name))
                    && (carExtra.Price >= MinPrice)
                    && (carExtra.Price <= MaxPrice)
                    && (carExtra.Count <= MaxCount)
                    )
                {
                    carExtraArr.Add(carExtra);
                }
            }
            return carExtraArr;
        }

        public CarExtraArr Filter(int MaxCount)
        {
            CarExtraArr carExtraArr = new CarExtraArr();

            for (int i = 0; i < this.Count; i++)
            {
                CarExtra carExtra = (this[i] as CarExtra);


                if (
  
                    (carExtra.Count <= MaxCount)
                    )
                {
                    carExtraArr.Add(carExtra);
                }
            }
            return carExtraArr;
        }

        public int GetMaxPrice()
        {
            int maxPrice = 0;

            for (int i = 0; i < this.Count; i++)
            {
                CarExtra carExtra = (this[i] as CarExtra);
                if (carExtra.Price > maxPrice)
                {
                    maxPrice = carExtra.Price;
                }
            }

            return maxPrice;
        }

        public bool IsContains(CarExtra carExtra)
        {
            //מחזירה האם האוסף מכיל כבר את המוצר 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarExtra).Id == carExtra.Id)
                    return true;

            }
            return false;
        }

        public void Remove(CarExtraArr carExtraArr)
        {
            for (int i = 0; i < carExtraArr.Count; i++)
            {
                this.Remove(carExtraArr[i] as CarExtra);
            }
        }

        public void Remove(CarExtra carExtra)
        {
            //מסירה מהאוסף הנוכחי את הפריט המתקבל 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarExtra).Id == carExtra.Id)
                {
                    this.RemoveAt(i);
                    break;
                }
            }
        }

        public int Price()
        {
            int sum = 0;
            for (int i = 0; i < this.Count; i++)
            {
                CarExtra carExtra = (this[i] as CarExtra);
                sum += carExtra.Price;
            }
            return sum;
        }

        public int GetMaxCount()
        {
            int MaxCount = 0;

            for (int i = 0; i < this.Count; i++)
            {
                CarExtra carExtra = (this[i] as CarExtra);
                if (carExtra.Count > MaxCount)
                {
                    MaxCount = carExtra.Count;
                }
            }

            return MaxCount;
        }

        public void Update()
        {
            //מעדכנת את אוסף המוצרים 
            for (int i = 0; i < this.Count; i++)
            {
                (this[i] as CarExtra).Update();
            }
        }
    }
}
