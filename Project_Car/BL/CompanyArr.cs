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
    class CompanyArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = Company_DAL.GetDataTable();
            Company company = new Company();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                company = new Company(dataRow);

                this.Add(company);
            }
        }

        public bool IsContain(string CompanyName)
        {
            string curCompanyName;

            for (int i = 0; i < this.Count; i++)
            {
                curCompanyName = (this[i] as Company).Name;

                if (curCompanyName == CompanyName)
                    return true;
            }
            return false;
        }

        public Company GetCompanyWithMaxId()
        {
            Company maxCompany = new Company();

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Company).Id > maxCompany.Id)
                {
                    maxCompany = this[i] as Company;
                }
            }
            return maxCompany;
        }

        public Company GetCompany(string Name)
        {

            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Company).Name == Name)
                {
                    return this[i] as Company;
                }
            }
            return null;
        }

        public bool DoesExist(Category curCategory)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Company).Id == curCategory.Company.Id)
                    return true;
            }
            return false;
        }


    }
}
