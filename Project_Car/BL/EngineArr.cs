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
    public class EngineArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = Engine_DAL.GetDataTable();
            Engine engine = new Engine();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                engine = new Engine(dataRow);

                this.Add(engine);
            }
        }

        public bool IsContain(string EngineName)
        {
            string curEngineName;

            for (int i = 0; i < this.Count; i++)
            {
                curEngineName = (this[i] as Engine).Name;

                if (curEngineName == EngineName)
                    return true;
            }
            return false;
        }

        public Engine GetEngineWithMaxId()
        {
            Engine maxEngine = new Engine();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Engine).Id > maxEngine.Id)
                {
                    maxEngine = this[i] as Engine;
                }
            }
            return maxEngine;
        }
    }
}
