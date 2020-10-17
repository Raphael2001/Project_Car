using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class OrderDetailsRent_DAL
    {
        public static bool Insert(int Order, int CarExtra)
        {
            string str = "INSERT INTO Table_OrderDetailsRent"
                + "("
                + "[Order]"
                + ",[CarExtra]"
                + ")"

                + " VALUES "
                + "("
                + "" + Order + ""
                + "," + "" + CarExtra + ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderDetailsRent"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            Dal.FillDataSet(dataSet, "Table_OrderDetailsRent", "[ID]");

            CarExtra_DAL.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation("OrderDetailsRentCarExtra", dataSet.Tables["Table_CarExtra"].Columns["Id"],
                dataSet.Tables["Table_OrderDetailsRent"].Columns["CarExtra"]);

            dataSet.Relations.Add(dataRelation);

            OrderRent_DAL.FillDataSet(dataSet);

            dataRelation = null;
            dataRelation = new DataRelation("OrderDetailsRentOrder", dataSet.Tables["Table_OrderRent"].Columns["Id"],
                dataSet.Tables["Table_OrderDetailsRent"].Columns["Order"]);

            dataSet.Relations.Add(dataRelation);

        }

        public static bool Update(int Id, int Order, int CarExtra)
        {
            string str = "Update Table_OrderDetailsRent SET"
                + "" + "[Order] = " + "" + Order + ""
                + "," + "[CarExtra] = " + "" + CarExtra + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_OrderDetailsRent" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
