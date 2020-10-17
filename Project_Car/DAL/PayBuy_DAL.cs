using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class PayBuy_DAL
    {
        public static bool Insert(int OrderBuy, string FullName, string CardNumber, DateTime Date, string CVC)
        {
            string str = "INSERT INTO Table_PayBuy"
                + "("
                + "[OrderBuy]"
                + ",[FullName]"
                + ",[CardNumber]"
                + ",[Date]"
                + ",[CVC]"
                + ")"

                + " VALUES "
                + "("
                + "" + OrderBuy + ""
                + "," + "'" + FullName + "'"
                + "," + "'" + CardNumber + "'"
                + "," + "'" + Date + "'"
                + "," + "'" + CVC + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_PayBuy"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_PayBuy"))
            {

                Dal.FillDataSet(dataSet, "Table_PayBuy", "[ID]");

                OrderBuy_DAL.FillDataSet(dataSet);

                DataRelation dataRelation = null;
                dataRelation = new DataRelation("PayBuyOrderBuy", dataSet.Tables["Table_OrderBuy"].Columns["Id"],
                    dataSet.Tables["Table_PayBuy"].Columns["OrderBuy"]);

                dataSet.Relations.Add(dataRelation);

            }

        }

        public static bool Update(int Id, int OrderBuy, string FullName, string CardNumber, DateTime Date, string CVC)
        {
            string str = "Update Table_PayBuy SET"
                + "" + "[OrderBuy] = " + "" + OrderBuy + ""
                + "," + "[FullName]=" + "'" + FullName + "'"
                + "," + "[CardNumber] = " + "'" + CardNumber + "'"
                + "," + "[Date]=" + "'" + Date + "'"
                + "," + "[CVC]=" + "'" + CVC + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_PayBuy" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}

