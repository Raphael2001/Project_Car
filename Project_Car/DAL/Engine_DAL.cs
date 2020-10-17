using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class Engine_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Engine"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_Engine"))
            {
                Dal.FillDataSet(dataSet, "Table_Engine", "[Name]");
            }
        }

        public static bool Insert(string Engine)
        {
            string str = "INSERT INTO Table_Engine"
                + "("
                + "[Name]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Engine + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Engine)
        {
            string str = "Update Table_Engine SET"
                + "" + "[Name] = " + "'" + Engine + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Engine" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
