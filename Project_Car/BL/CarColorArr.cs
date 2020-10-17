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
   public class CarColorArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = CarColor_DAL.GetDataTable();
            CarColor color = new CarColor();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                color = new CarColor(dataRow);

                this.Add(color);
            }
        }

        public bool IsContain(string ColorName)
        {
            string curColorName;

            for (int i = 0; i < this.Count; i++)
            {
                curColorName = (this[i] as CarColor).Name;

                if (curColorName == ColorName)
                    return true;
            }
            return false;
        }

        public CarColor GetColorWithMaxId()
        {
            CarColor maxColor = new CarColor();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CarColor).Id > maxColor.Id)
                {
                    maxColor = this[i] as CarColor;
                }
            }
            return maxColor;
        }
    }
}
