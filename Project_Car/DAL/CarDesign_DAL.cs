using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    public class CarDesign_DAL
    {

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_CarDesign"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 

            if (!dataSet.Tables.Contains("Table_CarDesign"))
            {
                Dal.FillDataSet(dataSet, "Table_CarDesign", "[Id]");

                CarColor_DAL.FillDataSet(dataSet);

                DataRelation dataRelation = null;
                dataRelation = new DataRelation("CarcarColor", dataSet.Tables["Table_Color"].Columns["Id"],
                    dataSet.Tables["Table_CarDesign"].Columns["CarColor"]);

                dataSet.Relations.Add(dataRelation);

                ColorTypes_DAL.FillDataSet(dataSet);

                 dataRelation = null;
                dataRelation = new DataRelation("CarColorType", dataSet.Tables["Table_ColorTypes"].Columns["Id"],
                    dataSet.Tables["Table_CarDesign"].Columns["ColorType"]);

                dataSet.Relations.Add(dataRelation);

                BodyDesign_DAL.FillDataSet(dataSet);

                 dataRelation = null;
                dataRelation = new DataRelation("CarBodyDesign", dataSet.Tables["Table_BodyDesign"].Columns["Id"],
                    dataSet.Tables["Table_CarDesign"].Columns["BodyDesign"]);

                dataSet.Relations.Add(dataRelation);
            }
        }

        public static bool Insert(int CarColor, int ColorType, int BodyDesign)
        {
            string str = "INSERT INTO Table_CarDesign"
                + "("
                + "[CarColor]"
                + ",[ColorType]"
                + ",[BodyDesign]"
                + ")"

                + " VALUES "
                + "("
                + "" + CarColor + ""
                + "," + "" + ColorType + ""
                + "," + "" + BodyDesign + ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, int CarColor, int ColorType, int BodyDesign)
        {
            string str = "Update Table_CarDesign SET"
                + "" + "[CarColor] = " + "" + CarColor + ""
                + "," + "[ColorType] = " + "" + ColorType + ""
                + "," + "[BodyDesign] = " + "" + BodyDesign + ""

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            
            string str = "DELETE FROM Table_CarDesign" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }


    }
}
