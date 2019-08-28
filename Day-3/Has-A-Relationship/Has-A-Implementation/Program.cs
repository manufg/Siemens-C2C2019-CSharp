using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_A_Implementation
{
    class Program
    {
        static Department[] CreateDepartmentStorage()
        {
            Department[] departments = new Department[]
            {
                new Department{ DepartmentName = "HR", DepartmentId = 1},
                new Department("Training",2),
                new Department("Resources",3)
            };
            return departments;
        }
        static Employee[] CreateEmployeeStorage(Department[] departments)
        {
            Employee[] employees = new Employee[]
            {
                new Employee{ EmployeeName="anil", EmployeeId=1, Salary=10000, DepartmentInfo = departments[0] },
                new Employee("vinod", 2, 20000, departments[1]),
                new Employee{ EmployeeName = "sunil", EmployeeId=3, DepartmentInfo =  departments[0], Salary=30000 },
                new Employee("ram", 4, 40000, departments[1])
            };
            return employees;
        }
        static void Main()
        {
            Department[] departments = CreateDepartmentStorage();
            Employee[] employees = CreateEmployeeStorage(departments);

            departments[0].Employees = new Employee[] { employees[0], employees[2] };
            departments[1].Employees = new Employee[] { employees[1], employees[3] };

            /*select e.employeename, count(employeename) as employeecount from employees e join departments d on e.departmentid = d.departmentid */

            /*
             * HR: 2
             * -----------------
             * name1
             * name2
             * 
             * Training: 2
             * ------------
             * name1
             * name2
             * 
             * Dept-name: 0
             * ---------------
             * NA
             */

            foreach (Department d in departments)
            {                
                Employee[] departmentEmployees = d.Employees;
                if (departmentEmployees != null && departmentEmployees.Length > 0)
                {
                    Console.WriteLine($"{d.DepartmentName}:{d.Employees.Length}");
                    Console.WriteLine("----------------------------");
                    foreach (Employee e in departmentEmployees)
                    {
                        Console.WriteLine(e.EmployeeName);
                    }
                }
                else
                {
                    Console.WriteLine($"{d.DepartmentName}: 0");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("NA");
                }
                Console.WriteLine("");
            }
        }
    }
}
