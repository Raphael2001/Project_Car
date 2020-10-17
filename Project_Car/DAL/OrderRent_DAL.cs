using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    public class OrderRent_DAL
    {
        public static bool Insert(int Client, int Product, DateTime DateFrom, DateTime DateTo, int Employee, string Comment,
            int TotalPrice)
        {
            string str = "INSERT INTO Table_OrderRent"
                + "("
                + "[Client]"
                + ",[Product]"
                + ",[DateFrom]"
                + ",[DateTo]"
                + ",[Employee]"
                + ",[Comment]"
                + ",[TotalPrice]"
                + ")"

                + " VALUES "
                + "("
                + "" + Client + ""
                + "," + "" + Product + ""
                + "," + "'" + DateFrom + "'"
                + "," + "'" + DateTo + "'"
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
            dataTable = dataSet.Tables["Table_OrderRent"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            if (!dataSet.Tables.Contains("Tabel_OrderRent"))
            {

                Dal.FillDataSet(dataSet, "Table_OrderRent", "[ID]");

                Client_DAL.FillDataSet(dataSet);

                DataRelation dataRelation = null;
                dataRelation = new DataRelation("OrderRentClient", dataSet.Tables["Table_Client"].Columns["Id"],
                    dataSet.Tables["Table_OrderRent"].Columns["Client"]);

                dataSet.Relations.Add(dataRelation);

                Product_DAL.FillDataSet(dataSet);

                 dataRelation = null;
                dataRelation = new DataRelation("OrderRentProduct", dataSet.Tables["Table_Product"].Columns["Id"],
                    dataSet.Tables["Table_OrderRent"].Columns["Product"]);

                dataSet.Relations.Add(dataRelation);

                Employee_DAL.FillDataSet(dataSet);

                 dataRelation = null;
                dataRelation = new DataRelation("OrderRentEmployee", dataSet.Tables["Table_Employee"].Columns["Id"],
                    dataSet.Tables["Table_OrderRent"].Columns["Employee"]);

                dataSet.Relations.Add(dataRelation);
            }

        }

        public static bool Update(int Id, int Client, int Product, DateTime DateFrom, DateTime DateTo, int Employee, string Comment, 
            int TotalPrice)
        {
            string str = "Update Table_OrderRent SET"
                + "" + "[Client] = " + "" + Client + ""
                + "," + "[Product]=" + "" + Product + ""
                + "," + "[DateFrom] = " + "'" + DateFrom + "'"
                + "," + "[DateTo] = " + "'" + DateTo + "'"
                + "," + "[Employee]=" + "" + Employee + ""
                + "," + "[Comment] = " + "'" + Comment + "'"
                + "," + "[TotalPrice] = " + "" + TotalPrice + ""


                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_OrderRent" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
