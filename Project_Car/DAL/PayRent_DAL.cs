using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class PayRent_DAL
    {
        public static bool Insert(int OrderRent, string FullName, string CardNumber, DateTime Date, string CVC)
        {
            string str = "INSERT INTO Table_PayRent"
                + "("
                + "[OrderRent]"
                + ",[FullName]"
                + ",[CardNumber]"
                + ",[Date]"
                + ",[CVC]"
                + ")"

                + " VALUES "
                + "("
                + "" + OrderRent + ""
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
            dataTable = dataSet.Tables["Table_PayRent"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_PayRent"))
            {

                Dal.FillDataSet(dataSet, "Table_PayRent", "[ID]");

                OrderRent_DAL.FillDataSet(dataSet);

                DataRelation dataRelation = null;
                dataRelation = new DataRelation("PayRentOrderRent", dataSet.Tables["Table_OrderRent"].Columns["Id"],
                    dataSet.Tables["Table_PayRent"].Columns["OrderRent"]);

                dataSet.Relations.Add(dataRelation);

            }

        }

        public static bool Update(int Id, int OrderRent, string FullName, string CardNumber, DateTime Date, string CVC)
        {
            string str = "Update Table_PayRent SET"
                + "" + "[OrderRent] = " + "" + OrderRent + ""
                + "," + "[FullName]=" + "'" + FullName + "'"
                + "," + "[CardNumber] = " + "'" + CardNumber + "'"
                + "," + "[Date]=" + "'" + Date + "'"
                + "," + "[CVC]=" + "'" + CVC + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_PayRent" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}

