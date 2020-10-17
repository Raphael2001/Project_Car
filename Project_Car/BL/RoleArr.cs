using Project_Car.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class RoleArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = Role_DAL.GetDataTable();
            Role role = new Role();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                role = new Role(dataRow);

                this.Add(role);
            }
        }

        public bool IsContain(string JobTitle)
        {
            string curJobTitle;

            for (int i = 0; i < this.Count; i++)
            {
                curJobTitle = (this[i] as Role).JobTitle;

                if (curJobTitle == JobTitle)
                    return true;
            }
            return false;
        }

        public Role GetRoleWithMaxId()
        {
            Role maxRole = new Role();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Role).Id > maxRole.Id)
                {
                    maxRole = this[i] as Role;
                }
            }
            return maxRole;
        }
    }
}
