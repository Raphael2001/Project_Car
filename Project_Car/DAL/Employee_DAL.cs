using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.DAL
{
    public class Employee_DAL
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Employee"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { 
            if (!dataSet.Tables.Contains("Table_Employee"))
            {

                Dal.FillDataSet(dataSet, "Table_Employee", "[Fullname],[Phone number]");

                Role_DAL.FillDataSet(dataSet);

                DataRelation dataRelation = null;
                dataRelation = new DataRelation("EmployeeRole", dataSet.Tables["Table_Role"].Columns["Id"],
                    dataSet.Tables["Table_Employee"].Columns["Role"]);

                dataSet.Relations.Add(dataRelation);
            }

        }

        public static bool Insert(string Fullname, string Phonenumber, DateTime Birthday, string Gender, string Email, int Role,
            int Salary, string Username, string Password)
        {
            string str = "INSERT INTO Table_Employee"
                + "("
                + "[Fullname]"
                + ",[Phone number]"
                + ",[Birthday]"
                + ",[Gender]"
                + ",[Email]"
                + ",[Role]"
                + ",[Salary]"
                + ",[Username]"
                + ",[Password]"
                + ")"

                + " VALUES "
                + "("
                + "'" + Fullname + "'"
                + "," + "'" + Phonenumber + "'"
                + "," + "'" + Birthday + "'"
                + "," + "'" + Gender + "'"
                + "," + "'" + Email + "'"
                + "," + "" + Role + ""
                + "," + "" + Salary + ""
                + "," + "'" + Username + "'"
                + "," + "'" + Password + "'"
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static bool Update(int Id, string Fullname, string Phonenumber, DateTime Birthday, string Gender, string Email,
            int Role, int Salary, string Username, string Password)
        {
            string str = "Update Table_Employee SET"
                + "" + "[Fullname] = " + "'" + Fullname + "'"
                + "," + "[Phone number] =" + "'" + Phonenumber + "'"
                + "," + "[Birthday] = " + "'" + Birthday + "'"
                + "," + "[Gender] = " + "'" + Gender + "'"
                + "," + "[Email] = " + "'" + Email + "'"
                + "," + "[Role] = " + "" + Role + ""
                + "," + "[Salary]=" + "" + Salary + ""
                + "," + "[Username] = " + "'" + Username + "'"
                + "," + "[Password] = " + "'" + Password + "'"

                + " WHERE ID = " + Id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = "DELETE FROM Table_Employee" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }

        public static int CountEmail(string Email)
        {
            string str = "Select * From Table_Employee where Email ='" + Email + "' ";

            return Dal.CountData(str);
        }

        public static int CountPhone(string Phone)
        {
            string str = "Select * From Table_Employee where Phone number ='" + Phone + "'";

            return Dal.CountData(str);
        }

        public static int CountUsername(string Username)
        {
            string str = "Select * From Table_Employee where Username" +
                "='" + Username + "'";

            return Dal.CountData(str);

        }
    }
}
