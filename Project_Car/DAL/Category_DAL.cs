using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class Category_DAL
    {

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Category"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_Category"))
            {
                Dal.FillDataSet(dataSet, "Table_Category", "[Company]");

                Company_DAL.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation("CategoryCompany", dataSet.Tables["Table_Company"].Columns["Id"],
                    dataSet.Tables["Table_Category"].Columns["Company"]);
                dataSet.Relations.Add(dataRelation);
            }
        }

        public static bool Insert(int Company, string Category)
        {
            string str = "INSERT INTO Table_Category"
                + "("
                + "[Company]"
                + ",[Name]"
                + ")"

                + " VALUES "
                + "("
                + "" + Company + ""
                + "," + "'" + Category + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, int Company, string Category)
        {
            string str = "Update Table_Category SET"
                + "" + "[Company]=" + "" + Company + ""
                + "," + "[Name] = " + "'" + Category + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Category" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
