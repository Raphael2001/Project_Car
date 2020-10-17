using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class OrderBuy_DAL
    {
        public static bool Insert(int Client, int Product, DateTime DateOfBuy, int CarDesign,int Employee, string Comment,
            int TotalPrice)
        {
            string str = "INSERT INTO Table_OrderBuy"
                + "("
                + "[Client]"
                + ",[Product]"
                + ",[DateOfBuy]"
                + ",[CarDesign]"
                + ",[Employee]"
                + ",[Comment]"
                + ",[TotalPrice]"
                + ")"

                + " VALUES "
                + "("
                + "" + Client + ""
                + "," + "" + Product + ""
                + "," + "'" + DateOfBuy + "'"
                + "," + "" + CarDesign + ""
                + "," + "" + Employee + ""
                + "," + "'" + Comment + "'"
                + "," + "" + TotalPrice + ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderBuy"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_OrderBuy"))
            {

                Dal.FillDataSet(dataSet, "Table_OrderBuy", "[ID]");

                Client_DAL.FillDataSet(dataSet);

                DataRelation dataRelation = null;
                dataRelation = new DataRelation("OrderBuyClient", dataSet.Tables["Table_Client"].Columns["Id"],
                    dataSet.Tables["Table_OrderBuy"].Columns["Client"]);

                dataSet.Relations.Add(dataRelation);

                Product_DAL.FillDataSet(dataSet);

                 dataRelation = null;
                dataRelation = new DataRelation("OrderBuyProduct", dataSet.Tables["Table_Product"].Columns["Id"],
                    dataSet.Tables["Table_OrderBuy"].Columns["Product"]);

                dataSet.Relations.Add(dataRelation);

                CarDesign_DAL.FillDataSet(dataSet);

                dataRelation = null;
                dataRelation = new DataRelation("OrderBuyCarDesign", dataSet.Tables["Table_CarDesign"].Columns["Id"],
                    dataSet.Tables["Table_OrderBuy"].Columns["CarDesign"]);

                dataSet.Relations.Add(dataRelation);

                Employee_DAL.FillDataSet(dataSet);

                 dataRelation = null;
                dataRelation = new DataRelation("OrderBuyEmployee", dataSet.Tables["Table_Employee"].Columns["Id"],
                    dataSet.Tables["Table_OrderBuy"].Columns["Employee"]);

                dataSet.Relations.Add(dataRelation);

            }

        }

        public static bool Update(int Id, int Client, int Product, DateTime DateOfBuy, int CarDesign, int Employee, string Comment, int TotalPrice)
        {
            string str = "Update Table_OrderBuy SET"
                + "" + "[Client] = " + "" + Client + ""
                + "," + "[Product]=" + "" + Product + ""
                + "," + "[DateOfBuy] = " + "'" + DateOfBuy + "'"
                + "," + "[CarDesign]=" + "" + CarDesign + ""
                + "," + "[Employee]=" + "" + Employee + ""
                + "," + "[Comment] = " + "'" + Comment + "'"
                 + "," + "[TotalPrice] = " + "" + TotalPrice + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_OrderBuy" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
