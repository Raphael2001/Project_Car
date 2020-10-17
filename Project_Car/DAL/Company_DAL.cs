using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class Company_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Company"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_Company"))
            {
                Dal.FillDataSet(dataSet, "Table_Company", "[Name]");
            }
        }

        public static bool Insert(string Company)
        {
            string str = "INSERT INTO Table_Company"
                + "("
                + "[Name]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Company + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Company)
        {
            string str = "Update Table_Company SET"
                + "" + "[Name] = " + "'" + Company + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Company" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
