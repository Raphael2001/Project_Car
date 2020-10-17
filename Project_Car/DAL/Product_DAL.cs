using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    public class Product_DAL
    {
        public static bool Insert(int Model, string Status, int Price, string LicenseNumber, string Doesavailable)
        {
            string str = "INSERT INTO Table_Product"
                + "("
                + "[Model]"
                + ",[Status]"
                + ",[Price]"
                + ",[LicenseNumber]"
                + ",[Doesavailable]"
                + ")"

                + " VALUES "
                + "("
                + "" + Model + ""
                + "," + "'" + Status + "'"
                + "," + "" + Price + ""
                + "," + "'" + LicenseNumber + "'"
                + "," + "'" + Doesavailable + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Product"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 
            
            if (!dataSet.Tables.Contains("Table_Product"))
            {

                Dal.FillDataSet(dataSet, "Table_Product", "[Model]");

                Car_DAL.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation("ProductModel", dataSet.Tables["Table_Car"].Columns["Id"],
                   dataSet.Tables["Table_Product"].Columns["Model"]);
                dataSet.Relations.Add(dataRelation);
            }
        }

        public static bool Update(int Id, int Model, string Status, int Price, string LicenseNumber, string Doesavailable )
        {
            string str = "Update Table_Product SET"
                + "" + "[Model] = " + "" + Model + ""
                + "," + "[Status] = " + "'" + Status + "'"
                + "," + "[Price]=" + "" + Price + ""
                + "," + "[LicenseNumber] = " + "'" + LicenseNumber + "'"
                + "," + "[Doesavailable] = " + "'" + Doesavailable + "'"

                     + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Product" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
