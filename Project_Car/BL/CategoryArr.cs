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
   public class CategoryArr : ArrayList
    {
        public void Fill()
        {

            DataTable dataTable = Category_DAL.GetDataTable();
            Category category = new Category();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                category = new Category(dataRow);

                this.Add(category);
            }
        }

        public CategoryArr Filter(int id, Company company)
        {
            CategoryArr categoryArr = new CategoryArr();

            for (int i = 0; i < this.Count; i++)
            {
                Category category = (this[i] as Category);
                if
                    (
                    (id <= 0 || category.Id == id)
                    && ((company == null) || (category.Company.Id == company.Id))
                    )
                {
                    categoryArr.Add(category);
                    if (id > 0)
                        break;

                }

            }
            return categoryArr;
        }

        public bool IsContain(string CategoryName)
        {
            string curCategoryName;

            for (int i = 0; i < this.Count; i++)
            {
                curCategoryName = (this[i] as Category).Name;

                if (curCategoryName == CategoryName)
                    return true;
            }
            return false;
        }

        public Category GetCategoryWithMaxId()
        {
            Category maxCategory = new Category();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Category).Id > maxCategory.Id)
                {
                    maxCategory = this[i] as Category;
                }
            }
            return maxCategory;
        }
    }
}
