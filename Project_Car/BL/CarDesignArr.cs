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
    public class CarDesignArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = CarDesign_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            CarDesign carDesign;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                carDesign = new CarDesign(dataRow);

                this.Add(carDesign);
            }
        }

        public CarDesignArr Filter(CarColor carColor, ColorType colorTypes, BodyDesign bodyDesign)
        {
            CarDesignArr carDesignArr = new CarDesignArr();

            for (int i = 0; i < this.Count; i++)
            {
                CarDesign carDesign = (this[i] as CarDesign);
                if
                    (
                    ((carColor == null) || (carDesign.CarColor.Id == carColor.Id))
                    && ((colorTypes == null) || (carDesign.ColorType.Id == colorTypes.Id))
                    && ((bodyDesign == null) || (carDesign.BodyDesign.Id == bodyDesign.Id))
                    )
                    carDesignArr.Add(carDesign);



            }
            return carDesignArr;
        }

        public bool DoesExist(CarColor carColor)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarDesign).CarColor.Id == carColor.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(ColorType colorTypes)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarDesign).ColorType.Id == colorTypes.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(BodyDesign bodyDesign)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarDesign).BodyDesign.Id == bodyDesign.Id)
                    return true;
            }
            return false;
        }

        public bool IsContain(string carDesign)
        {
            string curCarDesign;

            for (int i = 0; i < this.Count; i++)
            {
                curCarDesign = (this[i] as CarDesign).ToString();

                if (curCarDesign == carDesign)
                    return true;
            }
            return false;
        }

        public CarDesign GetCarDesignWithMaxId()
        {
            CarDesign maxCar = new CarDesign();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarDesign).Id > maxCar.Id)
                {
                    maxCar = this[i] as CarDesign;
                }
            }
            return maxCar;
        }

        public bool IsContains(CarDesign carDesign)
        {
            //מחזירה האם האוסף מכיל כבר את עיצוב 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarDesign).Id == carDesign.Id)
                    return true;

            }
            return false;
        }

        

    }
}
