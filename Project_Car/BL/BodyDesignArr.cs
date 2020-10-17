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
   public class BodyDesignArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = BodyDesign_DAL.GetDataTable();
            BodyDesign bodyDesign = new BodyDesign();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                bodyDesign = new BodyDesign(dataRow);

                this.Add(bodyDesign);
            }
        }

        public bool IsContain(string BodyDesingName)
        {
            string curBodyDesingName;

            for (int i = 0; i < this.Count; i++)
            {
                curBodyDesingName = (this[i] as BodyDesign).Name;

                if (curBodyDesingName == BodyDesingName)
                    return true;
            }
            return false;
        }

        public BodyDesign GetBodyDesignWithMaxId()
        {
            BodyDesign maxColor = new BodyDesign();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as BodyDesign).Id > maxColor.Id)
                {
                    maxColor = this[i] as BodyDesign;
                }
            }
            return maxColor;
        }
    }
}
