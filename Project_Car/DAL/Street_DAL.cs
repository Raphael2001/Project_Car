using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    public class Street_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Street"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            if (!dataSet.Tables.Contains("Table_Street"))
            {
                Dal.FillDataSet(dataSet, "Table_Street", "[Name]");
            }
        }

        public static bool Insert(string Street)
        {
            string str = "INSERT INTO Table_Street"
                + "("
                + "[Name]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Street + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Street)
        {
            string str = "Update Table_Street SET"
                + "" + "[Name] = " + "'" + Street + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Street" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
