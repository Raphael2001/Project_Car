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
    public class StreetArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Street_DAL.GetDataTable();
            Street street = new Street();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                street = new Street(dataRow);

                this.Add(street);
            }
        }

        public bool IsContain(string StreetName)
        {
            string curStreetName;

            for (int i = 0; i < this.Count; i++)
            {
                curStreetName = (this[i] as Street).Name;

                if (curStreetName == StreetName)
                    return true;
            }
            return false;
        }

        public StreetArr Filter(string Name)
        {
            StreetArr streetArr = new StreetArr();

            for (int i = 0; i < this.Count; i++)
            {
                Street street = (this[i] as Street);

                if (street.Name.Contains(Name))
                {
                    streetArr.Add(street);
                }

            }
            return streetArr;
        }

        public Street GetStreetWithMaxId()
        {
            Street maxStreet = new Street();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Street).Id > maxStreet.Id)
                {
                    maxStreet = this[i] as Street;
                }
            }
            return maxStreet;
        }








        public int GetId(string Street)
        {
            //  לא אפשרי שתהיה אותה כתובת פעמיים לכן אפשר להחזיר את הכתבות במקום ה0 

            StreetArr streetArr = new StreetArr();
            streetArr.Fill();
            streetArr = streetArr.Filter(Street);
            Street street = (streetArr[0] as Street);
            return street.Id;
        }

    }
}
