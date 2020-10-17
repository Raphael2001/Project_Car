using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class OrderDetailsBuy_DAL
    {
        public static bool Insert(int Order, int CarExtra)
        {
            string str = "INSERT INTO Table_OrderDetailsBuy"
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
            dataTable = dataSet.Tables["Table_OrderDetailsBuy"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            Dal.FillDataSet(dataSet, "Table_OrderDetailsBuy", "[ID]");

            CarExtra_DAL.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation("OrderDetailsBuyCarExtra", dataSet.Tables["Table_CarExtra"].Columns["Id"],
                dataSet.Tables["Table_OrderDetailsBuy"].Columns["CarExtra"]);

            dataSet.Relations.Add(dataRelation);

            OrderBuy_DAL.FillDataSet(dataSet);

             dataRelation = null;
            dataRelation = new DataRelation("OrderDetailsBuyOrder", dataSet.Tables["Table_OrderBuy"].Columns["Id"],
                dataSet.Tables["Table_OrderDetailsBuy"].Columns["Order"]);

            dataSet.Relations.Add(dataRelation);

        }

        public static bool Update(int Id, int Order, int CarExtra)
        {
            string str = "Update Table_OrderDetailsBuy SET"
                + "" + "[Order] = " + "" + Order + ""
                + "," + "[CarExtra] = " + "" + CarExtra + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_OrderDetailsBuy" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
