using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    class Car_DAL
    {

        public static bool Insert(string Model, int Company, int Category, int Engine, int HorsePower)
        {
            string str = "INSERT INTO Table_Car"
                + "("
                + "[Model]"
                + ",[Company]"
                + ",[Category]"
                + ",[Engine]"
                + ",[Horse Power]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Model + "'"
                + "," + "" + Company + ""
                + "," + "" + Category + ""
                + "," + "" + Engine + ""
                + "," + "" + HorsePower + ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Car"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 
            if (!dataSet.Tables.Contains("Table_Car"))
            {

                Dal.FillDataSet(dataSet, "Table_Car", "[Company]");

                Company_DAL.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation("CarCompany", dataSet.Tables["Table_Company"].Columns["Id"],
                    dataSet.Tables["Table_Car"].Columns["Company"]);
                dataSet.Relations.Add(dataRelation);


                Engine_DAL.FillDataSet(dataSet);
                dataRelation = null;
                dataRelation = new DataRelation("CarEngine", dataSet.Tables["Table_Engine"].Columns["ID"],
                    dataSet.Tables["Table_Car"].Columns["Engine"]);
                dataSet.Relations.Add(dataRelation);


                Category_DAL.FillDataSet(dataSet);
                dataRelation = null;
                dataRelation = new DataRelation("CarCategory", dataSet.Tables["Table_Category"].Columns["Id"],
                    dataSet.Tables["Table_Car"].Columns["Category"]);
                dataSet.Relations.Add(dataRelation);
            }

        }

        public static bool Update(int Id, string Model, int Company, int Category, int Engine, int HorsePower)
        {
            string str = "Update Table_Car SET"
                + "" + "[Model] = " + "'" + Model + "'"
                + "," + "[Company] = " + "" + Company + ""
                + "," + "[Category]=" + "" + Category + ""
                + "," + "[Engine] = " + "" + Engine + ""
                + "," + "[Horse Power] = " + "" + HorsePower + ""

                     + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Car" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
