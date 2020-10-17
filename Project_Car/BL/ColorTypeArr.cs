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
    class ColorTypeArr  : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = ColorTypes_DAL.GetDataTable();
            ColorType colorTypes = new ColorType();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                colorTypes = new ColorType(dataRow);

                this.Add(colorTypes);
            }
        }

        public bool IsContain(string ColorTypesName)
        {
            string curColorTypesName;

            for (int i = 0; i < this.Count; i++)
            {
                curColorTypesName = (this[i] as ColorType).Name;

                if (curColorTypesName == ColorTypesName)
                    return true;
            }
            return false;
        }

        public ColorType GetColorTypesWithMaxId()
        {
            ColorType maxColorTypes = new ColorType();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as ColorType).Id > maxColorTypes.Id)
                {
                    maxColorTypes = this[i] as ColorType;
                }
            }
            return maxColorTypes;
        }
    }
}
