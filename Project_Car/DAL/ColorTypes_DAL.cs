using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class ColorTypes_DAL
    {

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_ColorTypes"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_ColorTypes"))
            {
                Dal.FillDataSet(dataSet, "Table_ColorTypes", "[Name]");

               
            }
        }

        public static bool Insert(string Name, int Price)
        {
            string str = "INSERT INTO Table_ColorTypes"
                + "("
                + "[Name]"
                + ",[Price]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Name + "'"
                + "," + "" + Price + ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Name, int Price)
        {
            string str = "Update Table_ColorTypes SET"
                + "" + "[Name] = " + "'" + Name + "'"
                + "," + "[Price] = " + "" + Price + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_ColorTypes" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }

    }
}
