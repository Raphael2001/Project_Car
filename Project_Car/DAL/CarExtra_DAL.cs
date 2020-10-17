using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    public class CarExtra_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_CarExtra"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 
            if (!dataSet.Tables.Contains("Table_CarExtra"))
            {
                Dal.FillDataSet(dataSet, "Table_CarExtra", "[Name]");
            }
        }

        public static bool Insert(string Name, int Price, int Count)
        {
            string str = "INSERT INTO Table_CarExtra"
                + "("
                + "[Name]"
                + ",[Price]"
                + ",[Count]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Name + "'"
                + "," + "" + Price + ""
                + "," + "" + Count + ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Name, int Price, int Count)
        {
            string str = "Update Table_CarExtra SET"
                + "" + "[Name] = " + "'" + Name + "'"
                + "," + "[Price] = " + "" + Price + ""
                + "," + "[Count] = " + "" + Count + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_CarExtra" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }

    }
}
