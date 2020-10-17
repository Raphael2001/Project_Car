using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class City_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_City"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            if (!dataSet.Tables.Contains("Table_City"))
            {
                Dal.FillDataSet(dataSet, "Table_City", "[Name]");
            }
        }

        public static bool Insert(string City)
        {
            string str = "INSERT INTO Table_City"
                + "("
                + "[Name]"
                + ")"

                + " VALUES "
                + "("
                + "'" + City + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string City)
        {
            string str = "Update Table_City SET"
                + "" + "[Name] = " + "'" + City + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_City" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
