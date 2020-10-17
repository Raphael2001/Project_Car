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
    public class CityArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = City_DAL.GetDataTable();
            City city = new City();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                city = new City(dataRow);

                this.Add(city);
            }
        }

        public bool IsContain(string CityName)
        {
            string curCityName;

            for (int i = 0; i < this.Count; i++)
            {
                curCityName = (this[i] as City).Name;

                if (curCityName == CityName)
                    return true;
            }
            return false;
        }

        public City GetCityWithMaxId()
        {
            City maxCity = new City();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as City).Id > maxCity.Id)
                {
                    maxCity = this[i] as City;
                }
            }
            return maxCity;
        }
    }
}
