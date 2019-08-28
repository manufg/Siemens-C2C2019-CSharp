using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRMSAPP.Entities;
using HRMSAPP.DataAccessLayer;

namespace HRMSAPP.BusinessLayer
{
    public class EmployeeBo
    {
        private EmployeeDao dao;

        public bool Insert(Employee employee)
        {
            dao = new EmployeeDao();
            Employee[] employees = dao.GetEmployees();
            if (!Exists(employee, employees))
                return dao.Add(employee);
            else
                return false;
        }
        private static bool Exists(Employee employee, Employee[] employees)
        {
            bool exists = false;
            if (employees != null && employee != null)
            {
                foreach (Employee item in employees)
                {
                    if (item != null)
                    {
                        if (item.Equals(employee))
                        {
                            exists = true;
                            break;
                        }

                    }
                }
            }
            return exists;
        }
    }
}
