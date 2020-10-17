using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class Role_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Role"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_Role"))
            {
                Dal.FillDataSet(dataSet, "Table_Role", "[Job Title]");
            }
        }

        public static bool Insert(string Role)
        {
            string str = "INSERT INTO Table_Role"
                + "("
                + "[Job Title]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Role + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Role)
        {
            string str = "Update Table_Role SET"
                + "" + "[Job Title] = " + "'" + Role + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Role" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
