using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class BodyDesign_DAL
    {

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_BodyDesign"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { //ממלאת את אוסף הטבלאות בטבלת הלקוחות 

            if (!dataSet.Tables.Contains("Table_BodyDesign"))
            {
                Dal.FillDataSet(dataSet, "Table_BodyDesign", "[Name]");            
            }
        }

        public static bool Insert(string Name, int Price)
        {
            string str = "INSERT INTO Table_BodyDesign"
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
            string str = "Update Table_BodyDesign SET"
                + "" + "[Name] = " + "'" + Name + "'"
                + "," + "[Price] = " + "" + Price + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_BodyDesign" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }

    }
}
