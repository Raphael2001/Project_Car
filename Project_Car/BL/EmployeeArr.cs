using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project_Car.DAL;
using System.Collections;

namespace Project_Car.BL
{
    public class EmployeeArr : ArrayList
    {
        public void Fill()

        {
            DataTable dataTable = Employee_DAL.GetDataTable();
            Employee employee = new Employee();
            DataRow dataRow;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                employee = new Employee(dataRow);

                this.Add(employee);
            }
        }

        public EmployeeArr FilterUsername(string Username, string Password)
        {
            EmployeeArr employeeArr = new EmployeeArr();

            for (int i = 0; i < this.Count; i++)
            {
                Employee employee = (this[i] as Employee);

                if (employee.Username == Username && employee.Password == Password)
                {
                    employeeArr.Add(employee);
                }

            }
            return employeeArr;
        }

        public EmployeeArr Filter(int id, string Name, string PhoneNumber)
        {
            EmployeeArr employeeArr = new EmployeeArr();

            for (int i = 0; i < this.Count; i++)
            {
                Employee employee = (this[i] as Employee);
                if
                    (
                    (id <= 0 || employee.Id == id)
                    && employee.Fullname.Contains(Name)
                    && (employee.Phonenumber.Contains(PhoneNumber))
                    )
                    employeeArr.Add(employee);



            }
            return employeeArr;
        }

        public bool DoesExist(Role curRole)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Employee).Role.Id == curRole.Id)
                    return true;
            }
            return false;
        }

        public bool IsContainPhone(string EmployeePhone)
        {
            string curEmployeePhone;

            for (int i = 0; i < this.Count; i++)
            {
                curEmployeePhone = (this[i] as Employee).Phonenumber;

                if (curEmployeePhone == EmployeePhone)
                    return true;
            }
            return false;
        }

        public bool IsContainEmail(string EmployeeEmail)
        {
            string curEmployeeEmail;

            for (int i = 0; i < this.Count; i++)
            {
                curEmployeeEmail = (this[i] as Employee).Email;

                if (curEmployeeEmail == EmployeeEmail)
                    return true;
            }
            return false;
        }

        public bool IsContainUsername(string EmployeeUsername)
        {
            string curEmployeeUsername;

            for (int i = 0; i < this.Count; i++)
            {
                curEmployeeUsername = (this[i] as Employee).Username;

                if (curEmployeeUsername == EmployeeUsername)
                    return true;
            }
            return false;
        }

        public Employee GetEmployee(int Id)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Employee).Id == Id)
                {
                    return this[i] as Employee;
                }
            }
            return null;
        }

        public bool IsContains(Employee employee)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Employee).Id == employee.Id)
                    return true;

            }
            return false;
        }

        public double GetBonus(DateTime dateTime, Employee employee)
        {
            double Bonus = 0;
            OrderBuyArr orderBuyArr = new OrderBuyArr();
            orderBuyArr.Fill();

            OrderRentArr orderRentArr = new OrderRentArr();
            orderRentArr.Fill();

            orderBuyArr = orderBuyArr.Filter(employee, dateTime);
            orderRentArr = orderRentArr.Filter(employee, dateTime);

            for (int i = 0; i < orderBuyArr.Count; i++)
            {
                Bonus += (orderBuyArr[i] as OrderBuy).TotalPrice * 0.01;
            }
            for (int i = 0; i < orderRentArr.Count; i++)
            {
                Bonus += (orderRentArr[i] as OrderRent).TotalPrice * 0.01;
            }


            return Bonus;
        }

        public void FillNew()
        {
            DataTable dataTable = Employee_DAL.GetDataTable();
            Employee employee = new Employee();
            DataRow dataRow;
            double Bonus;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                employee = new Employee(dataRow);
                Bonus = GetBonus(DateTime.Now.Date, employee);

                employee.Salary += Convert.ToInt32(Bonus);

                this.Add(employee);
            }
        }
    }

}
