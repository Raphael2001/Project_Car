using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class Client_DAL
    {
        public static bool Insert(string FullName, string PhoneNumber, int City, int Street, int Number, DateTime Birthday,
            string Gender, string Email)
        {
            string str = "INSERT INTO Table_Client"
                + "("
                + "[FullName]"
                + ",[PhoneNumber]"
                + ",[Birthday]"
                + ",[City]"
                + ",[Street]"
                + ",[Number]"
                + ",[Gender]"
                + ",[Email]"
                + ")"

                + " VALUES "
                + "("
                + "'" + FullName + "'"
                + "," + "'" + PhoneNumber + "'"
                + "," + "'" + Birthday + "'"
                + "," + "" + City + ""
                 + "," + "" + Street + ""
                 + "," + "" + Number + ""
                + "," + "'" + Gender + "'"
                + "," + "'" + Email + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static int CountEmail(string Email)
        {
            string str = "Select * From Table_Client where Email ='" + Email + "' ";

            return Dal.CountData(str);
        }

        public static int CountPhone(string Phone)
        {
            string str = "Select * From Table_Client where PhoneNumber ='" + Phone + "'";

            return Dal.CountData(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            Dal.FillDataSet(dataSet, "Table_Client", "[ID]");

            City_DAL.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation("ClientCity", dataSet.Tables["Table_City"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["City"]);

            dataSet.Relations.Add(dataRelation);

            Street_DAL.FillDataSet(dataSet);

             dataRelation = null;
            dataRelation = new DataRelation("ClientStreet", dataSet.Tables["Table_Street"].Columns["ID"],
                dataSet.Tables["Table_Client"].Columns["Street"]);

            dataSet.Relations.Add(dataRelation);



        }

        public static bool Update(int Id, string FullName, string PhoneNumber, int City, int Street, int Number,
            DateTime Birthday, string Gender, string Email)
        {
            string str = "Update Table_Client SET"
                + "" + "[Fullname] = " + "'" + FullName + "'"
                + "," + "[PhoneNumber] = " + "'" + PhoneNumber + "'"
                + "," + "[City] = " + "" + City + ""
                + "," + "[Street] = " + "" + Street + ""
                + "," + "[Number]=" + "" + Number + ""
                + "," + "[Birthday] = " + "'" + Birthday + "'"
                + "," + "[Gender] = " + "'" + Gender + "'"
                + "," + "[Email] = " + "'" + Email + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Client" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
